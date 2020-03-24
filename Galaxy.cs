using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class Galaxy
  {
    private static string _galaxyName;

    public Galaxy(string galaxyName)
    {
      _galaxyName = galaxyName;
    }

    public string GetName()
    {
      //string message = $"{_galaxyName}";
      return _galaxyName;
    }


    public SolarSystem[] MakeChildren(int amt)
    {
      var solarSystems = new List<SolarSystem>();

      for (int i = 0; i < amt; i++)
      {
        Random random = new Random();
        int rand = random.Next();
        string randomNumberString = rand.ToString();

        solarSystems.Add(new SolarSystem(randomNumberString));
      }

      return solarSystems.ToArray();
    }

  }
}