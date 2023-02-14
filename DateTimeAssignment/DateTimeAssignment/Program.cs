using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date/Time Assignment:");
            Console.WriteLine("Here is the current Date and Time:");
            //Using DateTime to get the current Date/Time
            Console.WriteLine(DateTime.Now);

            //Ask user for an integer
            Console.WriteLine("Please enter a number (integer):");
            //Convert input to integer
            int toadd = Convert.ToInt32(Console.ReadLine());
            //Create a new TimeSpan from the user input, with the input being the number of hours
            TimeSpan timeadd = new TimeSpan(0, toadd, 0, 0);
            //Write to the console the Current Date/Time with the user input TimeSpan added to the value
            Console.WriteLine("Here is the Date/Time it will be in " + toadd + " hours: " + DateTime.Now.Add(timeadd));

            Console.ReadLine();
        }
    }
}
