using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCounterApp
{
	public class CounterViewMode : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
		private Counter _newCounter = null;
		public Counter NewCounter
		{
			get => _newCounter;
			set { _newCounter = value; OnPropertyChanged(nameof(NewCounter)); }
		}

		//private Counter _newMinus = null;
		//public Counter NewMinus
		//{
		//    get => _newMinus;
		//    set { _newMinus = value; OnPropertyChanged(nameof(NewMinus)); }
		//}

		public ICommand PlusCommand { get; }
		public ICommand MinusCommand { get; }

		public CounterViewMode()
		{
			this.NewCounter = new Counter { Number = 0 };
			//this.NewMinus = new Counter { Number = 0 };

			PlusCommand = new RelayCommand(Plus);
			MinusCommand = new RelayCommand(Minus);


		}
		//private int Count = 0;

		public void Plus()
		{
			NewCounter.Number++;
			OnPropertyChanged(nameof(NewCounter));
		}

		public void Minus()
		{
			NewCounter.Number--;
			OnPropertyChanged(nameof(NewCounter));
		}
	}
}
