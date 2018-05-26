using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MineForm : Form
	{
		private int operandLeft;
		private int operandRight;
		private bool isRightOprand = false;

		public MineForm()
		{
			InitializeComponent();
			OffArithmeticOperations();
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			displayCalculator.Text += "0";
			OnArithmeticOperations();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "1";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "1";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "1";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "2";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "2";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "2";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "3";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "3";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "3";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "4";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "4";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "4";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "5";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "5";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "5";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "6";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "6";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "6";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "7";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "7";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "7";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "8";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "8";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "8";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "9";
			}
			else
			{
				if (!isRightOprand)
				{
					displayCalculator.Text += "9";
					OnArithmeticOperations();
				}
				else
				{
					displayCalculator.Text = "9";
					OnArithmeticOperations();
					ButtonResult.Enabled = true;
					isRightOprand = false;
				}
			}
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " +";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
			isRightOprand = true;
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
			operandRight = int.Parse(displayCalculator.Text);
			int result = operandLeft + operandRight;
			displayNumber.Text = "";
			displayCalculator.Text = result.ToString();
			isRightOprand = true;
		}

		private void ButonCE_Click(object sender, EventArgs e)
		{
			displayCalculator.Text = "";
			OffArithmeticOperations();
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
		}
	}
}