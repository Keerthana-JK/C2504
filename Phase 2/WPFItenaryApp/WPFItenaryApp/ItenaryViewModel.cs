using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace WPFItenaryApp
{
	public delegate void DWindowClose();
	public class ItenaryViewModel : INotifyPropertyChanged
	{
		public DWindowClose NewWindowClose;
		public DWindowClose EditWindowClose;
		//
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
		//        
		private Itenary _newItenary = null;
		public Itenary NewItenary
		{
			get => _newItenary;
			set { _newItenary = value; OnPropertyChanged(nameof(NewItenary)); }
		}
		//
		private Itenary _selectedItenary = null;
		public Itenary SelectedItenary
		{
			get => _selectedItenary;
			set { _selectedItenary = value; OnPropertyChanged(nameof(SelectedItenary)); }
		}
		//
		private ObservableCollection<Itenary> _Itenaries = null;
		public ObservableCollection<Itenary> Itenaries
		{
			get => _Itenaries;
			set { _Itenaries = value; OnPropertyChanged(nameof(Itenaries)); }
		}
		//
		public ICommand CreateCommand { get; }
		public ICommand UpdateCommand { get; }
		public ICommand DeleteCommand { get; }
		//
		public ItenaryViewModel()
		{
			this.NewItenary = new Itenary { ID = 0, Time = "01:00am", ItenaryName = "z", Description = "z", Price = 1 };
			this.Itenaries = new ObservableCollection<Itenary>
			{
				new Itenary{ID=1,Time="09:00am",ItenaryName="a",Description="a",Price=10},
				new Itenary{ID=2,Time="11:00am",ItenaryName="b",Description="b",Price=20}
			};
			CreateCommand = new RelayCommand(Create);
			UpdateCommand = new RelayCommand(Update);
			DeleteCommand = new RelayCommand(Delete);
		}
		public void Create()
		{
			int id = 1;
			if (Itenaries.Count > 0)
			{
				id = Itenaries[Itenaries.Count - 1].ID + 1;
			}
			Itenary newIternary = new Itenary
			{
				ID = id,
				Time = NewItenary.Time,
				ItenaryName = NewItenary.ItenaryName,
				Description = NewItenary.Description,
				Price = NewItenary.Price
			};
			var result = MessageBox.Show(messageBoxText: "Are you sure to create?",
					caption: "Confirm",
					button: MessageBoxButton.YesNo,
					icon: MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes)
			{
				return;
			}
			Itenaries.Add(newIternary);
			this.NewItenary = new Itenary { ID = 0, Time = "01:00am", ItenaryName = "z", Description = "z", Price = 1 };
			//this.NewItenary.Id = 0;
			//..
			//this.NewItenary = NewItenary;
			result = MessageBox.Show(messageBoxText: "Created Successfully",
					caption: "Alert",
					button: MessageBoxButton.OK,
					icon: MessageBoxImage.Information);
			if (NewWindowClose != null)
			{
				NewWindowClose();
			}

		}
		public void Update()
		{
			if (this.SelectedItenary == null)
			{
				return;
			}
			this.SelectedItenary = this.SelectedItenary;
			var result = MessageBox.Show(messageBoxText: "Updated Successfully",
					caption: "Alert",
					button: MessageBoxButton.OK,
					icon: MessageBoxImage.Information);
			if (EditWindowClose != null)
			{
				EditWindowClose();
			}
		}
		public void Delete()
		{
			//var result = MessageBox.Show(messageBoxText: "Pick one to delete",
			//		caption: "Alert",
			//		button: MessageBoxButton.OK,
			//		icon: MessageBoxImage.Information);
			if (this.SelectedItenary == null)
			{
				return;
			}
			this.Itenaries.Remove(this.SelectedItenary);
			this.SelectedItenary = null;
		}
	}
}
