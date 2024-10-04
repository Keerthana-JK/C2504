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

namespace WpfExample2
{
	/// <summary>
	/// Interaction logic for SolidColor.xaml
	/// </summary>
	public partial class SolidColor : Window
	{
		public SolidColor()
		{
			InitializeComponent();
		}

		private void SolidColorBrush_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel=true;
			this.Hide();
        }
    }
}
