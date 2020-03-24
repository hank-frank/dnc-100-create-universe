using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class Universe
  {
    private static string _universeName;

    public Universe(string universeName)
    {
      _universeName = universeName;
    }

    public string GetName()
    {
      string message = $"Behold, the Universe {_universeName} has been birthed from your fertile loins!";
      return message;
    }

    public Galaxy[] MakeChildren(int amt)
    {
      var galaxies = new List<Galaxy>();

      for (int i = 0; i < amt; i++)
      {
        Random random = new Random();
        int rand = random.Next();
        string randomNumberString = rand.ToString();

       galaxies.Add(new Galaxy(randomNumberString));
      }

      return galaxies.ToArray();
    }
 
  }
}