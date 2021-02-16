namespace R09725060HSHuangAss10
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnUpShift = new System.Windows.Forms.Button();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.btnDownShift = new System.Windows.Forms.Button();
            this.labFrameCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.labCurrentFrame = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearAllFrame = new System.Windows.Forms.Button();
            this.btnDeleteCurrentFrame = new System.Windows.Forms.Button();
            this.btnPreviousFrame = new System.Windows.Forms.Button();
            this.btnNextFrame = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRecord.Location = new System.Drawing.Point(670, 254);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(110, 40);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record\r\nCurrent Frame";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnimate.Location = new System.Drawing.Point(670, 201);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(110, 42);
            this.btnAnimate.TabIndex = 1;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(68, 22);
            this.tsbOpen.Text = "Open...";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(54, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labFrameCount,
            this.labCurrentFrame});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "txt";
            this.dlgOpen.FileName = "*.txt";
            this.dlgOpen.Title = "開一個動畫檔";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "txt";
            this.dlgSave.FileName = "*.txt";
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearScreen.Location = new System.Drawing.Point(670, 148);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(110, 42);
            this.btnClearScreen.TabIndex = 5;
            this.btnClearScreen.Text = "Clear Screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLeftShift.Location = new System.Drawing.Point(668, 88);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(34, 36);
            this.btnLeftShift.TabIndex = 6;
            this.btnLeftShift.Text = "←";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            this.btnLeftShift.Click += new System.EventHandler(this.btnLeftShift_Click);
            // 
            // btnUpShift
            // 
            this.btnUpShift.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpShift.Location = new System.Drawing.Point(708, 69);
            this.btnUpShift.Name = "btnUpShift";
            this.btnUpShift.Size = new System.Drawing.Size(34, 36);
            this.btnUpShift.TabIndex = 7;
            this.btnUpShift.Text = "↑";
            this.btnUpShift.UseVisualStyleBackColor = true;
            this.btnUpShift.Click += new System.EventHandler(this.btnUpShift_Click);
            // 
            // btnRightShift
            // 
            this.btnRightShift.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRightShift.Location = new System.Drawing.Point(748, 88);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(34, 36);
            this.btnRightShift.TabIndex = 8;
            this.btnRightShift.Text = "→";
            this.btnRightShift.UseVisualStyleBackColor = true;
            this.btnRightShift.Click += new System.EventHandler(this.btnRightShift_Click);
            // 
            // btnDownShift
            // 
            this.btnDownShift.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDownShift.Location = new System.Drawing.Point(708, 107);
            this.btnDownShift.Name = "btnDownShift";
            this.btnDownShift.Size = new System.Drawing.Size(34, 36);
            this.btnDownShift.TabIndex = 9;
            this.btnDownShift.Text = "↓";
            this.btnDownShift.UseVisualStyleBackColor = true;
            this.btnDownShift.Click += new System.EventHandler(this.btnDownShift_Click);
            // 
            // labFrameCount
            // 
            this.labFrameCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labFrameCount.Name = "labFrameCount";
            this.labFrameCount.Size = new System.Drawing.Size(95, 17);
            this.labFrameCount.Text = "Frame Count : 0";
            // 
            // labCurrentFrame
            // 
            this.labCurrentFrame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labCurrentFrame.Name = "labCurrentFrame";
            this.labCurrentFrame.Size = new System.Drawing.Size(102, 17);
            this.labCurrentFrame.Text = "Current Frame : 0";
            // 
            // btnClearAllFrame
            // 
            this.btnClearAllFrame.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAllFrame.Location = new System.Drawing.Point(670, 300);
            this.btnClearAllFrame.Name = "btnClearAllFrame";
            this.btnClearAllFrame.Size = new System.Drawing.Size(110, 40);
            this.btnClearAllFrame.TabIndex = 10;
            this.btnClearAllFrame.Text = "Clear All Frame";
            this.btnClearAllFrame.UseVisualStyleBackColor = true;
            this.btnClearAllFrame.Click += new System.EventHandler(this.btnClearAllFrame_Click);
            // 
            // btnDeleteCurrentFrame
            // 
            this.btnDeleteCurrentFrame.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteCurrentFrame.Location = new System.Drawing.Point(670, 346);
            this.btnDeleteCurrentFrame.Name = "btnDeleteCurrentFrame";
            this.btnDeleteCurrentFrame.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteCurrentFrame.TabIndex = 11;
            this.btnDeleteCurrentFrame.Text = "Delete\r\nCurrent Frame";
            this.btnDeleteCurrentFrame.UseVisualStyleBackColor = true;
            this.btnDeleteCurrentFrame.Click += new System.EventHandler(this.btnDeleteCurrentFrame_Click);
            // 
            // btnPreviousFrame
            // 
            this.btnPreviousFrame.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPreviousFrame.Location = new System.Drawing.Point(670, 392);
            this.btnPreviousFrame.Name = "btnPreviousFrame";
            this.btnPreviousFrame.Size = new System.Drawing.Size(52, 42);
            this.btnPreviousFrame.TabIndex = 12;
            this.btnPreviousFrame.Text = "Prev \r\nFrame";
            this.btnPreviousFrame.UseVisualStyleBackColor = true;
            this.btnPreviousFrame.Click += new System.EventHandler(this.btnPreviousFrame_Click);
            // 
            // btnNextFrame
            // 
            this.btnNextFrame.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextFrame.Location = new System.Drawing.Point(728, 392);
            this.btnNextFrame.Name = "btnNextFrame";
            this.btnNextFrame.Size = new System.Drawing.Size(52, 42);
            this.btnNextFrame.TabIndex = 13;
            this.btnNextFrame.Text = "Next Frame";
            this.btnNextFrame.UseVisualStyleBackColor = true;
            this.btnNextFrame.Click += new System.EventHandler(this.btnNextFrame_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnNextFrame);
            this.Controls.Add(this.btnPreviousFrame);
            this.Controls.Add(this.btnDeleteCurrentFrame);
            this.Controls.Add(this.btnClearAllFrame);
            this.Controls.Add(this.btnDownShift);
            this.Controls.Add(this.btnRightShift);
            this.Controls.Add(this.btnUpShift);
            this.Controls.Add(this.btnLeftShift);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "LED PLAYER";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnUpShift;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.Button btnDownShift;
        private System.Windows.Forms.ToolStripStatusLabel labFrameCount;
        private System.Windows.Forms.ToolStripStatusLabel labCurrentFrame;
        private System.Windows.Forms.Button btnClearAllFrame;
        private System.Windows.Forms.Button btnDeleteCurrentFrame;
        private System.Windows.Forms.Button btnPreviousFrame;
        private System.Windows.Forms.Button btnNextFrame;
    }
}

