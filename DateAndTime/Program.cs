using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());


            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //DateTime myBirthday = new DateTime(1994, 01, 10);
            //Console.WriteLine(myBirthday.ToShortDateString());


            DateTime myBirthday = DateTime.Parse("10/01/1994");
            TimeSpan myage = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myage.TotalDays);

            Console.ReadLine();
        }
    }
}
