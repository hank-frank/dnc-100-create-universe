using System;

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

      string message = universe.UniName();
      Console.WriteLine(message);
      Console.WriteLine($"random from galaxy: {universe.MakeGalaxy()}");
      Console.WriteLine("press any key to finish");
      Console.ReadKey();
    }
  }
}
