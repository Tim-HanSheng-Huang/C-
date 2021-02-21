namespace R09725060HSHuangAss05BrickGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pcbBrick = new System.Windows.Forms.PictureBox();
            this.pcbBall = new System.Windows.Forms.PictureBox();
            this.pcbBar = new System.Windows.Forms.PictureBox();
            this.pcbBlast = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pcbRestart = new System.Windows.Forms.PictureBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.pcbWin = new System.Windows.Forms.PictureBox();
            this.ptbheart1 = new System.Windows.Forms.PictureBox();
            this.ptbheart2 = new System.Windows.Forms.PictureBox();
            this.ptbheart3 = new System.Windows.Forms.PictureBox();
            this.pcbLose = new System.Windows.Forms.PictureBox();
            this.lablevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBlast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLose)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBrick
            // 
            this.pcbBrick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbBrick.BackColor = System.Drawing.SystemColors.Window;
            this.pcbBrick.Image = ((System.Drawing.Image)(resources.GetObject("pcbBrick.Image")));
            this.pcbBrick.Location = new System.Drawing.Point(12, 12);
            this.pcbBrick.Name = "pcbBrick";
            this.pcbBrick.Size = new System.Drawing.Size(122, 46);
            this.pcbBrick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBrick.TabIndex = 0;
            this.pcbBrick.TabStop = false;
            this.pcbBrick.Visible = false;
            // 
            // pcbBall
            // 
            this.pcbBall.Image = ((System.Drawing.Image)(resources.GetObject("pcbBall.Image")));
            this.pcbBall.Location = new System.Drawing.Point(104, 198);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(30, 30);
            this.pcbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBall.TabIndex = 1;
            this.pcbBall.TabStop = false;
            // 
            // pcbBar
            // 
            this.pcbBar.Image = ((System.Drawing.Image)(resources.GetObject("pcbBar.Image")));
            this.pcbBar.Location = new System.Drawing.Point(363, 368);
            this.pcbBar.Name = "pcbBar";
            this.pcbBar.Size = new System.Drawing.Size(99, 15);
            this.pcbBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBar.TabIndex = 2;
            this.pcbBar.TabStop = false;
            this.pcbBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBlast_MouseDown);
            this.pcbBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbBlast_MouseMove);
            // 
            // pcbBlast
            // 
            this.pcbBlast.Image = ((System.Drawing.Image)(resources.GetObject("pcbBlast.Image")));
            this.pcbBlast.Location = new System.Drawing.Point(66, 64);
            this.pcbBlast.Name = "pcbBlast";
            this.pcbBlast.Size = new System.Drawing.Size(58, 54);
            this.pcbBlast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBlast.TabIndex = 3;
            this.pcbBlast.TabStop = false;
            this.pcbBlast.Visible = false;
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // pcbRestart
            // 
            this.pcbRestart.Image = ((System.Drawing.Image)(resources.GetObject("pcbRestart.Image")));
            this.pcbRestart.Location = new System.Drawing.Point(92, 171);
            this.pcbRestart.Name = "pcbRestart";
            this.pcbRestart.Size = new System.Drawing.Size(586, 173);
            this.pcbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRestart.TabIndex = 4;
            this.pcbRestart.TabStop = false;
            this.pcbRestart.Visible = false;
            this.pcbRestart.Click += new System.EventHandler(this.pcbRestart_Click);
            // 
            // pcbPass
            // 
            this.pcbPass.Image = ((System.Drawing.Image)(resources.GetObject("pcbPass.Image")));
            this.pcbPass.Location = new System.Drawing.Point(92, 171);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(586, 175);
            this.pcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPass.TabIndex = 5;
            this.pcbPass.TabStop = false;
            this.pcbPass.Visible = false;
            this.pcbPass.Click += new System.EventHandler(this.pcbPass_Click);
            // 
            // pcbWin
            // 
            this.pcbWin.Image = ((System.Drawing.Image)(resources.GetObject("pcbWin.Image")));
            this.pcbWin.Location = new System.Drawing.Point(150, 153);
            this.pcbWin.Name = "pcbWin";
            this.pcbWin.Size = new System.Drawing.Size(485, 205);
            this.pcbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWin.TabIndex = 6;
            this.pcbWin.TabStop = false;
            this.pcbWin.Visible = false;
            this.pcbWin.Click += new System.EventHandler(this.pcbWin_Click);
            // 
            // ptbheart1
            // 
            this.ptbheart1.Image = ((System.Drawing.Image)(resources.GetObject("ptbheart1.Image")));
            this.ptbheart1.Location = new System.Drawing.Point(748, 398);
            this.ptbheart1.Name = "ptbheart1";
            this.ptbheart1.Size = new System.Drawing.Size(50, 50);
            this.ptbheart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbheart1.TabIndex = 7;
            this.ptbheart1.TabStop = false;
            // 
            // ptbheart2
            // 
            this.ptbheart2.Image = ((System.Drawing.Image)(resources.GetObject("ptbheart2.Image")));
            this.ptbheart2.Location = new System.Drawing.Point(702, 398);
            this.ptbheart2.Name = "ptbheart2";
            this.ptbheart2.Size = new System.Drawing.Size(50, 50);
            this.ptbheart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbheart2.TabIndex = 8;
            this.ptbheart2.TabStop = false;
            // 
            // ptbheart3
            // 
            this.ptbheart3.Image = ((System.Drawing.Image)(resources.GetObject("ptbheart3.Image")));
            this.ptbheart3.Location = new System.Drawing.Point(656, 398);
            this.ptbheart3.Name = "ptbheart3";
            this.ptbheart3.Size = new System.Drawing.Size(50, 50);
            this.ptbheart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbheart3.TabIndex = 9;
            this.ptbheart3.TabStop = false;
            // 
            // pcbLose
            // 
            this.pcbLose.Image = ((System.Drawing.Image)(resources.GetObject("pcbLose.Image")));
            this.pcbLose.Location = new System.Drawing.Point(150, 153);
            this.pcbLose.Name = "pcbLose";
            this.pcbLose.Size = new System.Drawing.Size(485, 205);
            this.pcbLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLose.TabIndex = 10;
            this.pcbLose.TabStop = false;
            this.pcbLose.Visible = false;
            this.pcbLose.Click += new System.EventHandler(this.pcbLose_Click);
            // 
            // lablevel
            // 
            this.lablevel.AutoSize = true;
            this.lablevel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablevel.ForeColor = System.Drawing.Color.White;
            this.lablevel.Location = new System.Drawing.Point(12, 426);
            this.lablevel.Name = "lablevel";
            this.lablevel.Size = new System.Drawing.Size(60, 16);
            this.lablevel.TabIndex = 11;
            this.lablevel.Text = "LEVEL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lablevel);
            this.Controls.Add(this.pcbLose);
            this.Controls.Add(this.ptbheart3);
            this.Controls.Add(this.ptbheart2);
            this.Controls.Add(this.ptbheart1);
            this.Controls.Add(this.pcbWin);
            this.Controls.Add(this.pcbRestart);
            this.Controls.Add(this.pcbPass);
            this.Controls.Add(this.pcbBlast);
            this.Controls.Add(this.pcbBar);
            this.Controls.Add(this.pcbBall);
            this.Controls.Add(this.pcbBrick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick Buster Game 2020(c) HSHuang";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBlast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbheart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBrick;
        private System.Windows.Forms.PictureBox pcbBall;
        private System.Windows.Forms.PictureBox pcbBar;
        private System.Windows.Forms.PictureBox pcbBlast;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox pcbRestart;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.PictureBox pcbWin;
        private System.Windows.Forms.PictureBox ptbheart1;
        private System.Windows.Forms.PictureBox ptbheart2;
        private System.Windows.Forms.PictureBox ptbheart3;
        private System.Windows.Forms.PictureBox pcbLose;
        private System.Windows.Forms.Label lablevel;
    }
}

