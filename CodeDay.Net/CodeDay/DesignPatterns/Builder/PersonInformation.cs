using CodeDay.Models;

namespace CodeDay.DesignPatterns.Builder
{
  public class PersonInformation
  {
    public Person Person;
    public Address Address;

    public PersonInformation(PersonInformation.Builder personInformationBuilder)
    {
      Person = new Person(personInformationBuilder.GetPerson().GetName(),
         personInformationBuilder.GetPerson().GetAge());

      Address = new Address {
        FlatNo =  personInformationBuilder.GetAddress().GetFlatNo(),
        Lane =  personInformationBuilder.GetAddress().GetLane(),
        Landmark = personInformationBuilder.GetAddress().GetLandmark()
      };
    }

    public class Builder
    {
      private Person.Builder person;
      private Address.Builder address;

      public Person.Builder GetPerson()
      {
        return person;
      }

      public Address.Builder GetAddress()
      {
        return address;
      }
    }
  }
}
