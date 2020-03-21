using System;

namespace dnc100_csharp_universe
{
  class Universe
  {
    private static object _universeName;

    public Universe(string universeName)
    {
      _universeName = universeName;
    }

    public string UniName()
    {
      string message = $"Behold, the Universe {_universeName} has been birthed from your fertile loins!";
      return message;
    }

    public string MakeGalaxy()
    {
      Random random = new Random();
      int rand = random.Next();
      string randomNumberString = rand.ToString();

      Galaxy galaxy = new Galaxy(randomNumberString);

      string galaxyName = galaxy.GalaxyName();

      return $"Behold, the Galaxy {galaxyName} has no also been birthed from your fertile loins.";
    }

    }
}