using System.Runtime.CompilerServices;


//Homework
//Part 1
Task1();
void Task1()
{
    Console.WriteLine("Enter x: ");
    var x = int.TryParse(Console.ReadLine(),out var xResult);
    Console.WriteLine("Enter y: ");
    var y = int.TryParse(Console.ReadLine(),out var yResult);
    if (x & y)
    {
        if (xResult == yResult)
        {
            Console.WriteLine($"Sum = {xResult}");
        }
        else
        {
            int sum = 0;
            for (int i = xResult; i <= yResult; i++)
            {
                sum += i;
                if (i == xResult)
                {
                    Console.Write($"{xResult}");
                }
                else
                {
                    Console.Write($" + {i}");
                }
            }

            Console.Write($" = {sum}");
        }

        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Invalid input");
        //Task1();
    }

}
