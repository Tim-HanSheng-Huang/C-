namespace R09725060HSHAss06
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnFindGCDnLCM = new System.Windows.Forms.Button();
            this.rtbGCDLCMResult = new System.Windows.Forms.RichTextBox();
            this.labResult = new System.Windows.Forms.Label();
            this.txbB = new System.Windows.Forms.TextBox();
            this.labNumber2 = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.labNumber1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbPrime = new System.Windows.Forms.RichTextBox();
            this.btnFindAllPrimes = new System.Windows.Forms.Button();
            this.labLimit = new System.Windows.Forms.Label();
            this.txbLimit = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(52, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Controls.Add(this.btnFindGCDnLCM);
            this.tabPage1.Controls.Add(this.rtbGCDLCMResult);
            this.tabPage1.Controls.Add(this.labResult);
            this.tabPage1.Controls.Add(this.txbB);
            this.tabPage1.Controls.Add(this.labNumber2);
            this.tabPage1.Controls.Add(this.txbA);
            this.tabPage1.Controls.Add(this.labNumber1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LCM/GCD Finder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(43, 36);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.SelectedObject = this.btnFindGCDnLCM;
            this.propertyGrid1.Size = new System.Drawing.Size(187, 138);
            this.propertyGrid1.TabIndex = 7;
            // 
            // btnFindGCDnLCM
            // 
            this.btnFindGCDnLCM.Location = new System.Drawing.Point(43, 219);
            this.btnFindGCDnLCM.Name = "btnFindGCDnLCM";
            this.btnFindGCDnLCM.Size = new System.Drawing.Size(130, 52);
            this.btnFindGCDnLCM.TabIndex = 6;
            this.btnFindGCDnLCM.Text = "Find GCD/LCM";
            this.btnFindGCDnLCM.UseVisualStyleBackColor = true;
            this.btnFindGCDnLCM.Click += new System.EventHandler(this.btnFindGCDnGCD_Click);
            // 
            // rtbGCDLCMResult
            // 
            this.rtbGCDLCMResult.ForeColor = System.Drawing.Color.Maroon;
            this.rtbGCDLCMResult.Location = new System.Drawing.Point(269, 73);
            this.rtbGCDLCMResult.Name = "rtbGCDLCMResult";
            this.rtbGCDLCMResult.Size = new System.Drawing.Size(369, 242);
            this.rtbGCDLCMResult.TabIndex = 5;
            this.rtbGCDLCMResult.Text = "";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(265, 36);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(70, 24);
            this.labResult.TabIndex = 4;
            this.labResult.Text = "Result:";
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(436, 219);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 25);
            this.txbB.TabIndex = 3;
            this.txbB.Text = "868";
            this.txbB.Visible = false;
            // 
            // labNumber2
            // 
            this.labNumber2.AutoSize = true;
            this.labNumber2.Location = new System.Drawing.Point(349, 222);
            this.labNumber2.Name = "labNumber2";
            this.labNumber2.Size = new System.Drawing.Size(66, 17);
            this.labNumber2.TabIndex = 2;
            this.labNumber2.Text = "Number2";
            this.labNumber2.Visible = false;
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(436, 179);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 25);
            this.txbA.TabIndex = 1;
            this.txbA.Text = "686";
            this.txbA.Visible = false;
            // 
            // labNumber1
            // 
            this.labNumber1.AutoSize = true;
            this.labNumber1.Location = new System.Drawing.Point(349, 183);
            this.labNumber1.Name = "labNumber1";
            this.labNumber1.Size = new System.Drawing.Size(66, 17);
            this.labNumber1.TabIndex = 0;
            this.labNumber1.Text = "Number1";
            this.labNumber1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbPrime);
            this.tabPage2.Controls.Add(this.btnFindAllPrimes);
            this.tabPage2.Controls.Add(this.labLimit);
            this.tabPage2.Controls.Add(this.txbLimit);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prime Number Finder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbPrime
            // 
            this.rtbPrime.Location = new System.Drawing.Point(40, 90);
            this.rtbPrime.Name = "rtbPrime";
            this.rtbPrime.Size = new System.Drawing.Size(416, 229);
            this.rtbPrime.TabIndex = 3;
            this.rtbPrime.Text = "";
            // 
            // btnFindAllPrimes
            // 
            this.btnFindAllPrimes.Location = new System.Drawing.Point(474, 273);
            this.btnFindAllPrimes.Name = "btnFindAllPrimes";
            this.btnFindAllPrimes.Size = new System.Drawing.Size(129, 46);
            this.btnFindAllPrimes.TabIndex = 2;
            this.btnFindAllPrimes.Text = "Find All Prime";
            this.btnFindAllPrimes.UseVisualStyleBackColor = true;
            this.btnFindAllPrimes.Click += new System.EventHandler(this.btnFindAllPrimes_Click);
            // 
            // labLimit
            // 
            this.labLimit.AutoSize = true;
            this.labLimit.Location = new System.Drawing.Point(37, 45);
            this.labLimit.Name = "labLimit";
            this.labLimit.Size = new System.Drawing.Size(43, 17);
            this.labLimit.TabIndex = 1;
            this.labLimit.Text = "LIMIT";
            // 
            // txbLimit
            // 
            this.txbLimit.Location = new System.Drawing.Point(97, 41);
            this.txbLimit.Name = "txbLimit";
            this.txbLimit.Size = new System.Drawing.Size(100, 25);
            this.txbLimit.TabIndex = 0;
            this.txbLimit.Text = "2020";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCM/GCD Finder & Prime Finder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFindGCDnLCM;
        private System.Windows.Forms.RichTextBox rtbGCDLCMResult;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Label labNumber2;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label labNumber1;
        private System.Windows.Forms.RichTextBox rtbPrime;
        private System.Windows.Forms.Button btnFindAllPrimes;
        private System.Windows.Forms.Label labLimit;
        private System.Windows.Forms.TextBox txbLimit;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

