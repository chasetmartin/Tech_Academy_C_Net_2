using System;

namespace TwoParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Math class as math, which includes our DoMath method with two parameters (one optional):
            Math math = new Math();

            //Ask the user for an integer
            Console.WriteLine("Type an integer (required):");
            //Store user input as userInt1
            int userInt1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user for a second integer that is optional - I'll leave it as a string for now
            //because trying to convert a blank string entry to an integer would throw a format exception
            Console.WriteLine("Type a second integer (optional, you can leave blank and press enter):");
            //Store user input as userInput2
            string userInput2 = Console.ReadLine();

            Console.WriteLine("We will pass both of your inputs to the math method and see what comes out:");
            //Call the DoMath method using an if else statment, passing only one paramater if the second input was left blank
            if (userInput2 == "")
            {
                //only passing the first input to DoMath since the user left the second input blank
                int doingmath = math.DoMath(userInt1);
                Console.WriteLine("The result of the math operation, no second input (just multiply by the default second parameter: 2): " + doingmath);
            }
            else
            {
                //the second input was present, so we convert it to an integer and pass both parameters to the DoMath method
                int userInt2 = Convert.ToInt32(userInput2);
                int doingmath = math.DoMath(userInt1, userInt2);
                Console.WriteLine("The result of the math operation using the optional parameter: " + doingmath);
            }

            Console.ReadLine();
        }
    }
}
