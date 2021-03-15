using System;

namespace StringsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = " What if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = string.Format("{0} = {1}", "First", "Second");
            //string myString = string.Format("{0:C}", 120.90);
           
            string myString = "  That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();

            /*myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length,
                myString.Trim().Length);
            */
            
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
                
            }

            





            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
