using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullNameAppWPF
{
	public static class PersonConfig
	{
		//forms 
		public static EditFullNameWindow FrmEditFullName { get; set; }
		//view model
		public static PersonViewModel PersonViewModel { get; set; }

		static PersonConfig()
		{
			PersonViewModel = new PersonViewModel();
			FrmEditFullName = new EditFullNameWindow();

		}
	}
}
