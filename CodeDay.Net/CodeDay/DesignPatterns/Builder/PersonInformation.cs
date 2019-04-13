using CodeDay.Models;

namespace CodeDay.DesignPatterns.Builder
{
  public class PersonInformation
  {
    public Person Person;
    public Address Address;

    public PersonInformation()
    {
      
    }

    public class Builder
    {
      private Person.Builder personBuilder;
      private Address.Builder addressBuilder;

      public Person.Builder GetPerson()
      {
        return personBuilder;
      }

      public Address.Builder GetAddress()
      {
        return addressBuilder;
      }

      public Builder SetPerson(Person.Builder p)
      {
         personBuilder = p;

         return this;
      }

      public Builder SetAddress(Address.Builder a)
      {
        addressBuilder = a;

        return this;
      }

      public PersonInformation Build()
      {
        return new PersonInformation {
          Person = new Person(GetPerson().GetName(),
           GetPerson().GetAge()),
          Address = new Address
          {
            FlatNo = GetAddress().GetFlatNo(),
            Lane = GetAddress().GetLane(),
            Landmark = GetAddress().GetLandmark()
          }
        };
      }
    }
  }
}
