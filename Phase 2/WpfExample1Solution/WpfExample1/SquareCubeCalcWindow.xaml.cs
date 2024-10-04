using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfExample1
{
	/// <summary>
	/// Interaction logic for SquareCubeCalcWindow.xaml
	/// </summary>
	public partial class SquareCubeCalcWindow : Window
	{
		public SquareCubeCalcWindow()
		{
			InitializeComponent();
		}
		private bool IsNum(string numStr)
		{
			try
			{
				int.Parse(numStr);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void btnFindSquare_Click(object sender, RoutedEventArgs e)
		{

			if (!IsNum(txtNumber.Text))
			{
				MessageBox.Show("Please enter only number");
				txtNumber.Focus();
				txtNumber.SelectAll();

				return;
			}
			int num = int.Parse(txtNumber.Text);
			int square = num * num;
			txtResult.Text = square.ToString();
			lblResult.Text = "Square";
		}

		private void btnFindCube_Click(object sender, RoutedEventArgs e)
		{
			if (!IsNum(txtNumber.Text))
			{
				MessageBox.Show("Please enter only number");
				txtNumber.Focus();
				txtNumber.SelectAll();

				return;
			}
			int num = int.Parse(txtNumber.Text);
			int cube = num * num * num;
			txtResult.Text = cube.ToString();
			lblResult.Text = "Cube";


		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
