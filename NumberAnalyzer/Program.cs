using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool runProgram = true;
            Console.WriteLine("Welcome to the Number Analyzer, what is your name?");
            string name = Console.ReadLine();

            while (runProgram)
            {
                //validates number is between 1 and 100
                Console.WriteLine($"{name}! Enter a number between 1 and 100");
                double num = double.Parse(Console.ReadLine());
                if (num < 1 || num > 100)
                {
                    Console.WriteLine($"Hey {name}...it must be a number between 1 and 100!");
                    continue;
                }
                //check to see if number is odd
                else if (num % 2 != 0)
                {
                    Console.WriteLine($"{num} Odd");

                }
                //check to see if number is even
                else if (num % 2 == 0)
                {
                    if (num >= 2 && num < 25)
                    {
                        Console.WriteLine($"Even and less than 25");
                    }
                    else if (num >= 26 && num < 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (num >= 60)
                    {
                        Console.WriteLine($"{num} Even");
                    }
                }
                //checking to continue if statement
                Console.WriteLine("Continue? (y/n)");
                string keepGoing = Console.ReadLine().ToLower();

                if (keepGoing == "n")
                {
                    runProgram = false;
                    Console.WriteLine($"Goodbye {name}!");
                }else
                {
                    runProgram = true;
                }

            }

        }


    }
}

