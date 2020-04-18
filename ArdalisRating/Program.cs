﻿using System;
using ArdalisRating.Core;
using ArdalisRating.Infrastructure.Loggers;

namespace ArdalisRating
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ardalis Insurance Rating System Starting...");

      var engine = new RatingEngine(new ConsoleLogger());
      engine.Rate();

      if (engine.Rating > 0)
      {
        Console.WriteLine($"Rating: {engine.Rating}");
      }
      else
      {
        Console.WriteLine("No rating produced.");
      }

    }
  }
}
