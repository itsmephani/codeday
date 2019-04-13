using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using CodeDay.PersonApi;
using CodeDay.Models;

namespace CodeDay
{
  class Program
  {
    static async Task Main(string[] args)
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

      string user = await PersonService.GetPerson();

      Console.WriteLine($"{user}");


      Console.ReadLine();

	    // ref and out both take pass by reference.
	    // ref is two way where as out will only assign back value 
	    // to the passed reference but can't be used as input.
		}

		private static void PropertyChange_Handler(Object sender, PropertyChangedEventArgs e)
		{
			Console.WriteLine(sender.GetType().GetProperty(e.PropertyName).GetValue(sender));
		}
  }
}
