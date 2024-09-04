// See https://aka.ms/new-console-template for more information

//Parsing string to number
Console.WriteLine("Parsing string to number");
string firstNumberString = "1";
string secondNumberString = "2";
int result;
int firstNumberInt = int.Parse(firstNumberString);
int secondNumberInt = int.Parse(secondNumberString);
result = firstNumberInt + secondNumberInt;
Console.WriteLine($"Add operation on numbers: {firstNumberInt} + {secondNumberInt} = {result}");
Console.WriteLine($"Add operation on strings: {firstNumberString} + {secondNumberString} = {firstNumberString + secondNumberString} ");

//Parsing string to char
Console.WriteLine("Parsing string to char");
string characterString = "a";
char characterChar = char.Parse(characterString);
Console.WriteLine($"{characterChar}");

