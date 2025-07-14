namespace Autodot;

public class Config
{
    public string AutodotVersion { get; set; }
    public string RemoteZipUri { get; set; }
    public string DeploymentFolder { get; set; }
    public string BinaryPath { get; set; }
    public string DefaultTask { get; set; }
    public string ProjectFolder { get; set; }
    public Dictionary<string, string> Tasks { get; set; } = new();
}
