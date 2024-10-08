﻿using System;
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

namespace FullNameAppWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class DisplayPersonApp : Window
	{
		public DisplayPersonApp()
		{
			InitializeComponent();
			this.DataContext = PersonConfig.PersonViewModel;
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			PersonConfig.PersonViewModel.EditClose = PersonConfig.FrmEditFullName.WindowClose;
			PersonConfig.PersonViewModel.Edit(); // copies DisplayPerson to EditablePerson
			PersonConfig.FrmEditFullName.Show();
		}
	}
}
