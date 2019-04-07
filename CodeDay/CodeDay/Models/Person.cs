using System;
using System.ComponentModel;

namespace CodeDay.Models
{
  class Person : INotifyPropertyChanged
  {
    public Person()
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
