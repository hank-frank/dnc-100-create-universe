using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class LifeForm
  {
    private static string _firstName;
    private static string _lastName;

    public LifeForm(string firstName, string lastName)
    {
      _firstName = firstName;
      _lastName = lastName;
    }

    public string GetName()
    {
      return ($"{_firstName} {_lastName}");
    }
  }
}