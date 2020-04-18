using System.IO;
using ArdalisRating.Core.Interfaces;

namespace ArdalisRating.Infrastructure.PolicySources
{
  public class FilePolicySource : IPolicySource
  {
    public string GetPolicyFromSource() => File.ReadAllText("policy.json");
  }
}