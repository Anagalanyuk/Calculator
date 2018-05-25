using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MineForm : Form
	{
		private int operandLeft;
		private int operandRight;

		public MineForm()
		{
			InitializeComponent();
			OffArithmeticOperations();
			ButtonResult.Enabled = true;
		}

		private void displayNumber_Click(object sender, EventArgs e)
		{

		}

		private void DisplayCalculator(object sender, EventArgs e)
		{

		}

		private void Button0_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "0";
			OnArithmeticOperations();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "1";
			OnArithmeticOperations();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "2";
			OnArithmeticOperations();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "3";
			OnArithmeticOperations();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "4";
			OnArithmeticOperations();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "5";
			OnArithmeticOperations();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "6";
			OnArithmeticOperations();
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "7";
			OnArithmeticOperations();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "8";
			OnArithmeticOperations();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "9";
			OnArithmeticOperations();
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " +";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " -";
			OffArithmeticOperations();
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " *";
			OffArithmeticOperations();
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " /";
			OffArithmeticOperations();
		}

		private void ButtonResult_Click(object sender, EventArgs e)
		{
		}

		private void ButonCE_Click(object sender, EventArgs e)
		{
			displayCalculator.Text = "";
		}

		private void OffArithmeticOperations()
		{
			ButtonPlus.Enabled = false;
			ButtonMinus.Enabled = false;
			ButtonMultiply.Enabled = false;
			ButtonDivide.Enabled = false;
			ButtonResult.Enabled = false;
		}

		private void OnArithmeticOperations()
		{
			ButtonPlus.Enabled = true;
			ButtonMinus.Enabled = true;
			ButtonMultiply.Enabled = true;
			ButtonDivide.Enabled = true;
			ButtonResult.Enabled = true;
		}
	}
}