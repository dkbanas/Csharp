namespace Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class InfoAttribute : Attribute
{
    public string Description { get; }
    public string Version { get; }
    
    public InfoAttribute(string description, string version)
    {
        Description = description;
        Version = version;
    }
}