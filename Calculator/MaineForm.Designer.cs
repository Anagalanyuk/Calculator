namespace Calculator
{
	partial class MaineForm
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
			this.displayNumber = new System.Windows.Forms.Label();
			this.displayCalculator = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.butonCE = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonResult = new System.Windows.Forms.Button();
			this.buttonMultiply = new System.Windows.Forms.Button();
			this.buttonMinus = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// displayNumber
			// 
			this.displayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayNumber.Location = new System.Drawing.Point(27, 9);
			this.displayNumber.Name = "displayNumber";
			this.displayNumber.Size = new System.Drawing.Size(418, 30);
			this.displayNumber.TabIndex = 0;
			this.displayNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// displayCalculator
			// 
			this.displayCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayCalculator.BackColor = System.Drawing.SystemColors.Window;
			this.displayCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayCalculator.ForeColor = System.Drawing.SystemColors.WindowText;
			this.displayCalculator.Location = new System.Drawing.Point(27, 39);
			this.displayCalculator.Name = "displayCalculator";
			this.displayCalculator.ReadOnly = true;
			this.displayCalculator.Size = new System.Drawing.Size(418, 38);
			this.displayCalculator.TabIndex = 1;
			this.displayCalculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(27, 83);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(100, 40);
			this.button7.TabIndex = 2;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(27, 129);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 40);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(27, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// butonCE
			// 
			this.butonCE.Location = new System.Drawing.Point(27, 221);
			this.butonCE.Name = "butonCE";
			this.butonCE.Size = new System.Drawing.Size(100, 40);
			this.butonCE.TabIndex = 5;
			this.butonCE.Text = "CE";
			this.butonCE.UseVisualStyleBackColor = true;
			this.butonCE.Click += new System.EventHandler(this.ButonCE_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(133, 83);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(100, 40);
			this.button8.TabIndex = 6;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(133, 129);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 40);
			this.button5.TabIndex = 7;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(133, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 40);
			this.button2.TabIndex = 8;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(133, 222);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(100, 40);
			this.button0.TabIndex = 9;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button0_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(239, 83);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(100, 40);
			this.button9.TabIndex = 10;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(239, 129);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 40);
			this.button6.TabIndex = 11;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(239, 175);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 40);
			this.button3.TabIndex = 12;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// buttonResult
			// 
			this.buttonResult.Location = new System.Drawing.Point(239, 222);
			this.buttonResult.Name = "buttonResult";
			this.buttonResult.Size = new System.Drawing.Size(100, 40);
			this.buttonResult.TabIndex = 13;
			this.buttonResult.Text = "=";
			this.buttonResult.UseVisualStyleBackColor = true;
			this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
			// 
			// buttonMultiply
			// 
			this.buttonMultiply.Location = new System.Drawing.Point(345, 129);
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.Size = new System.Drawing.Size(100, 40);
			this.buttonMultiply.TabIndex = 15;
			this.buttonMultiply.Text = "*";
			this.buttonMultiply.UseVisualStyleBackColor = true;
			this.buttonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
			// 
			// buttonMinus
			// 
			this.buttonMinus.Location = new System.Drawing.Point(345, 175);
			this.buttonMinus.Name = "buttonMinus";
			this.buttonMinus.Size = new System.Drawing.Size(100, 40);
			this.buttonMinus.TabIndex = 16;
			this.buttonMinus.Text = "-";
			this.buttonMinus.UseVisualStyleBackColor = true;
			this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
			// 
			// buttonDivide
			// 
			this.buttonDivide.Location = new System.Drawing.Point(345, 83);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(100, 40);
			this.buttonDivide.TabIndex = 14;
			this.buttonDivide.Text = "/";
			this.buttonDivide.UseVisualStyleBackColor = true;
			this.buttonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
			// 
			// buttonPlus
			// 
			this.buttonPlus.Location = new System.Drawing.Point(345, 221);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(100, 40);
			this.buttonPlus.TabIndex = 17;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
			// 
			// MaineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 279);
			this.Controls.Add(this.buttonPlus);
			this.Controls.Add(this.buttonMinus);
			this.Controls.Add(this.buttonMultiply);
			this.Controls.Add(this.buttonDivide);
			this.Controls.Add(this.buttonResult);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.butonCE);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.displayCalculator);
			this.Controls.Add(this.displayNumber);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MaineForm";
			this.Text = "Calculator";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaineForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label displayNumber;
		private System.Windows.Forms.TextBox displayCalculator;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button butonCE;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonResult;
		private System.Windows.Forms.Button buttonMultiply;
		private System.Windows.Forms.Button buttonMinus;
		private System.Windows.Forms.Button buttonDivide;
		private System.Windows.Forms.Button buttonPlus;
	}
}

