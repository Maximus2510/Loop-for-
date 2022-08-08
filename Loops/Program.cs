using System;

namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                int i, j;
                for (i = 0; i <= userInput / 2; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("**");
                    }
                    Console.WriteLine();
                }
                for (i = userInput / 2; i >= 1; i--)
                {
                    for (j = 1; j < i; j++)
                    {
                        Console.Write("**");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            else
            {
                int i, j;
                for (i = 1; i <= userInput; i+=2)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (i = userInput-1; i >= 0; i-=2)
                {
                    for (j = 0; j <= i-2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}