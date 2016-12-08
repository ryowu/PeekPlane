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
		const string ServerURI = "http://WCNRW186023-5EH:8080/signalr";
		private HubConnection Connection { get; set; }

		private bool isValidSelection = false;

		private int tableId = -1;
		private List<Block> blocksMine = new List<Block>();
		private List<Block> blocksEnemy = new List<Block>();
		private List<int> map = new List<int>();
		private int plane_count = 0;
		private PlaneStyle currentPaintStyle = PlaneStyle.Up;
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
					newBlock.MouseUp += newBlock_MouseUp;
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
					picPlaneProgress.Left = lblProgressbar.Right;
					Application.DoEvents();
					if (blockIndex >= Consts.BLOCK_COUNT) break;
				}
			}
		}

		private bool PaintStyle(PlaneStyle s, Point currentPos, bool valid)
		{
			int paintedBlocks = 0;
			Color c = valid ? Consts.COLOR_VALID_SELECTION : Consts.COLOR_INVALID_SELECTION;
			List<Point> styleDesign = PaintStyles.GetStyle(s);
			styleDesign.ForEach((style) =>
			{
				paintedBlocks += SetBlockColor(new Point(currentPos.X + style.X, currentPos.Y + style.Y), c);
			});

			if (paintedBlocks < 11 && valid)
				PaintStyle(s, currentPos, false);

			return paintedBlocks == 11;
		}

		private int SetBlockColor(Point p, Color c)
		{
			if (p.X >= 0 && p.Y >= 0 && p.X < Consts.ROW_COUNT && p.Y < Consts.COLUMN_COUNT)
			{
				//blocks
				int index = PointToIndex(p);
				if (blocksMine[index].State != BlockState.Selected)
				{
					blocksMine[index].BackColor = c;
					blocksMine[index].State = BlockState.Preview;
					return 1;
				}
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

		private void RestoreUnselectedBlocks()
		{
			////clear
			blocksMine.ForEach((b) =>
			{
				if (b.State != BlockState.Selected)
				{
					b.BackColor = Color.FromKnownColor(KnownColor.White);
					b.State = BlockState.Raw;
				}
			});
		}

		private bool IfWin()
		{
			int myHP = 11 * Consts.PLANE_COUNT;
			int enemyHP = 11 * Consts.PLANE_COUNT;
			blocksMine.ForEach((b) =>
			{
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
				btnAgain.Visible = true;
				btnGotoHall.Visible = true;
				return false;
			}
			else if (enemyHP <= 0)
			{
				pnlBattleAreaEnemy.Enabled = false;
				lblGameover.Text = "YOU WIN!";
				lblGameover.Visible = true;
				btnAgain.Visible = true;
				btnGotoHall.Visible = true;
				return true;
			}
			return false;
		}

		private void ShowPanel(Panel p)
		{
			//hide all panels
			pnlBattleField.Visible = false;
			pnlSignin.Visible = false;
			pnlLoading.Visible = false;

			p.Dock = DockStyle.Fill;
			p.Visible = true;
		}

		#region Signalr methods invoked by server

		private void GameReady(bool offense, string enemyName)
		{
			this.Invoke((Action)(() =>
			{
				lblEnemyName.Text = enemyName;
				lblTurnText.Text = "Set your plane";
				lblMyName.Text = txtPlayerName.Text.Trim();
				plane_count = Consts.PLANE_COUNT;
				btnAgain.Visible = false;
				btnGotoHall.Visible = false;
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

				IfWin();

				lblTurnText.Text = "Your Turn";
			}));
		}

		#endregion

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
			Thread.Sleep(500);
			ShowPanel(pnlSignin);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			btnGo.Enabled = false;
			numTableId.Enabled = false;
			btnGo.Text = "Waiting for another player";
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

			HubProxy.Invoke("TurnEnd", PointToIndex(currentBlock.Pos), tableId);

			//judge win or lose?
			if (!IfWin())
			{
				pnlBattleAreaEnemy.Enabled = false;
				lblTurnText.Text = "Enemy Turn";
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
			RestoreUnselectedBlocks();
			Point currentPos = ((Block)sender).Pos;
			isValidSelection = PaintStyle(currentPaintStyle, currentPos, true);
		}

		void newBlock_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				//refresh all blocks
				RestoreUnselectedBlocks();
				//change style to next style
				int currentStyleNumber = (int)currentPaintStyle;
				currentStyleNumber++;
				if (currentStyleNumber > 4)
					currentStyleNumber = 1;
				currentPaintStyle = (PlaneStyle)currentStyleNumber;
				//repaint current block
				item_MouseEnterMine(sender, e);
			}
			else if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				if (isValidSelection)
				{
					plane_count--;
					blocksMine.ForEach((b) =>
					{
						if (b.State == BlockState.Preview)
						{
							b.State = BlockState.Selected;
							b.MouseEnter -= item_MouseEnterMine;
							b.MouseUp -= newBlock_MouseUp;
						}
					});


					if (plane_count == 0)
					{
						blocksMine.ForEach((b) =>
						{
							b.MouseEnter -= item_MouseEnterMine;
							b.MouseUp -= newBlock_MouseUp;
						});

						map.Clear();
						blocksMine.ForEach((b) => { map.Add((int)b.State); });
						HubProxy.Invoke("SyncMap", map, tableId);
					}
				}
			}
		}

		private void btnAgain_Click(object sender, EventArgs e)
		{
			btnAgain.Visible = false;
			btnGotoHall.Visible = false;
			lblGameover.Visible = false;
			lblTurnText.Text = "Set your plane";
			plane_count = Consts.PLANE_COUNT;

			blocksMine.ForEach((b) =>
			{
				b.State = BlockState.Raw;
				b.MouseEnter += item_MouseEnterMine;
				b.MouseUp += newBlock_MouseUp;
			});

			RestoreUnselectedBlocks();

			blocksEnemy.ForEach((b) =>
			{
				b.State = BlockState.Raw;
				b.BackColor = Color.White;
			});

			pnlBattleAreaEnemy.Enabled = false;
		}
		#endregion
	}
}
