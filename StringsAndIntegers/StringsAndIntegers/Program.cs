using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers:
            List<int> listofint = new List<int> { 12, 23, 65, 97, 24, 68, 23, 53 };
            Console.WriteLine("I've created a list of integers. \nPlease input an integer and I will divide each number in my list by your input:");
            try
            {
                int dividebynum = Convert.ToInt32(Console.ReadLine());
                foreach (int item in listofint)
                {
                    Console.WriteLine(item + " Divided by " + dividebynum + " equals ~ " + item / dividebynum);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid integer input");
            }
            Console.WriteLine("End of the Program, outside of try/catch");
            Console.ReadLine();

        }
    }
}
