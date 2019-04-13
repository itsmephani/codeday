using System.ComponentModel;

namespace CodeDay.Models
{
  public class Person : INotifyPropertyChanged
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

		// Need for INotifyPropertyChanged.
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

    public class Builder
    {
      Person person;
      string name;
      int age;

      public Builder SetName(string name)
      {
        this.name = name;

        return this;
      }

      public Builder SetAge(int age)
      {
        this.age = age;

        return this;
      }

      public string GetName()
      {
        return name;
      }

      public int GetAge()
      {
        return age;
      }

      public Person Build()
      {
        return new Person(name, age);
      }
    }
	}
}
