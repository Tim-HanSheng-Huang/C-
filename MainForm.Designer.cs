namespace R09725060HSHunagAss11
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pagText = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.nudDeltaAngle = new System.Windows.Forms.NumericUpDown();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.pag = new System.Windows.Forms.TabPage();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAnimation = new System.Windows.Forms.Button();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.labSpeed = new System.Windows.Forms.Label();
            this.rdbFast = new System.Windows.Forms.RadioButton();
            this.rdbSlow = new System.Windows.Forms.RadioButton();
            this.rdbMiddle = new System.Windows.Forms.RadioButton();
            this.tbGroundLength = new System.Windows.Forms.TrackBar();
            this.labGoundLength = new System.Windows.Forms.Label();
            this.labConnectorLength = new System.Windows.Forms.Label();
            this.tbConnectorLength = new System.Windows.Forms.TrackBar();
            this.labDriverLength = new System.Windows.Forms.Label();
            this.tbDriverLength = new System.Windows.Forms.TrackBar();
            this.labFollowerLength = new System.Windows.Forms.Label();
            this.tbFollowerLength = new System.Windows.Forms.TrackBar();
            this.labPOIAxialOffsets = new System.Windows.Forms.Label();
            this.tbPOIAxialOffsets = new System.Windows.Forms.TrackBar();
            this.labPOIRadialOffsets = new System.Windows.Forms.Label();
            this.tbPOIRaialOffsets = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labWarning = new System.Windows.Forms.Label();
            this.chbtrajectory = new System.Windows.Forms.CheckBox();
            this.tabMain.SuspendLayout();
            this.pagText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeltaAngle)).BeginInit();
            this.pag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroundLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConnectorLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFollowerLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPOIAxialOffsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPOIRaialOffsets)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.pagText);
            this.tabMain.Controls.Add(this.pag);
            this.tabMain.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(776, 426);
            this.tabMain.TabIndex = 0;
            // 
            // pagText
            // 
            this.pagText.Controls.Add(this.label1);
            this.pagText.Controls.Add(this.rtbOutput);
            this.pagText.Controls.Add(this.nudDeltaAngle);
            this.pagText.Controls.Add(this.btnCalculation);
            this.pagText.Location = new System.Drawing.Point(4, 25);
            this.pagText.Name = "pagText";
            this.pagText.Padding = new System.Windows.Forms.Padding(3);
            this.pagText.Size = new System.Drawing.Size(768, 397);
            this.pagText.TabIndex = 0;
            this.pagText.Text = "Calculation Text";
            this.pagText.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delta of Angle";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(33, 93);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(603, 225);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // nudDeltaAngle
            // 
            this.nudDeltaAngle.DecimalPlaces = 2;
            this.nudDeltaAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDeltaAngle.Location = new System.Drawing.Point(128, 35);
            this.nudDeltaAngle.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeltaAngle.Name = "nudDeltaAngle";
            this.nudDeltaAngle.Size = new System.Drawing.Size(120, 23);
            this.nudDeltaAngle.TabIndex = 1;
            this.nudDeltaAngle.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(282, 28);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(104, 35);
            this.btnCalculation.TabIndex = 0;
            this.btnCalculation.Text = "Display";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // pag
            // 
            this.pag.Controls.Add(this.spcMain);
            this.pag.Location = new System.Drawing.Point(4, 25);
            this.pag.Name = "pag";
            this.pag.Padding = new System.Windows.Forms.Padding(3);
            this.pag.Size = new System.Drawing.Size(768, 397);
            this.pag.TabIndex = 1;
            this.pag.Text = "Graphics Animation";
            this.pag.UseVisualStyleBackColor = true;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(3, 3);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.BackColor = System.Drawing.Color.SeaShell;
            this.spcMain.Panel1.Controls.Add(this.chbtrajectory);
            this.spcMain.Panel1.Controls.Add(this.label7);
            this.spcMain.Panel1.Controls.Add(this.label6);
            this.spcMain.Panel1.Controls.Add(this.label5);
            this.spcMain.Panel1.Controls.Add(this.label4);
            this.spcMain.Panel1.Controls.Add(this.label3);
            this.spcMain.Panel1.Controls.Add(this.label2);
            this.spcMain.Panel1.Controls.Add(this.labPOIRadialOffsets);
            this.spcMain.Panel1.Controls.Add(this.tbPOIRaialOffsets);
            this.spcMain.Panel1.Controls.Add(this.labPOIAxialOffsets);
            this.spcMain.Panel1.Controls.Add(this.tbPOIAxialOffsets);
            this.spcMain.Panel1.Controls.Add(this.labFollowerLength);
            this.spcMain.Panel1.Controls.Add(this.tbFollowerLength);
            this.spcMain.Panel1.Controls.Add(this.labDriverLength);
            this.spcMain.Panel1.Controls.Add(this.tbDriverLength);
            this.spcMain.Panel1.Controls.Add(this.labConnectorLength);
            this.spcMain.Panel1.Controls.Add(this.tbConnectorLength);
            this.spcMain.Panel1.Controls.Add(this.labGoundLength);
            this.spcMain.Panel1.Controls.Add(this.tbGroundLength);
            this.spcMain.Panel1.Controls.Add(this.rdbMiddle);
            this.spcMain.Panel1.Controls.Add(this.rdbSlow);
            this.spcMain.Panel1.Controls.Add(this.rdbFast);
            this.spcMain.Panel1.Controls.Add(this.labSpeed);
            this.spcMain.Panel1.Controls.Add(this.btnClear);
            this.spcMain.Panel1.Controls.Add(this.btnAnimation);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.spcMain.Panel2.Controls.Add(this.labWarning);
            this.spcMain.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spcMain_Panel2_Paint);
            this.spcMain.Size = new System.Drawing.Size(762, 391);
            this.spcMain.SplitterDistance = 253;
            this.spcMain.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear POIs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnimation
            // 
            this.btnAnimation.Location = new System.Drawing.Point(138, 343);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(95, 32);
            this.btnAnimation.TabIndex = 1;
            this.btnAnimation.Text = "Animate";
            this.btnAnimation.UseVisualStyleBackColor = true;
            this.btnAnimation.Click += new System.EventHandler(this.btnAnimation_Click);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSpeed.Location = new System.Drawing.Point(19, 279);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(45, 17);
            this.labSpeed.TabIndex = 3;
            this.labSpeed.Text = "Speed";
            // 
            // rdbFast
            // 
            this.rdbFast.AutoSize = true;
            this.rdbFast.Location = new System.Drawing.Point(24, 300);
            this.rdbFast.Name = "rdbFast";
            this.rdbFast.Size = new System.Drawing.Size(48, 20);
            this.rdbFast.TabIndex = 4;
            this.rdbFast.Text = "Fast";
            this.rdbFast.UseVisualStyleBackColor = true;
            // 
            // rdbSlow
            // 
            this.rdbSlow.AutoSize = true;
            this.rdbSlow.Location = new System.Drawing.Point(163, 300);
            this.rdbSlow.Name = "rdbSlow";
            this.rdbSlow.Size = new System.Drawing.Size(53, 20);
            this.rdbSlow.TabIndex = 5;
            this.rdbSlow.Text = "Slow";
            this.rdbSlow.UseVisualStyleBackColor = true;
            // 
            // rdbMiddle
            // 
            this.rdbMiddle.AutoSize = true;
            this.rdbMiddle.Checked = true;
            this.rdbMiddle.Location = new System.Drawing.Point(84, 300);
            this.rdbMiddle.Name = "rdbMiddle";
            this.rdbMiddle.Size = new System.Drawing.Size(67, 20);
            this.rdbMiddle.TabIndex = 6;
            this.rdbMiddle.TabStop = true;
            this.rdbMiddle.Text = "Middle";
            this.rdbMiddle.UseVisualStyleBackColor = true;
            // 
            // tbGroundLength
            // 
            this.tbGroundLength.LargeChange = 10;
            this.tbGroundLength.Location = new System.Drawing.Point(127, 115);
            this.tbGroundLength.Maximum = 100;
            this.tbGroundLength.Minimum = 1;
            this.tbGroundLength.Name = "tbGroundLength";
            this.tbGroundLength.Size = new System.Drawing.Size(84, 45);
            this.tbGroundLength.SmallChange = 10;
            this.tbGroundLength.TabIndex = 7;
            this.tbGroundLength.Value = 20;
            this.tbGroundLength.Scroll += new System.EventHandler(this.tbGroundLength_Scroll);
            // 
            // labGoundLength
            // 
            this.labGoundLength.AutoSize = true;
            this.labGoundLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labGoundLength.Location = new System.Drawing.Point(199, 129);
            this.labGoundLength.Name = "labGoundLength";
            this.labGoundLength.Size = new System.Drawing.Size(22, 16);
            this.labGoundLength.TabIndex = 8;
            this.labGoundLength.Text = "20";
            // 
            // labConnectorLength
            // 
            this.labConnectorLength.AutoSize = true;
            this.labConnectorLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labConnectorLength.Location = new System.Drawing.Point(91, 53);
            this.labConnectorLength.Name = "labConnectorLength";
            this.labConnectorLength.Size = new System.Drawing.Size(22, 16);
            this.labConnectorLength.TabIndex = 10;
            this.labConnectorLength.Text = "35";
            // 
            // tbConnectorLength
            // 
            this.tbConnectorLength.LargeChange = 10;
            this.tbConnectorLength.Location = new System.Drawing.Point(19, 39);
            this.tbConnectorLength.Maximum = 100;
            this.tbConnectorLength.Minimum = 1;
            this.tbConnectorLength.Name = "tbConnectorLength";
            this.tbConnectorLength.Size = new System.Drawing.Size(84, 45);
            this.tbConnectorLength.SmallChange = 10;
            this.tbConnectorLength.TabIndex = 9;
            this.tbConnectorLength.Value = 35;
            this.tbConnectorLength.Scroll += new System.EventHandler(this.tbConnectorLength_Scroll);
            // 
            // labDriverLength
            // 
            this.labDriverLength.AutoSize = true;
            this.labDriverLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDriverLength.Location = new System.Drawing.Point(199, 53);
            this.labDriverLength.Name = "labDriverLength";
            this.labDriverLength.Size = new System.Drawing.Size(22, 16);
            this.labDriverLength.TabIndex = 12;
            this.labDriverLength.Text = "10";
            // 
            // tbDriverLength
            // 
            this.tbDriverLength.LargeChange = 10;
            this.tbDriverLength.Location = new System.Drawing.Point(127, 39);
            this.tbDriverLength.Maximum = 20;
            this.tbDriverLength.Minimum = 1;
            this.tbDriverLength.Name = "tbDriverLength";
            this.tbDriverLength.Size = new System.Drawing.Size(84, 45);
            this.tbDriverLength.SmallChange = 10;
            this.tbDriverLength.TabIndex = 11;
            this.tbDriverLength.Value = 10;
            this.tbDriverLength.Scroll += new System.EventHandler(this.tbDriverLength_Scroll);
            // 
            // labFollowerLength
            // 
            this.labFollowerLength.AutoSize = true;
            this.labFollowerLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labFollowerLength.Location = new System.Drawing.Point(91, 129);
            this.labFollowerLength.Name = "labFollowerLength";
            this.labFollowerLength.Size = new System.Drawing.Size(22, 16);
            this.labFollowerLength.TabIndex = 14;
            this.labFollowerLength.Text = "25";
            // 
            // tbFollowerLength
            // 
            this.tbFollowerLength.LargeChange = 10;
            this.tbFollowerLength.Location = new System.Drawing.Point(19, 115);
            this.tbFollowerLength.Maximum = 100;
            this.tbFollowerLength.Minimum = 1;
            this.tbFollowerLength.Name = "tbFollowerLength";
            this.tbFollowerLength.Size = new System.Drawing.Size(84, 45);
            this.tbFollowerLength.SmallChange = 10;
            this.tbFollowerLength.TabIndex = 13;
            this.tbFollowerLength.Value = 25;
            this.tbFollowerLength.Scroll += new System.EventHandler(this.tbFollwerLength_Scroll);
            // 
            // labPOIAxialOffsets
            // 
            this.labPOIAxialOffsets.AutoSize = true;
            this.labPOIAxialOffsets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPOIAxialOffsets.Location = new System.Drawing.Point(91, 205);
            this.labPOIAxialOffsets.Name = "labPOIAxialOffsets";
            this.labPOIAxialOffsets.Size = new System.Drawing.Size(22, 16);
            this.labPOIAxialOffsets.TabIndex = 16;
            this.labPOIAxialOffsets.Text = "17";
            // 
            // tbPOIAxialOffsets
            // 
            this.tbPOIAxialOffsets.LargeChange = 10;
            this.tbPOIAxialOffsets.Location = new System.Drawing.Point(19, 191);
            this.tbPOIAxialOffsets.Maximum = 35;
            this.tbPOIAxialOffsets.Minimum = 1;
            this.tbPOIAxialOffsets.Name = "tbPOIAxialOffsets";
            this.tbPOIAxialOffsets.Size = new System.Drawing.Size(84, 45);
            this.tbPOIAxialOffsets.SmallChange = 10;
            this.tbPOIAxialOffsets.TabIndex = 15;
            this.tbPOIAxialOffsets.Value = 17;
            this.tbPOIAxialOffsets.Scroll += new System.EventHandler(this.tbPOIAxialOffsets_Scroll);
            // 
            // labPOIRadialOffsets
            // 
            this.labPOIRadialOffsets.AutoSize = true;
            this.labPOIRadialOffsets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPOIRadialOffsets.Location = new System.Drawing.Point(199, 205);
            this.labPOIRadialOffsets.Name = "labPOIRadialOffsets";
            this.labPOIRadialOffsets.Size = new System.Drawing.Size(15, 16);
            this.labPOIRadialOffsets.TabIndex = 18;
            this.labPOIRadialOffsets.Text = "5";
            // 
            // tbPOIRaialOffsets
            // 
            this.tbPOIRaialOffsets.LargeChange = 10;
            this.tbPOIRaialOffsets.Location = new System.Drawing.Point(127, 191);
            this.tbPOIRaialOffsets.Maximum = 20;
            this.tbPOIRaialOffsets.Minimum = 1;
            this.tbPOIRaialOffsets.Name = "tbPOIRaialOffsets";
            this.tbPOIRaialOffsets.Size = new System.Drawing.Size(84, 45);
            this.tbPOIRaialOffsets.SmallChange = 10;
            this.tbPOIRaialOffsets.TabIndex = 17;
            this.tbPOIRaialOffsets.Value = 5;
            this.tbPOIRaialOffsets.Scroll += new System.EventHandler(this.tbPOIRaiaOffsets_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Connector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(127, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Driver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(127, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ground";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Follower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(19, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "POIAxialOffset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(127, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "POIRadialOffset";
            // 
            // labWarning
            // 
            this.labWarning.AutoSize = true;
            this.labWarning.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWarning.Location = new System.Drawing.Point(15, 358);
            this.labWarning.Name = "labWarning";
            this.labWarning.Size = new System.Drawing.Size(11, 17);
            this.labWarning.TabIndex = 25;
            this.labWarning.Text = ".";
            // 
            // chbtrajectory
            // 
            this.chbtrajectory.AutoSize = true;
            this.chbtrajectory.Checked = true;
            this.chbtrajectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbtrajectory.Location = new System.Drawing.Point(24, 243);
            this.chbtrajectory.Name = "chbtrajectory";
            this.chbtrajectory.Size = new System.Drawing.Size(89, 20);
            this.chbtrajectory.TabIndex = 25;
            this.chbtrajectory.Text = "Trajectory?";
            this.chbtrajectory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = " Four Bar Linkage";
            this.tabMain.ResumeLayout(false);
            this.pagText.ResumeLayout(false);
            this.pagText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeltaAngle)).EndInit();
            this.pag.ResumeLayout(false);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGroundLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConnectorLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFollowerLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPOIAxialOffsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPOIRaialOffsets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pagText;
        private System.Windows.Forms.TabPage pag;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.NumericUpDown nudDeltaAngle;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimation;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.RadioButton rdbMiddle;
        private System.Windows.Forms.RadioButton rdbSlow;
        private System.Windows.Forms.RadioButton rdbFast;
        private System.Windows.Forms.TrackBar tbGroundLength;
        private System.Windows.Forms.Label labGoundLength;
        private System.Windows.Forms.Label labFollowerLength;
        private System.Windows.Forms.TrackBar tbFollowerLength;
        private System.Windows.Forms.Label labDriverLength;
        private System.Windows.Forms.TrackBar tbDriverLength;
        private System.Windows.Forms.Label labConnectorLength;
        private System.Windows.Forms.TrackBar tbConnectorLength;
        private System.Windows.Forms.Label labPOIRadialOffsets;
        private System.Windows.Forms.TrackBar tbPOIRaialOffsets;
        private System.Windows.Forms.Label labPOIAxialOffsets;
        private System.Windows.Forms.TrackBar tbPOIAxialOffsets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labWarning;
        private System.Windows.Forms.CheckBox chbtrajectory;
    }
}

