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
			this.buttonCalcOnPrem = new System.Windows.Forms.Button();
			this.groupBoxOnPrem = new System.Windows.Forms.GroupBox();
			this.labelOnPrem = new System.Windows.Forms.Label();
			this.numericLhs = new System.Windows.Forms.NumericUpDown();
			this.rbPlus = new System.Windows.Forms.RadioButton();
			this.rbDivied = new System.Windows.Forms.RadioButton();
			this.rbMultipy = new System.Windows.Forms.RadioButton();
			this.rbMinus = new System.Windows.Forms.RadioButton();
			this.groupBoxCal = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.numericRhs = new System.Windows.Forms.NumericUpDown();
			this.groupBoxCloud = new System.Windows.Forms.GroupBox();
			this.buttonCalcCloud = new System.Windows.Forms.Button();
			this.labelCloud = new System.Windows.Forms.Label();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.groupBoxOnPrem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLhs)).BeginInit();
			this.groupBoxCal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRhs)).BeginInit();
			this.groupBoxCloud.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCalcOnPrem
			// 
			this.buttonCalcOnPrem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCalcOnPrem.Location = new System.Drawing.Point(184, 105);
			this.buttonCalcOnPrem.Name = "buttonCalcOnPrem";
			this.buttonCalcOnPrem.Size = new System.Drawing.Size(75, 23);
			this.buttonCalcOnPrem.TabIndex = 0;
			this.buttonCalcOnPrem.Text = "Calc";
			this.buttonCalcOnPrem.UseVisualStyleBackColor = true;
			this.buttonCalcOnPrem.Click += new System.EventHandler(this.buttonCalcOnPrem_Click);
			// 
			// groupBoxOnPrem
			// 
			this.groupBoxOnPrem.Controls.Add(this.labelOnPrem);
			this.groupBoxOnPrem.Controls.Add(this.buttonCalcOnPrem);
			this.groupBoxOnPrem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOnPrem.Location = new System.Drawing.Point(0, 0);
			this.groupBoxOnPrem.Name = "groupBoxOnPrem";
			this.groupBoxOnPrem.Size = new System.Drawing.Size(265, 134);
			this.groupBoxOnPrem.TabIndex = 1;
			this.groupBoxOnPrem.TabStop = false;
			this.groupBoxOnPrem.Text = "OnPrem";
			// 
			// labelOnPrem
			// 
			this.labelOnPrem.AutoSize = true;
			this.labelOnPrem.Location = new System.Drawing.Point(6, 16);
			this.labelOnPrem.Name = "labelOnPrem";
			this.labelOnPrem.Size = new System.Drawing.Size(24, 13);
			this.labelOnPrem.TabIndex = 1;
			this.labelOnPrem.Text = "info";
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
			this.groupBoxCal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxCal.Controls.Add(this.label1);
			this.groupBoxCal.Controls.Add(this.labelResult);
			this.groupBoxCal.Controls.Add(this.numericRhs);
			this.groupBoxCal.Controls.Add(this.numericLhs);
			this.groupBoxCal.Controls.Add(this.rbMultipy);
			this.groupBoxCal.Controls.Add(this.rbDivied);
			this.groupBoxCal.Controls.Add(this.rbPlus);
			this.groupBoxCal.Controls.Add(this.rbMinus);
			this.groupBoxCal.Location = new System.Drawing.Point(12, 12);
			this.groupBoxCal.Name = "groupBoxCal";
			this.groupBoxCal.Size = new System.Drawing.Size(547, 54);
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
			this.labelResult.Size = new System.Drawing.Size(14, 13);
			this.labelResult.TabIndex = 13;
			this.labelResult.Text = "0";
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
			// groupBoxCloud
			// 
			this.groupBoxCloud.Controls.Add(this.buttonCalcCloud);
			this.groupBoxCloud.Controls.Add(this.labelCloud);
			this.groupBoxCloud.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCloud.Location = new System.Drawing.Point(0, 0);
			this.groupBoxCloud.Name = "groupBoxCloud";
			this.groupBoxCloud.Size = new System.Drawing.Size(278, 134);
			this.groupBoxCloud.TabIndex = 13;
			this.groupBoxCloud.TabStop = false;
			this.groupBoxCloud.Text = "Cloud";
			// 
			// buttonCalcCloud
			// 
			this.buttonCalcCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCalcCloud.Location = new System.Drawing.Point(197, 105);
			this.buttonCalcCloud.Name = "buttonCalcCloud";
			this.buttonCalcCloud.Size = new System.Drawing.Size(75, 23);
			this.buttonCalcCloud.TabIndex = 3;
			this.buttonCalcCloud.Text = "Calc";
			this.buttonCalcCloud.UseVisualStyleBackColor = true;
			this.buttonCalcCloud.Click += new System.EventHandler(this.buttonCalcCloud_Click);
			// 
			// labelCloud
			// 
			this.labelCloud.AutoSize = true;
			this.labelCloud.Location = new System.Drawing.Point(6, 16);
			this.labelCloud.Name = "labelCloud";
			this.labelCloud.Size = new System.Drawing.Size(24, 13);
			this.labelCloud.TabIndex = 2;
			this.labelCloud.Text = "info";
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(12, 72);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.groupBoxOnPrem);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.groupBoxCloud);
			this.splitContainer.Size = new System.Drawing.Size(547, 134);
			this.splitContainer.SplitterDistance = 265;
			this.splitContainer.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 218);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.groupBoxCal);
			this.Name = "MainForm";
			this.Text = "TXSuite";
			this.groupBoxOnPrem.ResumeLayout(false);
			this.groupBoxOnPrem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLhs)).EndInit();
			this.groupBoxCal.ResumeLayout(false);
			this.groupBoxCal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRhs)).EndInit();
			this.groupBoxCloud.ResumeLayout(false);
			this.groupBoxCloud.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCalcOnPrem;
		private System.Windows.Forms.GroupBox groupBoxOnPrem;
		private System.Windows.Forms.NumericUpDown numericLhs;
		private System.Windows.Forms.RadioButton rbPlus;
		private System.Windows.Forms.RadioButton rbDivied;
		private System.Windows.Forms.RadioButton rbMultipy;
		private System.Windows.Forms.RadioButton rbMinus;
		private System.Windows.Forms.GroupBox groupBoxCal;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.NumericUpDown numericRhs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelOnPrem;
		private System.Windows.Forms.GroupBox groupBoxCloud;
		private System.Windows.Forms.Button buttonCalcCloud;
		private System.Windows.Forms.Label labelCloud;
		private System.Windows.Forms.SplitContainer splitContainer;
	}
}

