using System;

namespace SimpleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please slect one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte ");
            Console.WriteLine("3 - Americano ");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Expresso");
            Console.WriteLine("Q - Quit the program ");
            char userChoice = ' ';
            //while (!userChoice.Equals('q'))
            while (!(userChoice.Equals('q') || userChoice.Equals('Q')))
            {
                userChoice = Console.ReadKey(true).KeyChar;
                if (userChoice != null)
                {
                    Console.WriteLine("You chose " + userChoice);
                }
            }
        }
    }
}
