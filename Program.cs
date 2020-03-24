using System;
using System.Collections.Generic;

namespace dnc100_csharp_universe
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Universe!");

      Console.WriteLine($"What do you want your New Universe to be called?");
      string universeName = Console.ReadLine();
      Universe universe = new Universe(universeName);

      string universeMessage = universe.GetName();
      Console.WriteLine(universeMessage);

      Console.WriteLine($"How Many Galaxies should {universeName} have?");
      int numberOfGalaxies = Int32.Parse(Console.ReadLine());

      Console.WriteLine($"How Many Solar Systems should each Galaxy have?");
      int numberOfSolarSystems = Int32.Parse(Console.ReadLine());

      Console.WriteLine($"How Many Planets should each Soalr System have?");
      int numberOfPlanets = Int32.Parse(Console.ReadLine());

      Console.WriteLine($"How Many Goats should each Planet have?");
      int numberOfLifeForms = Int32.Parse(Console.ReadLine());


      Galaxy[] galaxies = universe.MakeChildren(numberOfGalaxies);

      foreach (Galaxy eachGalaxy in galaxies)
      {
        Console.WriteLine($"Behold, the following galaxy has been birthed, {eachGalaxy.GetName()}");

        SolarSystem[] solarSystems = eachGalaxy.MakeChildren(numberOfSolarSystems);

        foreach (SolarSystem eachSolarSystem in solarSystems)
        {
          string solarSystemName = eachSolarSystem.GetName();
          Console.WriteLine($"Behold, the following Solar System has been birthed, {solarSystemName}");

          Star star = eachSolarSystem.MakeStar();
          string starName = star.GetName();
          Console.WriteLine($"Solar System {solarSystemName} has the Star {starName}");

          Planet[] planets = eachSolarSystem.MakePlanet(numberOfPlanets);

          foreach (Planet eachPlanet in planets)
          {
            string planetName = eachPlanet.GetName();
            Console.WriteLine($"Also it has this Planet: {planetName}");

            LifeForm[] lifeForms = eachPlanet.MakeLifeForms(numberOfLifeForms);

            foreach (LifeForm life in lifeForms)
            {
              Console.WriteLine($"On this goat Planet {planetName} lives this Goat: {life.GetName()}");
            }

          }
        }




      }


      Console.WriteLine("press any key to finish");
      Console.ReadKey();
    }
  }
}
