using CodeDay.DesignPatterns.Builder;
using CodeDay.Models;

namespace CodeDay.DesignPatterns
{
  class Runner
  {
    public static void Run()
    {
      PersonInformation personInformation = new PersonInformation();

      Person.Builder personBuilder = new Person.Builder();
      Person person = personBuilder.SetAge(28).SetName("Name").Build();


      Address.Builder address = new Address.Builder();
      address.SetFlatNo("2").SetLane("Lane").SetLandmark("Landmark");

      personInformation.SetPerson(personBuilder).SetAddress(address).buil;

      personInformation.GetPerson().GetAge();
    }
  }
}
