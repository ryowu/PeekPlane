namespace WinFormsClient
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.pnlSignin = new System.Windows.Forms.Panel();
			this.pnlChooseTableArea = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.numTableId = new System.Windows.Forms.NumericUpDown();
			this.btnGo = new System.Windows.Forms.Button();
			this.pnlPlayerNameArea = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblLoginResult = new System.Windows.Forms.Label();
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.SignInButton = new System.Windows.Forms.Button();
			this.pnlBattleField = new System.Windows.Forms.Panel();
			this.btnAgain = new System.Windows.Forms.Button();
			this.lblGameover = new System.Windows.Forms.Label();
			this.lblEnemyName = new System.Windows.Forms.Label();
			this.lblMyName = new System.Windows.Forms.Label();
			this.lblTurnText = new System.Windows.Forms.Label();
			this.pnlAreaMine = new System.Windows.Forms.Panel();
			this.pnlBattleAreaEnemy = new System.Windows.Forms.Panel();
			this.pnlLoading = new System.Windows.Forms.Panel();
			this.picPlaneProgress = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblProgressbar = new System.Windows.Forms.Label();
			this.pnlSignin.SuspendLayout();
			this.pnlChooseTableArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTableId)).BeginInit();
			this.pnlPlayerNameArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlBattleField.SuspendLayout();
			this.pnlLoading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPlaneProgress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlSignin
			// 
			this.pnlSignin.BackColor = System.Drawing.Color.White;
			this.pnlSignin.Controls.Add(this.pnlChooseTableArea);
			this.pnlSignin.Controls.Add(this.pnlPlayerNameArea);
			this.pnlSignin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSignin.Location = new System.Drawing.Point(0, 0);
			this.pnlSignin.Margin = new System.Windows.Forms.Padding(4);
			this.pnlSignin.Name = "pnlSignin";
			this.pnlSignin.Size = new System.Drawing.Size(919, 545);
			this.pnlSignin.TabIndex = 4;
			// 
			// pnlChooseTableArea
			// 
			this.pnlChooseTableArea.BackColor = System.Drawing.Color.Cornsilk;
			this.pnlChooseTableArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlChooseTableArea.Controls.Add(this.pictureBox3);
			this.pnlChooseTableArea.Controls.Add(this.numTableId);
			this.pnlChooseTableArea.Controls.Add(this.btnGo);
			this.pnlChooseTableArea.Location = new System.Drawing.Point(161, 345);
			this.pnlChooseTableArea.Name = "pnlChooseTableArea";
			this.pnlChooseTableArea.Size = new System.Drawing.Size(618, 129);
			this.pnlChooseTableArea.TabIndex = 10;
			this.pnlChooseTableArea.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::PeekPlane.Properties.Resources.table;
			this.pictureBox3.Location = new System.Drawing.Point(166, 19);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(134, 61);
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// numTableId
			// 
			this.numTableId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numTableId.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numTableId.Location = new System.Drawing.Point(307, 28);
			this.numTableId.Name = "numTableId";
			this.numTableId.Size = new System.Drawing.Size(200, 43);
			this.numTableId.TabIndex = 7;
			this.numTableId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnGo
			// 
			this.btnGo.BackColor = System.Drawing.Color.White;
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Location = new System.Drawing.Point(306, 77);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(199, 34);
			this.btnGo.TabIndex = 8;
			this.btnGo.Text = "GO";
			this.btnGo.UseVisualStyleBackColor = false;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// pnlPlayerNameArea
			// 
			this.pnlPlayerNameArea.BackColor = System.Drawing.Color.Cornsilk;
			this.pnlPlayerNameArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPlayerNameArea.Controls.Add(this.pictureBox2);
			this.pnlPlayerNameArea.Controls.Add(this.lblLoginResult);
			this.pnlPlayerNameArea.Controls.Add(this.txtPlayerName);
			this.pnlPlayerNameArea.Controls.Add(this.SignInButton);
			this.pnlPlayerNameArea.Location = new System.Drawing.Point(161, 205);
			this.pnlPlayerNameArea.Name = "pnlPlayerNameArea";
			this.pnlPlayerNameArea.Size = new System.Drawing.Size(618, 125);
			this.pnlPlayerNameArea.TabIndex = 9;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::PeekPlane.Properties.Resources.playername;
			this.pictureBox2.Location = new System.Drawing.Point(33, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(267, 61);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// lblLoginResult
			// 
			this.lblLoginResult.AutoSize = true;
			this.lblLoginResult.Location = new System.Drawing.Point(162, 92);
			this.lblLoginResult.Name = "lblLoginResult";
			this.lblLoginResult.Size = new System.Drawing.Size(29, 19);
			this.lblLoginResult.TabIndex = 6;
			this.lblLoginResult.Text = "     ";
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPlayerName.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlayerName.Location = new System.Drawing.Point(307, 33);
			this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
			this.txtPlayerName.MaxLength = 15;
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.Size = new System.Drawing.Size(200, 43);
			this.txtPlayerName.TabIndex = 4;
			this.txtPlayerName.Text = "CrazyPants";
			this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
			// 
			// SignInButton
			// 
			this.SignInButton.BackColor = System.Drawing.Color.White;
			this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignInButton.Location = new System.Drawing.Point(307, 80);
			this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(200, 34);
			this.SignInButton.TabIndex = 5;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.UseVisualStyleBackColor = false;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			// 
			// pnlBattleField
			// 
			this.pnlBattleField.BackColor = System.Drawing.Color.White;
			this.pnlBattleField.Controls.Add(this.btnAgain);
			this.pnlBattleField.Controls.Add(this.lblGameover);
			this.pnlBattleField.Controls.Add(this.lblEnemyName);
			this.pnlBattleField.Controls.Add(this.lblMyName);
			this.pnlBattleField.Controls.Add(this.lblTurnText);
			this.pnlBattleField.Controls.Add(this.pnlAreaMine);
			this.pnlBattleField.Controls.Add(this.pnlBattleAreaEnemy);
			this.pnlBattleField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBattleField.Location = new System.Drawing.Point(0, 0);
			this.pnlBattleField.Margin = new System.Windows.Forms.Padding(4);
			this.pnlBattleField.Name = "pnlBattleField";
			this.pnlBattleField.Size = new System.Drawing.Size(919, 545);
			this.pnlBattleField.TabIndex = 72;
			// 
			// btnAgain
			// 
			this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgain.Location = new System.Drawing.Point(619, 489);
			this.btnAgain.Name = "btnAgain";
			this.btnAgain.Size = new System.Drawing.Size(99, 44);
			this.btnAgain.TabIndex = 75;
			this.btnAgain.Text = "AGAIN";
			this.btnAgain.UseVisualStyleBackColor = true;
			this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
			// 
			// lblGameover
			// 
			this.lblGameover.AutoSize = true;
			this.lblGameover.BackColor = System.Drawing.Color.Cornsilk;
			this.lblGameover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblGameover.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGameover.Location = new System.Drawing.Point(388, 215);
			this.lblGameover.Name = "lblGameover";
			this.lblGameover.Size = new System.Drawing.Size(156, 38);
			this.lblGameover.TabIndex = 74;
			this.lblGameover.Text = "YOU WIN!";
			this.lblGameover.Visible = false;
			// 
			// lblEnemyName
			// 
			this.lblEnemyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEnemyName.AutoSize = true;
			this.lblEnemyName.Location = new System.Drawing.Point(811, 12);
			this.lblEnemyName.Name = "lblEnemyName";
			this.lblEnemyName.Size = new System.Drawing.Size(85, 19);
			this.lblEnemyName.TabIndex = 73;
			this.lblEnemyName.Text = "Wait for join";
			this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMyName
			// 
			this.lblMyName.AutoSize = true;
			this.lblMyName.Location = new System.Drawing.Point(12, 12);
			this.lblMyName.Name = "lblMyName";
			this.lblMyName.Size = new System.Drawing.Size(68, 19);
			this.lblMyName.TabIndex = 73;
			this.lblMyName.Text = "Your turn";
			this.lblMyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTurnText
			// 
			this.lblTurnText.Location = new System.Drawing.Point(288, 497);
			this.lblTurnText.Name = "lblTurnText";
			this.lblTurnText.Size = new System.Drawing.Size(339, 26);
			this.lblTurnText.TabIndex = 72;
			this.lblTurnText.Text = "Set your plane, right click change direction";
			this.lblTurnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlAreaMine
			// 
			this.pnlAreaMine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlAreaMine.Location = new System.Drawing.Point(10, 42);
			this.pnlAreaMine.Margin = new System.Windows.Forms.Padding(4);
			this.pnlAreaMine.Name = "pnlAreaMine";
			this.pnlAreaMine.Size = new System.Drawing.Size(440, 440);
			this.pnlAreaMine.TabIndex = 70;
			// 
			// pnlBattleAreaEnemy
			// 
			this.pnlBattleAreaEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlBattleAreaEnemy.Enabled = false;
			this.pnlBattleAreaEnemy.Location = new System.Drawing.Point(471, 42);
			this.pnlBattleAreaEnemy.Margin = new System.Windows.Forms.Padding(4);
			this.pnlBattleAreaEnemy.Name = "pnlBattleAreaEnemy";
			this.pnlBattleAreaEnemy.Size = new System.Drawing.Size(440, 440);
			this.pnlBattleAreaEnemy.TabIndex = 71;
			this.pnlBattleAreaEnemy.Visible = false;
			// 
			// pnlLoading
			// 
			this.pnlLoading.BackColor = System.Drawing.Color.White;
			this.pnlLoading.Controls.Add(this.picPlaneProgress);
			this.pnlLoading.Controls.Add(this.pictureBox1);
			this.pnlLoading.Controls.Add(this.label1);
			this.pnlLoading.Controls.Add(this.lblProgressbar);
			this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLoading.Location = new System.Drawing.Point(0, 0);
			this.pnlLoading.Margin = new System.Windows.Forms.Padding(4);
			this.pnlLoading.Name = "pnlLoading";
			this.pnlLoading.Size = new System.Drawing.Size(919, 545);
			this.pnlLoading.TabIndex = 73;
			// 
			// picPlaneProgress
			// 
			this.picPlaneProgress.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneProgress.Image")));
			this.picPlaneProgress.Location = new System.Drawing.Point(603, 240);
			this.picPlaneProgress.Name = "picPlaneProgress";
			this.picPlaneProgress.Size = new System.Drawing.Size(50, 50);
			this.picPlaneProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picPlaneProgress.TabIndex = 4;
			this.picPlaneProgress.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PeekPlane.Properties.Resources.title;
			this.pictureBox1.Location = new System.Drawing.Point(259, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(420, 111);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(293, 285);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(334, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblProgressbar
			// 
			this.lblProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgressbar.BackColor = System.Drawing.Color.SteelBlue;
			this.lblProgressbar.Location = new System.Drawing.Point(293, 257);
			this.lblProgressbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProgressbar.Name = "lblProgressbar";
			this.lblProgressbar.Size = new System.Drawing.Size(334, 19);
			this.lblProgressbar.TabIndex = 2;
			this.lblProgressbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmMain
			// 
			this.AcceptButton = this.SignInButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 545);
			this.Controls.Add(this.pnlBattleField);
			this.Controls.Add(this.pnlLoading);
			this.Controls.Add(this.pnlSignin);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "FrmMain";
			this.Text = "Peek Plane";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
			this.Shown += new System.EventHandler(this.FrmMain_Shown);
			this.pnlSignin.ResumeLayout(false);
			this.pnlChooseTableArea.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTableId)).EndInit();
			this.pnlPlayerNameArea.ResumeLayout(false);
			this.pnlPlayerNameArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlBattleField.ResumeLayout(false);
			this.pnlBattleField.PerformLayout();
			this.pnlLoading.ResumeLayout(false);
			this.pnlLoading.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPlaneProgress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel pnlSignin;
        private System.Windows.Forms.Button SignInButton;
		private System.Windows.Forms.TextBox txtPlayerName;
		private System.Windows.Forms.Panel pnlAreaMine;
		private System.Windows.Forms.Panel pnlBattleAreaEnemy;
		private System.Windows.Forms.Panel pnlBattleField;
		private System.Windows.Forms.Panel pnlLoading;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numTableId;
		private System.Windows.Forms.Label lblProgressbar;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Panel pnlPlayerNameArea;
		private System.Windows.Forms.Panel pnlChooseTableArea;
		private System.Windows.Forms.Label lblLoginResult;
		private System.Windows.Forms.Label lblTurnText;
		private System.Windows.Forms.Label lblEnemyName;
		private System.Windows.Forms.Label lblMyName;
		private System.Windows.Forms.Label lblGameover;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox picPlaneProgress;
		private System.Windows.Forms.Button btnAgain;

    }
}

