using System;

namespace dnc100_csharp_universe
{
  class Galaxy
  {
    private static object _galaxyName;

    public Galaxy(string galaxyName)
    {
      _galaxyName = galaxyName;
    }

    public string GalaxyName()
    {
      string message = $"Behold, the Galaxy {_galaxyName} has been birthed from your fertile loins!";
      return message;
    }

    }
}