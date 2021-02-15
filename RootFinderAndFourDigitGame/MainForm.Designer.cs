namespace R09725060HSHuangAss04
{
    partial class MainForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pageRootFinder = new System.Windows.Forms.TabPage();
            this.labeXRoot_Root = new System.Windows.Forms.Label();
            this.labEqualZero = new System.Windows.Forms.Label();
            this.labPlusForConstant = new System.Windows.Forms.Label();
            this.labPlusForX = new System.Windows.Forms.Label();
            this.labX = new System.Windows.Forms.Label();
            this.labXRoot = new System.Windows.Forms.Label();
            this.btnFindRoots = new System.Windows.Forms.Button();
            this.txbc = new System.Windows.Forms.TextBox();
            this.txbb = new System.Windows.Forms.TextBox();
            this.txba = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.page4DigitGame = new System.Windows.Forms.TabPage();
            this.labAnswer = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txbGuess = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.labYourGuess = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.pageRootFinder.SuspendLayout();
            this.page4DigitGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.pageRootFinder);
            this.tabMain.Controls.Add(this.page4DigitGame);
            this.tabMain.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabMain.Location = new System.Drawing.Point(24, 57);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(503, 412);
            this.tabMain.TabIndex = 0;
            // 
            // pageRootFinder
            // 
            this.pageRootFinder.Controls.Add(this.labeXRoot_Root);
            this.pageRootFinder.Controls.Add(this.labEqualZero);
            this.pageRootFinder.Controls.Add(this.labPlusForConstant);
            this.pageRootFinder.Controls.Add(this.labPlusForX);
            this.pageRootFinder.Controls.Add(this.labX);
            this.pageRootFinder.Controls.Add(this.labXRoot);
            this.pageRootFinder.Controls.Add(this.btnFindRoots);
            this.pageRootFinder.Controls.Add(this.txbc);
            this.pageRootFinder.Controls.Add(this.txbb);
            this.pageRootFinder.Controls.Add(this.txba);
            this.pageRootFinder.Controls.Add(this.rtbDisplay);
            this.pageRootFinder.Location = new System.Drawing.Point(4, 25);
            this.pageRootFinder.Name = "pageRootFinder";
            this.pageRootFinder.Padding = new System.Windows.Forms.Padding(3);
            this.pageRootFinder.Size = new System.Drawing.Size(495, 383);
            this.pageRootFinder.TabIndex = 0;
            this.pageRootFinder.Text = "RootFinder";
            this.pageRootFinder.UseVisualStyleBackColor = true;
            // 
            // labeXRoot_Root
            // 
            this.labeXRoot_Root.AutoSize = true;
            this.labeXRoot_Root.BackColor = System.Drawing.Color.Transparent;
            this.labeXRoot_Root.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeXRoot_Root.Location = new System.Drawing.Point(98, 48);
            this.labeXRoot_Root.Name = "labeXRoot_Root";
            this.labeXRoot_Root.Size = new System.Drawing.Size(16, 17);
            this.labeXRoot_Root.TabIndex = 10;
            this.labeXRoot_Root.Text = "2";
            // 
            // labEqualZero
            // 
            this.labEqualZero.AutoSize = true;
            this.labEqualZero.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEqualZero.Location = new System.Drawing.Point(284, 61);
            this.labEqualZero.Name = "labEqualZero";
            this.labEqualZero.Size = new System.Drawing.Size(32, 21);
            this.labEqualZero.TabIndex = 9;
            this.labEqualZero.Text = "=0";
            // 
            // labPlusForConstant
            // 
            this.labPlusForConstant.AutoSize = true;
            this.labPlusForConstant.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPlusForConstant.Location = new System.Drawing.Point(205, 61);
            this.labPlusForConstant.Name = "labPlusForConstant";
            this.labPlusForConstant.Size = new System.Drawing.Size(22, 21);
            this.labPlusForConstant.TabIndex = 8;
            this.labPlusForConstant.Text = "+";
            // 
            // labPlusForX
            // 
            this.labPlusForX.AutoSize = true;
            this.labPlusForX.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPlusForX.Location = new System.Drawing.Point(109, 61);
            this.labPlusForX.Name = "labPlusForX";
            this.labPlusForX.Size = new System.Drawing.Size(22, 21);
            this.labPlusForX.TabIndex = 7;
            this.labPlusForX.Text = "+";
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labX.Location = new System.Drawing.Point(187, 61);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(21, 21);
            this.labX.TabIndex = 6;
            this.labX.Text = "X";
            // 
            // labXRoot
            // 
            this.labXRoot.AutoSize = true;
            this.labXRoot.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labXRoot.Location = new System.Drawing.Point(81, 61);
            this.labXRoot.Name = "labXRoot";
            this.labXRoot.Size = new System.Drawing.Size(21, 21);
            this.labXRoot.TabIndex = 5;
            this.labXRoot.Text = "X";
            // 
            // btnFindRoots
            // 
            this.btnFindRoots.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFindRoots.Location = new System.Drawing.Point(346, 50);
            this.btnFindRoots.Name = "btnFindRoots";
            this.btnFindRoots.Size = new System.Drawing.Size(115, 36);
            this.btnFindRoots.TabIndex = 4;
            this.btnFindRoots.Text = "Find Roots";
            this.btnFindRoots.UseVisualStyleBackColor = true;
            this.btnFindRoots.Click += new System.EventHandler(this.btnFindRoots_Click);
            // 
            // txbc
            // 
            this.txbc.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbc.Location = new System.Drawing.Point(231, 57);
            this.txbc.Name = "txbc";
            this.txbc.Size = new System.Drawing.Size(47, 29);
            this.txbc.TabIndex = 3;
            this.txbc.Text = "3";
            // 
            // txbb
            // 
            this.txbb.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbb.Location = new System.Drawing.Point(136, 57);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(47, 29);
            this.txbb.TabIndex = 2;
            this.txbb.Text = "4";
            // 
            // txba
            // 
            this.txba.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txba.Location = new System.Drawing.Point(28, 57);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(47, 29);
            this.txba.TabIndex = 1;
            this.txba.Text = "2";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbDisplay.Location = new System.Drawing.Point(28, 104);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(433, 223);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // page4DigitGame
            // 
            this.page4DigitGame.Controls.Add(this.labYourGuess);
            this.page4DigitGame.Controls.Add(this.labAnswer);
            this.page4DigitGame.Controls.Add(this.BtnReset);
            this.page4DigitGame.Controls.Add(this.txbGuess);
            this.page4DigitGame.Controls.Add(this.rtbLog);
            this.page4DigitGame.Location = new System.Drawing.Point(4, 25);
            this.page4DigitGame.Name = "page4DigitGame";
            this.page4DigitGame.Padding = new System.Windows.Forms.Padding(3);
            this.page4DigitGame.Size = new System.Drawing.Size(495, 383);
            this.page4DigitGame.TabIndex = 1;
            this.page4DigitGame.Text = "4 Digit Game";
            this.page4DigitGame.UseVisualStyleBackColor = true;
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Location = new System.Drawing.Point(389, 129);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(72, 16);
            this.labAnswer.TabIndex = 3;
            this.labAnswer.Text = "No Game~";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(20, 34);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 77);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "NEW GAME";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txbGuess
            // 
            this.txbGuess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txbGuess.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGuess.Location = new System.Drawing.Point(146, 67);
            this.txbGuess.Name = "txbGuess";
            this.txbGuess.Size = new System.Drawing.Size(112, 44);
            this.txbGuess.TabIndex = 1;
            this.txbGuess.Text = "0000";
            this.txbGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbGuess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbGuess_KeyUp);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbLog.Location = new System.Drawing.Point(20, 148);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(441, 209);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // labYourGuess
            // 
            this.labYourGuess.AutoSize = true;
            this.labYourGuess.Location = new System.Drawing.Point(143, 48);
            this.labYourGuess.Name = "labYourGuess";
            this.labYourGuess.Size = new System.Drawing.Size(152, 16);
            this.labYourGuess.TabIndex = 4;
            this.labYourGuess.Text = "Please Input Your Guess";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(548, 499);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = "2020 Interesting Game";
            this.tabMain.ResumeLayout(false);
            this.pageRootFinder.ResumeLayout(false);
            this.pageRootFinder.PerformLayout();
            this.page4DigitGame.ResumeLayout(false);
            this.page4DigitGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pageRootFinder;
        private System.Windows.Forms.TabPage page4DigitGame;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnFindRoots;
        private System.Windows.Forms.TextBox txbc;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox txbGuess;
        private System.Windows.Forms.Label labeXRoot_Root;
        private System.Windows.Forms.Label labEqualZero;
        private System.Windows.Forms.Label labPlusForConstant;
        private System.Windows.Forms.Label labPlusForX;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labXRoot;
        private System.Windows.Forms.Label labYourGuess;
    }
}

