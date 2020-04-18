using System.IO;

namespace ArdalisRating.Infrastructure.PolicySources
{
  public class FilePolicySource
  {
    public string GetPolicyFromSource() => File.ReadAllText("policy.json");
  }
}