namespace Attributes;

[Info("DemoClass", "1.0")]
public class Sample
{
    [Info("DemoMethod", "1.0")]
    public void DisplayInfo()
    {
        Console.WriteLine("Info");
    }
}