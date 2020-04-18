namespace ArdalisRating
{
  public interface IRatingContext
  {
    void Log(string message);
    string LoadPolicyFromFile();
    string LoadPolicyFromURI(string uri);
    Policy GetPolicyFromJsonString(string policyJson);
    Policy GetPolicyFromXmlString(string policyXml);
    Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
    RatingEngine Engine { get; set; }
    ConsoleLogger Logger { get; }
  }
}