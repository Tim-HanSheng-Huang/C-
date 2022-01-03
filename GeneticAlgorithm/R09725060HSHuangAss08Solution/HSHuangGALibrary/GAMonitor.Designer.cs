namespace HSHuangGALibrary
{
    partial class GAMonitor<S>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ppgGA = new System.Windows.Forms.PropertyGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.rtbTheBestSolution = new System.Windows.Forms.RichTextBox();
            this.labSoFarTheBestObjective = new System.Windows.Forms.Label();
            this.chtGA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGA)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(867, 523);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btnRunToEnd);
            this.splitContainer2.Panel1.Controls.Add(this.btnRunOneIteration);
            this.splitContainer2.Panel1.Controls.Add(this.btnReset);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ppgGA);
            this.splitContainer2.Size = new System.Drawing.Size(329, 523);
            this.splitContainer2.SplitterDistance = 199;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Enabled = false;
            this.btnRunToEnd.Location = new System.Drawing.Point(155, 132);
            this.btnRunToEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(132, 51);
            this.btnRunToEnd.TabIndex = 2;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.Enabled = false;
            this.btnRunOneIteration.Location = new System.Drawing.Point(155, 64);
            this.btnRunOneIteration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(132, 51);
            this.btnRunOneIteration.TabIndex = 1;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = true;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(27, 64);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 122);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ppgGA
            // 
            this.ppgGA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppgGA.Location = new System.Drawing.Point(0, 0);
            this.ppgGA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppgGA.Name = "ppgGA";
            this.ppgGA.Size = new System.Drawing.Size(329, 319);
            this.ppgGA.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.rtbTheBestSolution);
            this.splitContainer3.Panel1.Controls.Add(this.labSoFarTheBestObjective);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chtGA);
            this.splitContainer3.Size = new System.Drawing.Size(533, 523);
            this.splitContainer3.SplitterDistance = 220;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // rtbTheBestSolution
            // 
            this.rtbTheBestSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTheBestSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTheBestSolution.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbTheBestSolution.Location = new System.Drawing.Point(0, 39);
            this.rtbTheBestSolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbTheBestSolution.Name = "rtbTheBestSolution";
            this.rtbTheBestSolution.Size = new System.Drawing.Size(533, 181);
            this.rtbTheBestSolution.TabIndex = 1;
            this.rtbTheBestSolution.Text = "";
            // 
            // labSoFarTheBestObjective
            // 
            this.labSoFarTheBestObjective.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labSoFarTheBestObjective.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSoFarTheBestObjective.Location = new System.Drawing.Point(0, 0);
            this.labSoFarTheBestObjective.Name = "labSoFarTheBestObjective";
            this.labSoFarTheBestObjective.Size = new System.Drawing.Size(533, 39);
            this.labSoFarTheBestObjective.TabIndex = 0;
            this.labSoFarTheBestObjective.Text = "The Best Objective";
            this.labSoFarTheBestObjective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chtGA
            // 
            chartArea13.Name = "ChartArea1";
            this.chtGA.ChartAreas.Add(chartArea13);
            this.chtGA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend13.Name = "Legend1";
            this.chtGA.Legends.Add(legend13);
            this.chtGA.Location = new System.Drawing.Point(0, 0);
            this.chtGA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chtGA.Name = "chtGA";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Color = System.Drawing.Color.Lime;
            series37.Legend = "Legend1";
            series37.LegendText = "Iteration Average";
            series37.Name = "Series1";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Color = System.Drawing.Color.Blue;
            series38.Legend = "Legend1";
            series38.LegendText = "Iteration Best";
            series38.Name = "Series2";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Color = System.Drawing.Color.Red;
            series39.Legend = "Legend1";
            series39.LegendText = "So Far The Best";
            series39.Name = "Series3";
            this.chtGA.Series.Add(series37);
            this.chtGA.Series.Add(series38);
            this.chtGA.Series.Add(series39);
            this.chtGA.Size = new System.Drawing.Size(533, 298);
            this.chtGA.TabIndex = 0;
            this.chtGA.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Action";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GAMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GAMonitor";
            this.Size = new System.Drawing.Size(867, 523);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.PropertyGrid ppgGA;
        public System.Windows.Forms.Button btnRunToEnd;
        public System.Windows.Forms.Button btnRunOneIteration;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.DataVisualization.Charting.Chart chtGA;
        private System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.RichTextBox rtbTheBestSolution;
        public System.Windows.Forms.Label labSoFarTheBestObjective;
        public System.Windows.Forms.Label label1;
    }
}
