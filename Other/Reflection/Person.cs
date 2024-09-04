namespace Reflection;

public class Person
{
    public string Name { get; set; }
    
    public void Greet()
    {
        Console.WriteLine($"My name is {Name}.");
    }
}