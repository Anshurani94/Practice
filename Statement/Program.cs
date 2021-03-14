using System;

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play this game");
            Console.Write("choose a number: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            if (userValue =="1")
            {
                string message = "You won a new pencil";
                Console.WriteLine(message);

            }
            else if (userValue == "2")
            {
                string message = "You won a new pen";
                Console.WriteLine(message);

            }
            else if (userValue == "3")
            {
                string message = "You won a new eraser";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry, You lost.";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
