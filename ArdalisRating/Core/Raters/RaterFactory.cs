using System;
using ArdalisRating.Core.Interfaces;
using ArdalisRating.Core.Model;

namespace ArdalisRating.Core.Raters
{
  public class RaterFactory
  {
    private readonly ILogger _logger;

    public RaterFactory(ILogger logger)
    {
      _logger = logger;
    }

    public Rater Create(Policy policy)
    {
      try
      {
        return (Rater)Activator.CreateInstance(
            Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                new object[] { _logger });
      }
      catch
      {
        return new UnknownPolicyRater(_logger);
      }
    }
  }
}