using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Parsing Enums Assignment");
            //Request a day of the week from the user
            Console.WriteLine("Please write the day of the week (and capitalize the first letter):");
            //try block to try and assign the user input (console.ReadLine) to an enum variable
            try
            {
                //create dayofweek DaysOfWeek enum variable and parse user input to the enum variable
                DaysOfWeek dayofweek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                //print message if the parse was successful
                Console.WriteLine("Success, you entered " + dayofweek + ", a valid day of the week defined in our Enum!");
            }
            //catch block to catch any excpetions (incorrectly entered day of week)
            catch (Exception)
            {
                Console.WriteLine("Please restart program and enter an actual day of the week");
            }

            Console.ReadLine();
        }
        //define my DaysOfWeek Enum
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
