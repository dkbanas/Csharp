//For
Console.WriteLine("for ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------");

//foreach
Console.WriteLine("Foreach");
List<string> brands = new () { "AUDI", "BMW", "MERCEDES", "VOLKSWAGEN", "OPEL" };
foreach (var item in brands)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");

//do while
Console.WriteLine("do while");
int j = 0;
do
{
    j++;
    Console.WriteLine(j);
}while(j<5);
Console.WriteLine("----------");

//while
int k = 0;
Console.WriteLine("while");
while (k < 5)
{
    k++;
    Console.WriteLine(k);
}
Console.WriteLine("----------");

