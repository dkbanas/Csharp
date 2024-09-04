using System.Reflection;
using Reflection;

Type personType = typeof(Person);
object personInstance = Activator.CreateInstance(personType);

PropertyInfo nameProperty = personType.GetProperty("Name");
nameProperty.SetValue(personInstance, "John Doe");

MethodInfo greetMethod = personType.GetMethod("Greet");
greetMethod.Invoke(personInstance, null);