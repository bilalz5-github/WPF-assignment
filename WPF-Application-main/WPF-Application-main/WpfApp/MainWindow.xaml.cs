using System;
using System.Windows;

namespace WpfApp1
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			PerformOperation("+");
		}

		private void SubtractButton_Click(object sender, RoutedEventArgs e)
		{
			PerformOperation("-");
		}

		private void MultiplyButton_Click(object sender, RoutedEventArgs e)
		{
			PerformOperation("*");
		}

		private void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			PerformOperation("/");
		}

		private void PerformOperation(string operation)
		{
			double num1, num2;
			if (!double.TryParse(textBox1.Text, out num1) || !double.TryParse(textBox2.Text, out num2))
			{
				resultTextBlock.Background = System.Windows.Media.Brushes.Red;
				resultTextBlock.Text = "Error: Invalid input";
				return;
			}

			switch (operation)
			{
				case "+":
					resultTextBlock.Text = (num1 + num2).ToString();
					break;
				case "-":
					resultTextBlock.Text = (num1 - num2).ToString();
					break;
				case "*":
					resultTextBlock.Text = (num1 * num2).ToString();
					break;
				case "/":
					if (num2 == 0)
					{
						resultTextBlock.Background = System.Windows.Media.Brushes.Red;
						resultTextBlock.Text = "Error: Divide by zero";
					}
					else
					{
						resultTextBlock.Text = (num1 / num2).ToString();
					}
					break;
			}
		}
	}
}
