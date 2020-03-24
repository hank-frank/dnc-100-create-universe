using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class Star
  {
    private static string _starName;

    public Star(string starName)
    {
      _starName = starName;
    }

    public string GetName()
    {
      return _starName;
    }
  }
}