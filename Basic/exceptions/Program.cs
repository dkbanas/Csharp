// See https://aka.ms/new-console-template for more information
Console.WriteLine("Divider program");

int firstNumber = 0;
int secondNumber = 0;

while (true)
{
    try
    {
        Console.WriteLine("Enter the first number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        break; 
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Enter the second number:");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        break; 
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


try
{
    int result = firstNumber / secondNumber;
    Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is {result}.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}



