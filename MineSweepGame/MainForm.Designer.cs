namespace R09725060MineSweepGameSolution
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.transparentPanel_pass = new R09725060MineSweepGameSolution.TransparentPanel();
            this.transparentPanel_lose = new R09725060MineSweepGameSolution.TransparentPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numudRow = new System.Windows.Forms.NumericUpDown();
            this.numudCol = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudCol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.Location = new System.Drawing.Point(387, 54);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(123, 46);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // transparentPanel_pass
            // 
            this.transparentPanel_pass.Image = global::R09725060MineSweepGameSolution.Properties.Resources.pass;
            this.transparentPanel_pass.Location = new System.Drawing.Point(173, 512);
            this.transparentPanel_pass.Name = "transparentPanel_pass";
            this.transparentPanel_pass.Size = new System.Drawing.Size(212, 80);
            this.transparentPanel_pass.TabIndex = 5;
            this.transparentPanel_pass.Visible = false;
            // 
            // transparentPanel_lose
            // 
            this.transparentPanel_lose.Image = global::R09725060MineSweepGameSolution.Properties.Resources.lose;
            this.transparentPanel_lose.Location = new System.Drawing.Point(173, 512);
            this.transparentPanel_lose.Name = "transparentPanel_lose";
            this.transparentPanel_lose.Size = new System.Drawing.Size(212, 80);
            this.transparentPanel_lose.TabIndex = 3;
            this.transparentPanel_lose.Visible = false;
            // 
            // numudRow
            // 
            this.numudRow.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numudRow.Location = new System.Drawing.Point(59, 70);
            this.numudRow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numudRow.Name = "numudRow";
            this.numudRow.Size = new System.Drawing.Size(78, 25);
            this.numudRow.TabIndex = 6;
            this.numudRow.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numudCol
            // 
            this.numudCol.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numudCol.Location = new System.Drawing.Point(168, 70);
            this.numudCol.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numudCol.Name = "numudCol";
            this.numudCol.Size = new System.Drawing.Size(78, 25);
            this.numudCol.TabIndex = 7;
            this.numudCol.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ROW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(167, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "COLUMN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numudCol);
            this.Controls.Add(this.numudRow);
            this.Controls.Add(this.transparentPanel_pass);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.transparentPanel_lose);
            this.Name = "MainForm";
            this.Text = "MineSweepGame";
            ((System.ComponentModel.ISupportInitialize)(this.numudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransparentPanel transparentPanel_lose;
        private System.Windows.Forms.Button btnRestart;
        private TransparentPanel transparentPanel_pass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numudRow;
        private System.Windows.Forms.NumericUpDown numudCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

