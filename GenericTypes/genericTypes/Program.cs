using genericTypes;
//Box generic Class with int
var intBox = new Box<int>();
intBox.SetValue(123);
Console.WriteLine($"IntBox contains: {intBox.GetValue()}");
//Box generic Class with string
var stringBox = new Box<string>();
stringBox.SetValue("Hello Generics");
Console.WriteLine($"StringBox contains: {stringBox.GetValue()}");

//Generic methods
int a = 5;
int b = 10;
Console.WriteLine($"Before swap - a: {a},b: {b}");
Utils.Swap(ref a,ref b);
Console.WriteLine($"After swap - a: {a},b: {b}");

int bigger = Utils.Compare(a,b);
Console.WriteLine($"There are 2 numbers: {a} and {b}. The bigger is {bigger}");

//Delegate Calculator
var Calculator = new Calculator();
Operation<int> Add = (x, y) => a + b;
Operation<int> Subtract = (x, y) => a - b;
Operation<int> Multiply = (x, y) => a * b;
Operation<int> Divide = (x, y) => a / b;
int addResult = Calculator.GetResult(1,2,Add);
int substractResult = Calculator.GetResult(2,1,Subtract);
int multiplyResult = Calculator.GetResult(2,2,Multiply);
int divideResult = Calculator.GetResult(8,2,Divide);
Console.WriteLine($"Add: {addResult},Subtract: {substractResult},Multiply: {multiplyResult},Divide: {divideResult}");