using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class Planet
  {
    private static string _planetName;

    public Planet(string planetName)
    {
      _planetName = planetName;
    }

    public string GetName()
    {
      return _planetName;
    }

    public LifeForm[] MakeLifeForms(int amt)
    {
      var lifeForms = new List<LifeForm>();

      for (int i = 0; i < amt; i++)
      {
        Random random = new Random();
        int rand = random.Next();
        string randomNumberString = rand.ToString();
        string last = "Goaterson";

        LifeForm goat = new LifeForm(randomNumberString, last);
        lifeForms.Add(goat);
      }

      return lifeForms.ToArray();
    }
  }
}