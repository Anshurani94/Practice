using System;

namespace DecisionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door; 1, 2 or 3");
            string userValue = Console.ReadLine();
            
            string message = "";

            if (userValue == "1")
                message = "You won a cat";
            else if (userValue == "2")
                message = "You won a boat";
            else if (userValue == "3")
                message = "You won a car";
            else
            {
                message = "Sorry, we didn't understand";
                message = message + "You lose";
            }
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
