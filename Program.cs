using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number from 0-100");
                Console.WriteLine();

                string sNumber = Console.ReadLine();

                int iResult = 0;

                if (int.TryParse(sNumber, out iResult)) // check if number not string
                {
                    int i = int.Parse(sNumber);

                    if (i > winNum)
                        Console.WriteLine("To high.");
                    else if (i < winNum)
                        Console.WriteLine("Too low.");
                    else if (i == winNum)
                    {
                        Console.WriteLine("Good job");
                        win = true;
                    }
                }
                else
                {
                    Console.WriteLine("Numbers only!");
                    Console.WriteLine();
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Good job");
            Console.Write("Any key to be finished.");
            Console.ReadKey(true);
            
        }
    }
}