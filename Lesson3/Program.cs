using System.Runtime.CompilerServices;





//Task 1 
int maxResult = MaxOfParams(new Random().Next(30), new Random().Next(30));
static int MaxOfParams(params int[] nums)
{
    int result = nums.Max();
    return result;
}
// Task 2
int minResult = MinOfParams(new Random().Next(30), new Random().Next(30));
static int MinOfParams(params int[] nums)
{
    int result = nums.Min();
    return result;
}
//Task 3
int sum;
bool someBool = TrySumIfOdd(5, 6, out sum);
static bool TrySumIfOdd(int num1, int num2, out int sum)
{
    sum = num1 + num2;
    return sum % 2 != 0;
}
//Task 4
int overlMax3 = MaxOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30));
int overlMax4 = MaxOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30), new Random().Next(30));
int overlMin3 = MinOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30));
int overlMin4 = MinOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30), new Random().Next(30));

//Extra
string output = Repeat("str", new Random().Next(5));
static string Repeat(string x, int number)
{
    string output = "";
    if (number <= 0)
    {
        output = "Wrong number";
    }
    else
    {
        for (int i = 0; i < number; i++)
        {
            output += x;
        }
    }
    return output;
}

Console.ReadLine();


