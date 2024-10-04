using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExample2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//private string msg2 = "";
		public MainWindow()
		{
			InitializeComponent();
			//msg2 += $"[I am in Main Window ctor @{DateTime.Now.ToString("T")}] {Environment.NewLine}";
		}

		private void WpfWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		//Brushes
		private void btnSolidColor_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmSolid.Show();
		}

		private void btnLinearGradient_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmLinearGradient.Show();
		}

		private void btnRadialGradient_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmRadialGradient.Show();
		}

		private void btnImage_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmImage.Show();
		}

		private void btnVisual_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmVisual.Show();
		}

		//Main window Closed event
		private void WpfWindow_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

		//Panels
		private void btnStack_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmStack.Show();
		}

		private void btnWrap_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmWrap.Show();
		}

		private void btnCanvas_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmCanvas.Show();
		}

		private void btnGrid_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmGrid.Show();
		}

		private void btnDock_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmDock.Show();
		}

		private void btnEditorWindow_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.frmEditor.Show();
		}
	}
}
