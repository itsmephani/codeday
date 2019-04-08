using System;
using System.Collections;

namespace CodeDay.Models
{
  class PeopleEnumerator : IEnumerator
  {
    private int currentIndex = -1;
    private People people;

    public PeopleEnumerator(People people)
    {
      this.people = people;
    }

    public object Current => people[currentIndex];

    public bool MoveNext()
    {
      return ++currentIndex < people.Count();
    }

    public void Reset()
    {
      throw new NotImplementedException();
    }
  }
}
