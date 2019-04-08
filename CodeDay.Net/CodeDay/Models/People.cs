using System.Collections;
using System.Collections.Generic;

namespace CodeDay.Models
{
  class People : IEnumerable
  {
    List<Person> list = new List<Person>();

    public void Add(Person person)
    {
      list.Add(person);
    }

    public IEnumerator GetEnumerator()
    {
      return new PeopleEnumerator(this);
    }

    public Person this[int index]
    {
      get { return list[index]; }
    }

    public int Count()
    {
      return list.Count;
    }
  }
}
