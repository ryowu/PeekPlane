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
			this.pnlSignin = new System.Windows.Forms.Panel();
			this.pnlChooseTableArea = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.numTableId = new System.Windows.Forms.NumericUpDown();
			this.btnGo = new System.Windows.Forms.Button();
			this.pnlPlayerNameArea = new System.Windows.Forms.Panel();
			this.lblLoginResult = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.SignInButton = new System.Windows.Forms.Button();
			this.pnlAreaMine = new System.Windows.Forms.Panel();
			this.pnlBattleAreaEnemy = new System.Windows.Forms.Panel();
			this.pnlBattleField = new System.Windows.Forms.Panel();
			this.lblGameover = new System.Windows.Forms.Label();
			this.lblEnemyName = new System.Windows.Forms.Label();
			this.lblMyName = new System.Windows.Forms.Label();
			this.lblTurnText = new System.Windows.Forms.Label();
			this.pnlLoading = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblProgressbar = new System.Windows.Forms.Label();
			this.pnlSignin.SuspendLayout();
			this.pnlChooseTableArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTableId)).BeginInit();
			this.pnlPlayerNameArea.SuspendLayout();
			this.pnlBattleField.SuspendLayout();
			this.pnlLoading.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSignin
			// 
			this.pnlSignin.Controls.Add(this.pnlChooseTableArea);
			this.pnlSignin.Controls.Add(this.pnlPlayerNameArea);
			this.pnlSignin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSignin.Location = new System.Drawing.Point(0, 0);
			this.pnlSignin.Margin = new System.Windows.Forms.Padding(4);
			this.pnlSignin.Name = "pnlSignin";
			this.pnlSignin.Size = new System.Drawing.Size(944, 555);
			this.pnlSignin.TabIndex = 4;
			// 
			// pnlChooseTableArea
			// 
			this.pnlChooseTableArea.Controls.Add(this.label2);
			this.pnlChooseTableArea.Controls.Add(this.numTableId);
			this.pnlChooseTableArea.Controls.Add(this.btnGo);
			this.pnlChooseTableArea.Location = new System.Drawing.Point(298, 345);
			this.pnlChooseTableArea.Name = "pnlChooseTableArea";
			this.pnlChooseTableArea.Size = new System.Drawing.Size(318, 129);
			this.pnlChooseTableArea.TabIndex = 10;
			this.pnlChooseTableArea.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Table:";
			// 
			// numTableId
			// 
			this.numTableId.Location = new System.Drawing.Point(100, 18);
			this.numTableId.Name = "numTableId";
			this.numTableId.Size = new System.Drawing.Size(200, 25);
			this.numTableId.TabIndex = 7;
			this.numTableId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(101, 52);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(199, 34);
			this.btnGo.TabIndex = 8;
			this.btnGo.Text = "GO";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// pnlPlayerNameArea
			// 
			this.pnlPlayerNameArea.Controls.Add(this.lblLoginResult);
			this.pnlPlayerNameArea.Controls.Add(this.lblName);
			this.pnlPlayerNameArea.Controls.Add(this.txtPlayerName);
			this.pnlPlayerNameArea.Controls.Add(this.SignInButton);
			this.pnlPlayerNameArea.Location = new System.Drawing.Point(298, 205);
			this.pnlPlayerNameArea.Name = "pnlPlayerNameArea";
			this.pnlPlayerNameArea.Size = new System.Drawing.Size(318, 125);
			this.pnlPlayerNameArea.TabIndex = 9;
			// 
			// lblLoginResult
			// 
			this.lblLoginResult.AutoSize = true;
			this.lblLoginResult.Location = new System.Drawing.Point(99, 92);
			this.lblLoginResult.Name = "lblLoginResult";
			this.lblLoginResult.Size = new System.Drawing.Size(29, 19);
			this.lblLoginResult.TabIndex = 6;
			this.lblLoginResult.Text = "     ";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(7, 21);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(87, 19);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Player name:";
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.Location = new System.Drawing.Point(102, 18);
			this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.Size = new System.Drawing.Size(200, 25);
			this.txtPlayerName.TabIndex = 4;
			this.txtPlayerName.Text = "CrazyPants";
			this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
			// 
			// SignInButton
			// 
			this.SignInButton.Location = new System.Drawing.Point(103, 51);
			this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(200, 34);
			this.SignInButton.TabIndex = 5;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.UseVisualStyleBackColor = true;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			// 
			// pnlAreaMine
			// 
			this.pnlAreaMine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlAreaMine.Location = new System.Drawing.Point(10, 42);
			this.pnlAreaMine.Margin = new System.Windows.Forms.Padding(4);
			this.pnlAreaMine.Name = "pnlAreaMine";
			this.pnlAreaMine.Size = new System.Drawing.Size(450, 450);
			this.pnlAreaMine.TabIndex = 70;
			// 
			// pnlBattleAreaEnemy
			// 
			this.pnlBattleAreaEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlBattleAreaEnemy.Enabled = false;
			this.pnlBattleAreaEnemy.Location = new System.Drawing.Point(471, 42);
			this.pnlBattleAreaEnemy.Margin = new System.Windows.Forms.Padding(4);
			this.pnlBattleAreaEnemy.Name = "pnlBattleAreaEnemy";
			this.pnlBattleAreaEnemy.Size = new System.Drawing.Size(450, 450);
			this.pnlBattleAreaEnemy.TabIndex = 71;
			this.pnlBattleAreaEnemy.Visible = false;
			// 
			// pnlBattleField
			// 
			this.pnlBattleField.BackColor = System.Drawing.SystemColors.Control;
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
			this.pnlBattleField.Size = new System.Drawing.Size(944, 555);
			this.pnlBattleField.TabIndex = 72;
			// 
			// lblGameover
			// 
			this.lblGameover.AutoSize = true;
			this.lblGameover.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGameover.Location = new System.Drawing.Point(388, 215);
			this.lblGameover.Name = "lblGameover";
			this.lblGameover.Size = new System.Drawing.Size(154, 36);
			this.lblGameover.TabIndex = 74;
			this.lblGameover.Text = "YOU WIN!";
			this.lblGameover.Visible = false;
			// 
			// lblEnemyName
			// 
			this.lblEnemyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEnemyName.AutoSize = true;
			this.lblEnemyName.Location = new System.Drawing.Point(836, 12);
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
			this.lblTurnText.Location = new System.Drawing.Point(347, 507);
			this.lblTurnText.Name = "lblTurnText";
			this.lblTurnText.Size = new System.Drawing.Size(230, 26);
			this.lblTurnText.TabIndex = 72;
			this.lblTurnText.Text = "Set your plane";
			this.lblTurnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlLoading
			// 
			this.pnlLoading.Controls.Add(this.label1);
			this.pnlLoading.Controls.Add(this.lblProgressbar);
			this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLoading.Location = new System.Drawing.Point(0, 0);
			this.pnlLoading.Margin = new System.Windows.Forms.Padding(4);
			this.pnlLoading.Name = "pnlLoading";
			this.pnlLoading.Size = new System.Drawing.Size(944, 555);
			this.pnlLoading.TabIndex = 73;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(293, 290);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblProgressbar
			// 
			this.lblProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgressbar.BackColor = System.Drawing.Color.SteelBlue;
			this.lblProgressbar.Location = new System.Drawing.Point(293, 262);
			this.lblProgressbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProgressbar.Name = "lblProgressbar";
			this.lblProgressbar.Size = new System.Drawing.Size(359, 19);
			this.lblProgressbar.TabIndex = 2;
			this.lblProgressbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmMain
			// 
			this.AcceptButton = this.SignInButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 555);
			this.Controls.Add(this.pnlBattleField);
			this.Controls.Add(this.pnlLoading);
			this.Controls.Add(this.pnlSignin);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "FrmMain";
			this.Text = "Battle Field";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
			this.Shown += new System.EventHandler(this.FrmMain_Shown);
			this.pnlSignin.ResumeLayout(false);
			this.pnlChooseTableArea.ResumeLayout(false);
			this.pnlChooseTableArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTableId)).EndInit();
			this.pnlPlayerNameArea.ResumeLayout(false);
			this.pnlPlayerNameArea.PerformLayout();
			this.pnlBattleField.ResumeLayout(false);
			this.pnlBattleField.PerformLayout();
			this.pnlLoading.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel pnlSignin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button SignInButton;
		private System.Windows.Forms.TextBox txtPlayerName;
		private System.Windows.Forms.Panel pnlAreaMine;
		private System.Windows.Forms.Panel pnlBattleAreaEnemy;
		private System.Windows.Forms.Panel pnlBattleField;
		private System.Windows.Forms.Panel pnlLoading;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numTableId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblProgressbar;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Panel pnlPlayerNameArea;
		private System.Windows.Forms.Panel pnlChooseTableArea;
		private System.Windows.Forms.Label lblLoginResult;
		private System.Windows.Forms.Label lblTurnText;
		private System.Windows.Forms.Label lblEnemyName;
		private System.Windows.Forms.Label lblMyName;
		private System.Windows.Forms.Label lblGameover;

    }
}

