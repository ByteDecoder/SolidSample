using System;
using ArdalisRating.Core.Interfaces;

namespace ArdalisRating.Infrastructure.Loggers
{
  public class ConsoleLogger : ILogger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
}