using System.Collections.Generic;
using ArdalisRating.Core.Interfaces;

namespace ArdalisRating.Tests
{
  public class FakeLogger : ILogger
  {
    public List<string> LoggedMessages { get; } = new List<string>();
    public void Log(string message)
    {
      LoggedMessages.Add(message);
    }
  }
}