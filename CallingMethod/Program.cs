using System;

namespace CallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The New Game");

            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your city name: ");
            string city = Console.ReadLine();

            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            
            Console.ReadLine();




        }







    }
}
