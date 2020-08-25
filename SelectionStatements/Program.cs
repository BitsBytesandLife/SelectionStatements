using System;
using System.Transactions;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Enter Your Number:");
            var userInput = int.Parse(Console.ReadLine());

            //Create an if-statement that if the guessed number is below the initial value, print out “too low”.
            //Create an else -if statement that if the number is higher than the initial value, print out “too high”.
            //Create an else statement that prints out “Nevermind”.

            if (userInput <= favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput >= favNumber)
            {
                Console.WriteLine("too high");
            }
            else 
            {
                Console.WriteLine("NeverMinds");
            }

        }
    }
}
