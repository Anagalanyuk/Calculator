using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MineForm : Form
	{
		private bool isFirstNumber = true;
		private bool isRightOprand = false;
		private bool newOperation = false;
		private int operandLeft;
		private int operandRight;
		private int result;

		public MineForm()
		{
			InitializeComponent();
			OffArithmeticOperations();
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = "0";
			}
			else
			{
				if (!isRightOprand)
				{
					if (newOperation)
					{
						displayCalculator.Text = "0";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "0";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "0";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "0";
					}
				}
			}
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
					if (newOperation)
					{
						displayCalculator.Text = "1";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "1";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "1";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "1";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "2";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "2";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "2";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "2";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "3";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "3";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "3";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "3";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "4";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "4";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "4";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "4";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "5";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "5";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "5";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "5";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "6";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "6";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "6";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "6";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "7";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "7";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "7";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "7";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "8";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "8";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "8";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "8";
					}
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
					if (newOperation)
					{
						displayCalculator.Text = "9";
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += "9";
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = "9";
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += "9";
					}
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
			isFirstNumber = true;
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " -";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
			isRightOprand = true;
			isFirstNumber = true;
			buttonResult.Enabled = true;
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " *";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
			isRightOprand = true;
			isFirstNumber = true;
			buttonResult.Enabled = true;
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += " /";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
			isRightOprand = true;
			isFirstNumber = true;
			buttonResult.Enabled = true;
		}

		private void ButtonResult_Click(object sender, EventArgs e)
		{
			operandRight = int.Parse(displayCalculator.Text);
			switch (displayNumber.Text[displayNumber.Text.Length - 1])
			{
				case '+':
					result = operandLeft + operandRight;
					break;
				case '_':
					result = operandLeft - operandRight;
					break;
				case '*':
					result = operandLeft * operandRight;
					break;
				case '/':
					result = operandLeft / operandRight;
					break;
			}
			displayNumber.Text = "";
			displayCalculator.Text = result.ToString();
			isRightOprand = false;
			isFirstNumber = true;
			newOperation = true;
			OffArithmeticOperations();
		}

		private void ButonCE_Click(object sender, EventArgs e)
		{
			displayCalculator.Text = "";
			OffArithmeticOperations();
			isFirstNumber = true;
		}

		private void OffArithmeticOperations()
		{
			buttonPlus.Enabled = false;
			buttonMinus.Enabled = false;
			buttonMultiply.Enabled = false;
			buttonDivide.Enabled = false;
			buttonResult.Enabled = false;
		}

		private void OnArithmeticOperations()
		{
			buttonPlus.Enabled = true;
			buttonMinus.Enabled = true;
			buttonMultiply.Enabled = true;
			buttonDivide.Enabled = true;
		}
	}
}