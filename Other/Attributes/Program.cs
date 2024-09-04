using Attributes;

Type type = typeof(Sample);
Console.WriteLine("Class info:");
foreach (InfoAttribute attr in type.GetCustomAttributes(typeof(InfoAttribute), false))
{
    Console.WriteLine($"Desc: {attr.Description}, Ver: {attr.Version}");
}

var method = type.GetMethod("DisplayInfo");
Console.WriteLine("Method info:");
foreach (InfoAttribute attr in method.GetCustomAttributes(typeof(InfoAttribute), false))
{
    Console.WriteLine($"Desc: {attr.Description}, Ver: {attr.Version}");
}
