namespace RockPaperScissorGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labScores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.pcbScissors = new System.Windows.Forms.PictureBox();
            this.pcbPaper = new System.Windows.Forms.PictureBox();
            this.pcbRock = new System.Windows.Forms.PictureBox();
            this.labcomputerhand = new System.Windows.Forms.Label();
            this.labplayerhand = new System.Windows.Forms.Label();
            this.pcbComputer = new System.Windows.Forms.PictureBox();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labScores
            // 
            this.labScores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.labScores.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labScores.Location = new System.Drawing.Point(0, 0);
            this.labScores.Name = "labScores";
            this.labScores.Size = new System.Drawing.Size(800, 71);
            this.labScores.TabIndex = 0;
            this.labScores.Text = "label1";
            this.labScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEvaluate);
            this.panel1.Controls.Add(this.pcbScissors);
            this.panel1.Controls.Add(this.pcbPaper);
            this.panel1.Controls.Add(this.pcbRock);
            this.panel1.Location = new System.Drawing.Point(458, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 321);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click To Change Hand";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEvaluate.Location = new System.Drawing.Point(88, 236);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(122, 49);
            this.btnEvaluate.TabIndex = 3;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // pcbScissors
            // 
            this.pcbScissors.BackColor = System.Drawing.Color.MistyRose;
            this.pcbScissors.Image = ((System.Drawing.Image)(resources.GetObject("pcbScissors.Image")));
            this.pcbScissors.Location = new System.Drawing.Point(201, 72);
            this.pcbScissors.Name = "pcbScissors";
            this.pcbScissors.Size = new System.Drawing.Size(58, 88);
            this.pcbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbScissors.TabIndex = 2;
            this.pcbScissors.TabStop = false;
            this.pcbScissors.Click += new System.EventHandler(this.pcbscissors_Click);
            // 
            // pcbPaper
            // 
            this.pcbPaper.BackColor = System.Drawing.Color.MistyRose;
            this.pcbPaper.Image = ((System.Drawing.Image)(resources.GetObject("pcbPaper.Image")));
            this.pcbPaper.Location = new System.Drawing.Point(114, 72);
            this.pcbPaper.Name = "pcbPaper";
            this.pcbPaper.Size = new System.Drawing.Size(58, 88);
            this.pcbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPaper.TabIndex = 1;
            this.pcbPaper.TabStop = false;
            this.pcbPaper.Click += new System.EventHandler(this.pcbpaper_Click);
            // 
            // pcbRock
            // 
            this.pcbRock.BackColor = System.Drawing.Color.MistyRose;
            this.pcbRock.Image = ((System.Drawing.Image)(resources.GetObject("pcbRock.Image")));
            this.pcbRock.Location = new System.Drawing.Point(27, 72);
            this.pcbRock.Name = "pcbRock";
            this.pcbRock.Size = new System.Drawing.Size(58, 88);
            this.pcbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRock.TabIndex = 0;
            this.pcbRock.TabStop = false;
            this.pcbRock.Click += new System.EventHandler(this.pcbRock_Click);
            // 
            // labcomputerhand
            // 
            this.labcomputerhand.AutoSize = true;
            this.labcomputerhand.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcomputerhand.Location = new System.Drawing.Point(36, 122);
            this.labcomputerhand.Name = "labcomputerhand";
            this.labcomputerhand.Size = new System.Drawing.Size(114, 16);
            this.labcomputerhand.TabIndex = 2;
            this.labcomputerhand.Text = "COMPUTERHAND";
            // 
            // labplayerhand
            // 
            this.labplayerhand.AutoSize = true;
            this.labplayerhand.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labplayerhand.Location = new System.Drawing.Point(245, 122);
            this.labplayerhand.Name = "labplayerhand";
            this.labplayerhand.Size = new System.Drawing.Size(90, 16);
            this.labplayerhand.TabIndex = 3;
            this.labplayerhand.Text = "PLAYERHAND";
            // 
            // pcbComputer
            // 
            this.pcbComputer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbComputer.Location = new System.Drawing.Point(38, 159);
            this.pcbComputer.Name = "pcbComputer";
            this.pcbComputer.Size = new System.Drawing.Size(138, 192);
            this.pcbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbComputer.TabIndex = 4;
            this.pcbComputer.TabStop = false;
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlayer.Location = new System.Drawing.Point(247, 159);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(138, 192);
            this.pcbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlayer.TabIndex = 5;
            this.pcbPlayer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.pcbComputer);
            this.Controls.Add(this.labplayerhand);
            this.Controls.Add(this.labcomputerhand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labScores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2020 C# Rock Paper Scissors Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labScores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.PictureBox pcbScissors;
        private System.Windows.Forms.PictureBox pcbPaper;
        private System.Windows.Forms.PictureBox pcbRock;
        private System.Windows.Forms.Label labcomputerhand;
        private System.Windows.Forms.Label labplayerhand;
        private System.Windows.Forms.PictureBox pcbComputer;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Label label1;
    }
}

