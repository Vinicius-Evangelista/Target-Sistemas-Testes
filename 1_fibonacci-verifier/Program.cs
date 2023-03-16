using System;

namespace TargetSistemas
{
    class Program
    {

        static bool IsFibonacci(int number)
        {

            int a = 0;
            int b = 1;

            while (true)
            {

                int c = a + b;
                a = b;
                b = c;

                if (a > number)
                {
                    return false;
                }

                if (a == number)
                {
                    return true;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---- Fibonacci Verifier -----" + "\n");
            Console.ResetColor();

            Console.WriteLine("Press CTRL+C to exit" + "\n");

            do
            {
                

                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool isFibonacci = IsFibonacci(number);

                if (isFibonacci)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"That's a bingo! {number} it's a Fibonacci number :) ");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"That's not a bingo! {number} it's not a Fibonacci number :(" + "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Try again..." + "\n");
                    Console.ResetColor();
                }
            } while (true);

        }
    }
}