using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FullNameAppWPF
{
	public class PersonViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		//public DClose EditWindowClose;
		private void OnPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}

		private Person _editablePerson = null;
		public Person EditablePerson
		{
			get => _editablePerson;
			set { _editablePerson = value; OnPropertyChanged(nameof(EditablePerson)); }
		}
		//
		private Person _displayPerson = null;
		public Person DisplayPerson
		{
			get => _displayPerson;
			set { _displayPerson = value; OnPropertyChanged(nameof(DisplayPerson)); }
		}

		public ICommand UpdateCommand { get; }
		public PersonViewModel()
		{
			DisplayPerson = new Person { FirstName = "Keerthana", LastName = "JK" };
			EditablePerson = new Person { FirstName = "", LastName = "" };

			UpdateCommand = new RelayCommand(Update);
		}
		public void Update()
		{
			var result = MessageBox.Show(messageBoxText: "Are you sure to Update",
			caption: "Confirm",
			button: MessageBoxButton.YesNo,
			icon: MessageBoxImage.Question);

			if (result != MessageBoxResult.Yes)
			{
				return;
			}

			DisplayPerson.FirstName = EditablePerson.FirstName;
			DisplayPerson.LastName = EditablePerson.LastName;
			DisplayPerson = DisplayPerson;
			
			result = MessageBox.Show(messageBoxText: "Updated Successfully",
					caption: "Alert",
					button: MessageBoxButton.OK,
					icon: MessageBoxImage.Information);
			if (EditClose != null)
			{
				EditClose();
			}
		}
		public DClose EditClose;
		public void Edit()
		{
			EditablePerson.FirstName = DisplayPerson.FirstName;
			EditablePerson.LastName = DisplayPerson.LastName;
			EditablePerson = EditablePerson;

		}

	}
}
