//Integer - 4 Bytes -  <-2,147,483,648 to 2,147,483,647>
int myIntNumber = 1;
int minIntNumber = int.MinValue;
int maxIntNumber = int.MaxValue;

//Long - 8 bytes - <-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807>
long myLongNumber = 2;
long minLongNumber = long.MinValue;
long maxLongNumber = long.MaxValue;

//Float - 4 bytes - -3,4028235E+38 to 3,4028235E+38
float myFloatNumber = 3.14f;
float minFloatNumber = float.MinValue;
float maxFloatNumber = float.MaxValue;

//Double - 8 bytes - -1,7976931348623157E+308 to 1,7976931348623157E+308
double myDoubleNumber = 4.12345678912345;
double minDoubleNumber = double.MinValue;
double maxDoubleNumber = double.MaxValue;

//Bool - 1 bit - true or false
bool myBool = true;

//char - 2 bytes - single leter
char myChar = 'a';

//string - 2 bytes per character
string myString = "Hello! This is my string!";

//Print
Console.WriteLine($"My int {myIntNumber}\n" +
                  $"Min int number: {minIntNumber}\n" +
                  $"Max int number: {maxIntNumber}\n" +
                  $"----------\n" +
                  $"My float number: {myFloatNumber}\n" +
                  $"Min float number: {minFloatNumber}\n" +
                  $"Max float number: {maxFloatNumber}\n" +
                  $"----------\n" +
                  $"My long number: {myLongNumber}\n" +
                  $"Min long number: {minLongNumber}\n" +
                  $"Max long number: {maxLongNumber}\n" +
                  $"----------\n" +
                  $"My double number: {myDoubleNumber}\n" +
                  $"Min double number: {minDoubleNumber}\n" +
                  $"Max double number: {maxDoubleNumber}\n" +
                  $"----------\n" +
                  $"My char: {myChar}\n" +
                  $"----------\n" +
                  $"My string: {myString}\n" +
                  $"----------\n" +
                  $"My bool: {myBool}\n ");
