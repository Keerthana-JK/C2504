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
	/// Interaction logic for MenuWindow.xaml
	/// </summary>
	public partial class MenuWindow : Window
	{
		public MenuWindow()
		{
			InitializeComponent();
		}
		private MainWindow mainWindow = new MainWindow();
		private SumCalcWindow sumCalcWindow = new SumCalcWindow();
		private SquareCubeCalcWindow squareCubeCalcWindow=new SquareCubeCalcWindow();
		private void btnCounter_Click(object sender, RoutedEventArgs e)
		{
			mainWindow.Show();
			mainWindow.Activate();
		}

		private void btnSumCalc_Click(object sender, RoutedEventArgs e)
		{
			sumCalcWindow.Show();
			sumCalcWindow.Activate();
		}

		private void btnSquareCube_Click(object sender, RoutedEventArgs e)
		{
			squareCubeCalcWindow.Show();
			squareCubeCalcWindow.Activate();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
