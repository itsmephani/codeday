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
		}

		private static void PropertyChange_Handler(Object sender, PropertyChangedEventArgs e)
		{
			Console.WriteLine(sender.GetType().GetProperty(e.PropertyName).GetValue(sender));
		}
  }
}
