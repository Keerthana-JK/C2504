using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFItenaryApp
{
	public static class ItenaryConfig
	{
		//forms 
		public static Window FrmNewItenary { get; set; }

		public static Window FrmEditItenary { get; set; }
		//view model
		public static ItenaryViewModel ViewModel { get; set; }

		static ItenaryConfig()
		{
			ViewModel = new ItenaryViewModel();
			FrmNewItenary = new NewItenaryWindow();
			FrmEditItenary = new EditItenaryWindow();

		}
	}
}
