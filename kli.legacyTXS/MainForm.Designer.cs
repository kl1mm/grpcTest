namespace kli.legacyTXS
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
			this.buttonCalc = new System.Windows.Forms.Button();
			this.numericLhs = new System.Windows.Forms.NumericUpDown();
			this.rbPlus = new System.Windows.Forms.RadioButton();
			this.rbDivied = new System.Windows.Forms.RadioButton();
			this.rbMultipy = new System.Windows.Forms.RadioButton();
			this.rbMinus = new System.Windows.Forms.RadioButton();
			this.groupBoxCal = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.numericRhs = new System.Windows.Forms.NumericUpDown();
			this.labelInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericLhs)).BeginInit();
			this.groupBoxCal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRhs)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCalc
			// 
			this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCalc.Enabled = false;
			this.buttonCalc.Location = new System.Drawing.Point(414, 54);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(71, 23);
			this.buttonCalc.TabIndex = 0;
			this.buttonCalc.Text = "Calc";
			this.buttonCalc.UseVisualStyleBackColor = true;
			this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
			// 
			// numericLhs
			// 
			this.numericLhs.Location = new System.Drawing.Point(6, 19);
			this.numericLhs.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericLhs.Name = "numericLhs";
			this.numericLhs.Size = new System.Drawing.Size(120, 20);
			this.numericLhs.TabIndex = 7;
			this.numericLhs.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// rbPlus
			// 
			this.rbPlus.AutoSize = true;
			this.rbPlus.Checked = true;
			this.rbPlus.Location = new System.Drawing.Point(132, 19);
			this.rbPlus.Name = "rbPlus";
			this.rbPlus.Size = new System.Drawing.Size(31, 17);
			this.rbPlus.TabIndex = 8;
			this.rbPlus.TabStop = true;
			this.rbPlus.Tag = "0";
			this.rbPlus.Text = "+";
			this.rbPlus.UseVisualStyleBackColor = true;
			// 
			// rbDivied
			// 
			this.rbDivied.AutoSize = true;
			this.rbDivied.Location = new System.Drawing.Point(239, 19);
			this.rbDivied.Name = "rbDivied";
			this.rbDivied.Size = new System.Drawing.Size(30, 17);
			this.rbDivied.TabIndex = 9;
			this.rbDivied.Tag = "3";
			this.rbDivied.Text = "/";
			this.rbDivied.UseVisualStyleBackColor = true;
			// 
			// rbMultipy
			// 
			this.rbMultipy.AutoSize = true;
			this.rbMultipy.Location = new System.Drawing.Point(203, 19);
			this.rbMultipy.Name = "rbMultipy";
			this.rbMultipy.Size = new System.Drawing.Size(30, 17);
			this.rbMultipy.TabIndex = 10;
			this.rbMultipy.Tag = "2";
			this.rbMultipy.Text = "x";
			this.rbMultipy.UseVisualStyleBackColor = true;
			// 
			// rbMinus
			// 
			this.rbMinus.AutoSize = true;
			this.rbMinus.Location = new System.Drawing.Point(169, 19);
			this.rbMinus.Name = "rbMinus";
			this.rbMinus.Size = new System.Drawing.Size(28, 17);
			this.rbMinus.TabIndex = 11;
			this.rbMinus.Tag = "1";
			this.rbMinus.Text = "-";
			this.rbMinus.UseVisualStyleBackColor = true;
			// 
			// groupBoxCal
			// 
			this.groupBoxCal.Controls.Add(this.labelInfo);
			this.groupBoxCal.Controls.Add(this.label1);
			this.groupBoxCal.Controls.Add(this.buttonCalc);
			this.groupBoxCal.Controls.Add(this.labelResult);
			this.groupBoxCal.Controls.Add(this.numericRhs);
			this.groupBoxCal.Controls.Add(this.numericLhs);
			this.groupBoxCal.Controls.Add(this.rbMultipy);
			this.groupBoxCal.Controls.Add(this.rbDivied);
			this.groupBoxCal.Controls.Add(this.rbPlus);
			this.groupBoxCal.Controls.Add(this.rbMinus);
			this.groupBoxCal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCal.Location = new System.Drawing.Point(0, 0);
			this.groupBoxCal.MinimumSize = new System.Drawing.Size(484, 89);
			this.groupBoxCal.Name = "groupBoxCal";
			this.groupBoxCal.Size = new System.Drawing.Size(497, 89);
			this.groupBoxCal.TabIndex = 12;
			this.groupBoxCal.TabStop = false;
			this.groupBoxCal.Text = "Calculator";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(401, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "=";
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResult.Location = new System.Drawing.Point(420, 23);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(32, 13);
			this.labelResult.TabIndex = 13;
			this.labelResult.Text = "0.00";
			// 
			// numericRhs
			// 
			this.numericRhs.Location = new System.Drawing.Point(275, 19);
			this.numericRhs.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericRhs.Name = "numericRhs";
			this.numericRhs.Size = new System.Drawing.Size(120, 20);
			this.numericRhs.TabIndex = 12;
			this.numericRhs.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Location = new System.Drawing.Point(12, 59);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(0, 13);
			this.labelInfo.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 89);
			this.Controls.Add(this.groupBoxCal);
			this.MinimumSize = new System.Drawing.Size(513, 128);
			this.Name = "MainForm";
			this.Text = "TXSuite";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericLhs)).EndInit();
			this.groupBoxCal.ResumeLayout(false);
			this.groupBoxCal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRhs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.NumericUpDown numericLhs;
		private System.Windows.Forms.RadioButton rbPlus;
		private System.Windows.Forms.RadioButton rbDivied;
		private System.Windows.Forms.RadioButton rbMultipy;
		private System.Windows.Forms.RadioButton rbMinus;
		private System.Windows.Forms.GroupBox groupBoxCal;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.NumericUpDown numericRhs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelInfo;
	}
}

