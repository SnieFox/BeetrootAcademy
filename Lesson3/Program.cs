using System.Runtime.CompilerServices;

partial class Program
{
    //Task 1 
    static int MaxOfParams(params int[] nums)
    {
        int result = nums.Max();
        return result;
    }
    // Task 2
    static int MinOfParams(params int[] nums)
    {
        int result = nums.Min();
        return result;
    }
    //Task 3
    static bool TrySumIfOdd(int num1, int num2, out int sum)
    {
        sum = num1 + num2;
        return sum % 2 != 0;
    }
    //Task 4
    static int MaxOfParams(int num1, int num2, int num3, int num4)
    {
        List<int> list = new List<int>() { num1, num2, num3, num4 };
        int result = list.Max();
        return result;
    }
    static int MaxOfParams(int num1, int num2, int num3)
    {
        List<int> list = new List<int>() { num1, num2, num3};
        int result = list.Max();
        return result;
    }
    static int MinOfParams(int num1, int num2, int num3, int num4)
    {
        List<int> list = new List<int>() { num1, num2, num3, num4 };
        int result = list.Min();
        return result;
    }
    static int MinOfParams(int num1, int num2, int num3)
    {
        List<int> list = new List<int>() { num1, num2, num3};
        int result = list.Min();
        return result;
    }

    //Extra
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
    static void Main(string[] args)
    {
        //Task 1
        int maxResult = MaxOfParams(new Random().Next(30), new Random().Next(30));
        //Task 2
        int minResult = MinOfParams(new Random().Next(30), new Random().Next(30));
        //Task 3
        int sum;
        bool someBool = TrySumIfOdd(5, 6, out sum);
        //Task 4
        int overlMax3 = MaxOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30));
        int overlMax4 = MaxOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30), new Random().Next(30));
        int overlMin3 = MinOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30));
        int overlMin4 = MinOfParams(new Random().Next(30), new Random().Next(30), new Random().Next(30), new Random().Next(30));
        //Extra
        string output = Repeat("str", new Random().Next(5));

    }
}

