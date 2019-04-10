﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using CodeDay.Github;
using CodeDay.Github.Models;
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

      List<Repo> repos = await GithubService.GetAllUserRepos("itsmephani");
      Console.WriteLine(repos.Count);
      foreach(Repo repo in repos)
      {
        Console.WriteLine($"{repo.Name} by {repo.UserName} in {repo.Language} language.");
      }

      Console.ReadLine();
		}

		private static void PropertyChange_Handler(Object sender, PropertyChangedEventArgs e)
		{
			Console.WriteLine(sender.GetType().GetProperty(e.PropertyName).GetValue(sender));
		}
  }
}
