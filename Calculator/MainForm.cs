using System;
using System.Windows.Forms;

namespace Calculator
{
	internal partial class MainForm : Form
	{
		private bool isFirstNumber = true;
		private bool isKeyboardOperation = true;
		private bool isRightOperand = false;
		private bool newOperation = false;
		private int operandLeft;
		private int operandRight;
		private int result;

		public MainForm()
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
			ResultOperation();
		}

		private void ButonCE_Click(object sender, EventArgs e)
		{
			Reset();
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
				if (!isRightOperand)
				{
					if (newOperation)
					{
						displayCalculator.Text = item;
						newOperation = false;
						isKeyboardOperation = true;
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
			isRightOperand = true;
			isFirstNumber = true;
		}

		private void MaineForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.D0:
					InsertNember("0");
					break;
				case Keys.D1:
					InsertNember("1");
					break;
				case Keys.D2:
					InsertNember("2");
					break;
				case Keys.D3:
					InsertNember("3");
					break;
				case Keys.D4:
					InsertNember("4");
					break;
				case Keys.D5:
					InsertNember("5");
					break;
				case Keys.D6:
					InsertNember("6");
					break;
				case Keys.D7:
					InsertNember("7");
					break;
				case Keys.D8:
					if (e.Shift && isKeyboardOperation)
					{
						ArithmeticOperation("*");
						isKeyboardOperation = false;
					}
					else
					{
						InsertNember("8");
					}
					break;
				case Keys.D9:
					InsertNember("9");
					break;
				case Keys.OemMinus:
					if (isKeyboardOperation)
					{
						ArithmeticOperation("-");
						isKeyboardOperation = false;
					}
					break;
				case Keys.Oemplus:
					if (e.Shift && isRightOperand)
					{
						ResultOperation();
					}
					else if (!e.Shift && isKeyboardOperation)
					{
						ArithmeticOperation("+");
						isKeyboardOperation = false;
					}
					break;
				case Keys.OemQuestion:
					if (isKeyboardOperation)
					{
						ArithmeticOperation("/");
						isKeyboardOperation = false;
					}
					break;
				case Keys.Back:
					Reset();
					break;
			}
		}

		private void Reset()
		{
			displayCalculator.Text = "";
			OffArithmeticOperations();
			isFirstNumber = true;
		}

		private void ResultOperation()
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
			isRightOperand = false;
			isFirstNumber = true;
			newOperation = true;
			OffArithmeticOperations();
		}
	}
}