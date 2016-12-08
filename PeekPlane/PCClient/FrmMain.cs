using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsClient
{
	/// <summary>
	/// SignalR client hosted in a WinForms application. The client
	/// lets the user pick a user name, connect to the server asynchronously
	/// to not block the UI thread, and send chat messages to all connected 
	/// clients whether they are hosted in WinForms, WPF, or a web application.
	/// </summary>
	public partial class FrmMain : Form
	{
		#region Private members
		/// <summary>
		/// This name is simply added to sent messages to identify the user; this 
		/// sample does not include authentication.
		/// </summary>
		private String UserName { get; set; }
		private IHubProxy HubProxy { get; set; }
		const string ServerURI = "http://localhost:8080/signalr";
		private HubConnection Connection { get; set; }

		private bool isValidSelection = false;

		private int tableId = -1;
		private List<Block> blocksMine = new List<Block>();
		private List<Block> blocksEnemy = new List<Block>();
		#endregion

		internal FrmMain()
		{
			InitializeComponent();
		}

		#region Methods
		private void InitBlocks()
		{
			blocksMine.Clear();
			blocksEnemy.Clear();
			pnlAreaMine.Controls.Clear();
			pnlBattleAreaEnemy.Controls.Clear();
			int blockIndex = 0;
			for (int j = 0; j < Consts.ROW_COUNT; j++)//row
			{
				for (int i = 0; i < Consts.COLUMN_COUNT; i++)//column
				{
					#region My blocks
					Block newBlock = new Block();
					newBlock.Visible = false;
					blocksMine.Add(newBlock);
					pnlAreaMine.Controls.Add(newBlock);
					newBlock.MouseEnter += item_MouseEnterMine;
					newBlock.Click += item_Click;
					newBlock.Width = Consts.BLOCK_WIDTH;
					newBlock.Height = Consts.BLOCK_HEIGHT;
					blocksMine[blockIndex].Left = (Consts.BLOCK_WIDTH + 1) * i;
					blocksMine[blockIndex].Top = (Consts.BLOCK_HEIGHT + 1) * j;
					blocksMine[blockIndex].Pos = new Point(i, j);
					blocksMine[blockIndex].Visible = true;
					#endregion

					#region Enemy blocks
					Block newBlockE = new Block();
					newBlockE.Visible = false;
					blocksEnemy.Add(newBlockE);
					pnlBattleAreaEnemy.Controls.Add(newBlockE);
					newBlockE.MouseEnter += item_MouseEnterEnemy;
					newBlockE.Click += item_ClickEnemy;
					newBlockE.MouseLeave += newBlockE_MouseLeave;
					newBlockE.Width = Consts.BLOCK_WIDTH;
					newBlockE.Height = Consts.BLOCK_HEIGHT;
					blocksEnemy[blockIndex].Left = (Consts.BLOCK_WIDTH + 1) * i;
					blocksEnemy[blockIndex].Top = (Consts.BLOCK_HEIGHT + 1) * j;
					blocksEnemy[blockIndex].Pos = new Point(i, j);
					blocksEnemy[blockIndex].Visible = true;
					#endregion

					blockIndex++;
					lblProgressbar.Width = Convert.ToInt32((double)blockIndex / (double)Consts.BLOCK_COUNT * 350);
					Application.DoEvents();
					if (blockIndex >= Consts.BLOCK_COUNT) break;
				}
			}
		}

		private bool PaintStyle(PlaneStyle s, Point currentPos, bool valid)
		{
			int paintedBlocks = 0;
			Color c = valid ? Color.LightBlue : Color.Red;

			switch (s)
			{
				case PlaneStyle.NormalUp:
					{
						paintedBlocks += SetBlockColor(currentPos, c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X - 1, currentPos.Y), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X - 2, currentPos.Y), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X + 1, currentPos.Y), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X + 2, currentPos.Y), c);

						paintedBlocks += SetBlockColor(new Point(currentPos.X, currentPos.Y - 1), c);

						paintedBlocks += SetBlockColor(new Point(currentPos.X, currentPos.Y + 1), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X, currentPos.Y + 2), c);

						paintedBlocks += SetBlockColor(new Point(currentPos.X, currentPos.Y + 3), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X - 1, currentPos.Y + 3), c);
						paintedBlocks += SetBlockColor(new Point(currentPos.X + 1, currentPos.Y + 3), c);
						break;
					}
			}

			if (paintedBlocks < 11 && valid)
				PaintStyle(s, currentPos, false);

			return paintedBlocks == 11;
		}

		private int SetBlockColor(Point p, Color c)
		{
			if (p.X >= 0 && p.Y >= 0 && p.X < Consts.ROW_COUNT && p.Y < Consts.COLUMN_COUNT)
			{
				//blocks
				blocksMine[p.X + p.Y * Consts.ROW_COUNT].BackColor = c;
				blocksMine[p.X + p.Y * Consts.COLUMN_COUNT].State = BlockState.Selected;
				return 1;
			}
			return 0;
		}

		private int PointToIndex(Point p)
		{
			return p.Y * Consts.COLUMN_COUNT + p.X;
		}

		/// <summary>
		/// Creates and connects the hub connection and hub proxy. This method
		/// is called asynchronously from SignInButton_Click.
		/// </summary>
		private async void ConnectAsync()
		{
			Connection = new HubConnection(ServerURI);
			Connection.Closed += Connection_Closed;
			HubProxy = Connection.CreateHubProxy("MyHub");

			//register client events
			HubProxy.On<bool, string>("GameReady", GameReady);
			HubProxy.On<List<int>>("SyncEnemyMap", SyncEnemyMap);
			HubProxy.On<int>("NotifyTurnEnd", NotifyTurnEnd);

			//Handle incoming event from server: use Invoke to write to console from SignalR's thread
			//HubProxy.On<string, string>("AddMessage", (name, message) =>
			//	this.Invoke((Action)(() =>
			//		//RichTextBoxConsole.AppendText(String.Format("{0}: {1}" + Environment.NewLine, name, message))
			//	))
			//);
			try
			{
				await Connection.Start();
				pnlPlayerNameArea.Visible = false;
				pnlChooseTableArea.Visible = true;
			}
			catch (HttpRequestException)
			{
				//StatusText.Text = "Unable to connect to server: Start server before connecting clients.";
				//No connection: Don't enable Send button or show chat UI
				txtPlayerName.Enabled = true;
				SignInButton.Enabled = true;
				lblLoginResult.Text = "Login failed";
				return;
			}
		}

		private bool IfWin()
		{
			int myHP = 11;
			int enemyHP = 11;
			blocksMine.ForEach((b) => {
				if (b.State == BlockState.BrokenWithTarget)
					myHP--;
			});

			blocksEnemy.ForEach((b) =>
			{
				if (b.State == BlockState.BrokenWithTarget)
					enemyHP--;
			});

			if (myHP <= 0)
			{
				pnlBattleAreaEnemy.Enabled = false;
				lblGameover.Text = "YOU LOSE!";
				lblGameover.Visible = true;
				return false;
			}
			else if (enemyHP <= 0)
			{
				pnlBattleAreaEnemy.Enabled = false;
				lblGameover.Text = "YOU WIN!";
				lblGameover.Visible = true;
				return true;
			}
			return false;
		}

		#region Signalr methods invoked by server

		private void GameReady(bool offense, string enemyName)
		{
			this.Invoke((Action)(() =>
			{
				lblEnemyName.Text = enemyName;
				lblTurnText.Text = "Set your plane";
				lblMyName.Text = txtPlayerName.Text.Trim();
				ShowPanel(pnlBattleField);
			}));
		}

		private void SyncEnemyMap(List<int> map)
		{
			this.Invoke((Action)(() =>
			{
				for (int i = 0; i < map.Count; i++)
				{
					blocksEnemy[i].State = (BlockState)(map[i]);
				}
			}));
		}

		private void NotifyTurnEnd(int blockIndex)
		{
			this.Invoke((Action)(() =>
			{
				pnlBattleAreaEnemy.Enabled = true;
				pnlBattleAreaEnemy.Visible = true;

				//refresh self field state
				if (blockIndex > 0)
				{
					if (blocksMine[blockIndex].State == BlockState.Selected)
					{
						blocksMine[blockIndex].State = BlockState.BrokenWithTarget;
						blocksMine[blockIndex].BackColor = Color.IndianRed;
					}
					else
					{
						blocksMine[blockIndex].State = BlockState.BrokenWithoutTarget;
						blocksMine[blockIndex].BackColor = Color.Orange;
					}
				}

				lblTurnText.Text = "Your Turn";
			}));
		}

		#endregion

		private void ShowPanel(Panel p)
		{
			//hide all panels
			pnlBattleField.Visible = false;
			pnlSignin.Visible = false;
			pnlLoading.Visible = false;

			p.Dock = DockStyle.Fill;
			p.Visible = true;
		}
		#endregion

		#region Events
		/// <summary>
		/// If the server is stopped, the connection will time out after 30 seconds (default), and the 
		/// Closed event will fire.
		/// </summary>
		private void Connection_Closed()
		{
			//Deactivate chat UI; show login UI. 
			//this.Invoke((Action)(() => ChatPanel.Visible = false));
			//this.Invoke((Action)(() => ButtonSend.Enabled = false));
			//this.Invoke((Action)(() => StatusText.Text = "You have been disconnected."));
			//this.Invoke((Action)(() => SignInPanel.Visible = true));
		}

		private void SignInButton_Click(object sender, EventArgs e)
		{
			lblLoginResult.Text = "Login...";
			SignInButton.Enabled = false;
			txtPlayerName.Enabled = false;
			UserName = txtPlayerName.Text;
			//Connect to server (use async method to avoid blocking UI thread)
			if (!String.IsNullOrEmpty(UserName))
			{
				//StatusText.Visible = true;
				// StatusText.Text = "Connecting to server...";
				ConnectAsync();
			}
		}

		private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Connection != null)
			{
				Connection.Stop();
				Connection.Dispose();
			}
		}

		private void FrmMain_Shown(object sender, EventArgs e)
		{
			ShowPanel(pnlLoading);
			InitBlocks();
			ShowPanel(pnlSignin);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			btnGo.Enabled = false;
			tableId = Convert.ToInt32(numTableId.Value);
			HubProxy.Invoke("SignIn", txtPlayerName.Text, tableId);
		}

		private void txtPlayerName_TextChanged(object sender, EventArgs e)
		{
			SignInButton.Enabled = !String.IsNullOrEmpty(txtPlayerName.Text);
		}

		void item_ClickEnemy(object sender, EventArgs e)
		{
			Block currentBlock = (Block)sender;
			if (currentBlock.State == BlockState.Selected)
			{
				currentBlock.State = BlockState.BrokenWithTarget;
				currentBlock.BackColor = Color.IndianRed;
			}
			else
			{
				currentBlock.State = BlockState.BrokenWithoutTarget;
				currentBlock.BackColor = Color.Orange;
			}

			//judge win or lose?
			if (!IfWin())
			{
				HubProxy.Invoke("TurnEnd", PointToIndex(currentBlock.Pos), tableId);
				pnlBattleAreaEnemy.Enabled = false;
				lblTurnText.Text = "Enemy Turn";
			}
		}

		void item_Click(object sender, EventArgs e)
		{
			if (isValidSelection)
			{
				blocksMine.ForEach((b) =>
				{
					b.MouseEnter -= item_MouseEnterMine;
					b.Click -= item_Click;
				});

				//Sync my plane map to server, it is the safer strategy, for now just calculate in client side
				//so send map to each other
				List<int> map = new List<int>();
				blocksMine.ForEach((b) => { map.Add((int)b.State); });
				HubProxy.Invoke("SyncMap", map, tableId);
			}
		}

		void item_MouseEnterEnemy(object sender, EventArgs e)
		{
			((Block)sender).BorderStyle = BorderStyle.Fixed3D;
		}

		void newBlockE_MouseLeave(object sender, EventArgs e)
		{
			((Block)sender).BorderStyle = BorderStyle.FixedSingle;
		}

		void item_MouseEnterMine(object sender, EventArgs e)
		{
			//clear
			blocksMine.ForEach((b) =>
			{
				b.BackColor = Color.FromKnownColor(KnownColor.Control);
				b.State = BlockState.Raw;
			});

			//set color
			//get current index
			Point currentPos = ((Block)sender).Pos;

			isValidSelection = PaintStyle(PlaneStyle.NormalUp, currentPos, true);

		}
		#endregion
	}
}
