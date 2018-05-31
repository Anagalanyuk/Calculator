using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MaineForm : Form
	{
		private bool isFirstNumber = true;
		private bool isRightOprand = false;
		private bool newOperation = false;
		private int operandLeft;
		private int operandRight;
		private int result;

		public MaineForm()
		{
			InitializeComponent();
			OffArithmeticOperations();
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			InsertNember("0");
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			InsertNember("1");
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			InsertNember("2");
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			InsertNember("3");
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			InsertNember("4");
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			InsertNember("5");
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			InsertNember("6");
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			InsertNember("7");
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			InsertNember("8");
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			InsertNember("9");
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			ArithmeticOperation("+");
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			ArithmeticOperation("-");
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			ArithmeticOperation("*");
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			ArithmeticOperation("/");
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

		private void InsertNember(string item)
		{
			if (displayCalculator.Text == "0")
			{
				displayCalculator.Text = item;
			}
			else
			{
				if (!isRightOprand)
				{
					if (newOperation)
					{
						displayCalculator.Text = item;
						newOperation = false;
					}
					else
					{
						displayCalculator.Text += item;
					}
					OnArithmeticOperations();
					buttonResult.Enabled = false;
				}
				else
				{
					if (isFirstNumber)
					{
						buttonResult.Enabled = true;
						displayCalculator.Text = item;
						isFirstNumber = false;
					}
					else
					{
						displayCalculator.Text += item;
					}
				}
			}
		}

		private void ArithmeticOperation(string item)
		{
			displayNumber.Text = displayCalculator.Text;
			displayNumber.Text += $" {item}";
			OffArithmeticOperations();
			operandLeft = int.Parse(displayCalculator.Text);
			isRightOprand = true;
			isFirstNumber = true;
		}

		private void button1_KeyDown(object sender, KeyEventArgs e)
		{
			InsertNember("1");
		}
	}
}