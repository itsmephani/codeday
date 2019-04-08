using System;
using System.ComponentModel;
using CodeDay.Models;

namespace CodeDay
{
  class Program
  {
    static void Main(string[] args)
    {
			Console.WriteLine("Learning .Net");

			Person person = new Person("Phani", 27);
			Console.WriteLine(person.Age);
			person.PropertyChanged += PropertyChange_Handler;

			person.Age = 28;

      People people = new People();
      people.Add(person);
      people.Add(new Person("Sai", 20));

      foreach (Person p in people)
      {
        Console.WriteLine(p.Name + p.Age);
      }

      Console.ReadLine();
		}

		private static void PropertyChange_Handler(Object sender, PropertyChangedEventArgs e)
		{
			Console.WriteLine(sender.GetType().GetProperty(e.PropertyName).GetValue(sender));
		}
  }
}
