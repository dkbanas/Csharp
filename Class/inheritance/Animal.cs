namespace inheritance;

public class Animal
{
    public string Name;

    public Animal(string name)
    {
        this.Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{this.Name} is eating.");
    }
    
}