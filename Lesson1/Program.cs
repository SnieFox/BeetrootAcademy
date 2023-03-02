

int intValue = 4;
bool boolValue = false;
double doubleValue = 3.14;
float floatValue = 1.5f;
string stringValue = "19";
string stringValue2 = "10 + 9 = ";
Console.WriteLine($"stringValue + doubleValue: {doubleValue + stringValue}");
Console.WriteLine($"intValue - doubleValue: {intValue - doubleValue}");
Console.WriteLine($"stringValue + stringValue2: {stringValue2+stringValue}");
Console.WriteLine($"intValue / doubleValue: {intValue / doubleValue}");
Console.WriteLine($"doubleValue * floatValue: {doubleValue * floatValue}");
Console.WriteLine();

Console.WriteLine("Enter x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y:");
int y = int.Parse(Console.ReadLine());
double firstFuncAns = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
double secondFuncAns = Math.Abs(x) * Math.Sin(x);
double thirdFuncAns = 2 * Math.PI * x;
double fourthFuncAns = Math.Max(x, y);
Console.WriteLine($"First Func result:{firstFuncAns}\nSecond Func result:{secondFuncAns}\nThird Func result:{thirdFuncAns}\nFourth Func result:{fourthFuncAns}");
Console.WriteLine();

Console.WriteLine($"{365 - DateTime.Now.DayOfYear + 1} days left to New Year");
Console.WriteLine($"{DateTime.Now.DayOfYear - 1} days passed from New Year");
Console.Read();


