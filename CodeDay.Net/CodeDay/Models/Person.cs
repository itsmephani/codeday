using System;
using System.ComponentModel;

namespace CodeDay.Models
{
  class Person : INotifyPropertyChanged
  {
		private int age;
		public string Name;
		public int Age {
			get { return age; }
			set {
				age = value;
				NotifyPropertyChanged(nameof(Age));
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public Person(string name, int age)
    {
			Name = name;
			Age = age;
    }

		private void NotifyPropertyChanged(string property) 
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
	}
}
