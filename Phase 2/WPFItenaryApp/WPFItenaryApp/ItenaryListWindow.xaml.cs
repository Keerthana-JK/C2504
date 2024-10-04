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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFItenaryApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class ItenaryListWindow : Window
	{
		public ItenaryListWindow()
		{
			InitializeComponent();
			this.DataContext = ItenaryConfig.ViewModel;
		}
		private void btnNew_Click(object sender, RoutedEventArgs e)
		{
			ItenaryConfig.FrmNewItenary.Show();
			NewItenaryWindow newIternaryWindow = (NewItenaryWindow)ItenaryConfig.FrmNewItenary;
			ItenaryConfig.ViewModel.NewWindowClose = newIternaryWindow.WindowClose;
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			if (datagrid.SelectedIndex == -1)
			{
				var result = MessageBox.Show(messageBoxText: "Please select itenary to edit",
					caption: "Alert",
					button: MessageBoxButton.OK,
					icon: MessageBoxImage.Information);
				return;
			}
			ItenaryConfig.FrmEditItenary.Show();
			EditItenaryWindow editIternaryWindow = (EditItenaryWindow)ItenaryConfig.FrmEditItenary;
			ItenaryConfig.ViewModel.EditWindowClose = editIternaryWindow.WindowClose;
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

	}
}
