using CodeDay.DesignPatterns.Builder;
using CodeDay.Models;

namespace CodeDay.DesignPatterns
{
  class Runner
  {
    public static void Run()
    {
      PersonInformation.Builder personInformationBuilder = new PersonInformation.Builder();

      Person.Builder personBuilder = new Person.Builder();
      Person person = personBuilder.SetAge(28).SetName("Name").Build();


      Address.Builder address = new Address.Builder();
      address.SetFlatNo("2").SetLane("Lane").SetLandmark("Landmark");

      personInformationBuilder
        .SetPerson(personBuilder)
        .SetAddress(address)
        .Build();

      personInformationBuilder.GetPerson().GetAge();
    }
  }
}
