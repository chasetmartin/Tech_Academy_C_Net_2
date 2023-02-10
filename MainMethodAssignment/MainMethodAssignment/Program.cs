using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Math class as mathoverload, which includes our DoMath we will overload and call 3 seperate times:
            Math mathoverload = new Math();

            //Ask the user for an integer to do some math on
            Console.WriteLine("Type an integer and we'll call our DoMath method for the first time");
            //Store user input as userInt
            int userInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("We will add 10 to your integer:");
            //Call the DoMath method of mathoverload to add ten and store the result
            int addingten = mathoverload.DoMath(userInt);
            Console.WriteLine(userInt + " + 10 = " + addingten);

            //Ask the user for a decimal to do some math on
            Console.WriteLine("Type a decimal number and we'll call our DoMath method for the second time overloading to the decimal operation");
            //Store user input as userDec
            decimal userDec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("We will subtract 10 from your decimal number:");
            //Call the DoMath method of matheroverload to subtract ten and store the result
            int subtractingten = mathoverload.DoMath(userDec);
            Console.WriteLine(userDec + " - 10 = " + subtractingten);

            //Ask the user for a string to convert to an integer
            Console.WriteLine("Last, type another integer (whole number) and we'll treat it as a string and call our DoMath method for the third time, overloading to the string operation");
            //Store user input as userNum
            string userString = Console.ReadLine();

            Console.WriteLine("We will multiply your number (treated as a string) by 5:");
            //Call the DoMath method of matheroverload to multiply by 5 and store the result
            int multiplybyfive = mathoverload.DoMath(userString);
            Console.WriteLine(userString + " x 5 = " + multiplybyfive);

            Console.ReadLine();
        }
    }
}
