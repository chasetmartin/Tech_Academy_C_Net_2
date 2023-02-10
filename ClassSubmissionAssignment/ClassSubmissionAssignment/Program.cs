using System;

namespace ClassSubmissionAssignment
{
    //Creating a static class
    static class Author
    {
        public static string Author_name = "Chase Martin";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Submission Assignment \nPart one: a void method to divide by 2");

            //Instantiate the class Math that I created
            Math math = new Math();

            //Have the user enter a number, call my method on that number
            Console.WriteLine("Please type an integer: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            //Call my dividebyTwo method that divides userInt by 2
            math.divideByTwo(userInt);
            //print result to the screen, using the mathResult object
            Console.WriteLine(userInt + " Divided by 2 = " + math.mathResult);

            Console.WriteLine("Part 2: a method with output parameters");
            Console.WriteLine("The program will now call the outputPar method that I created to return a saved number");
            //Create a local variable to store the output
            int outputparam = 1;
            //call my outputPar method to return the value stored within the method
            math.outputPar(out outputparam);
            //print output to the screen
            Console.WriteLine("The method with an output parameter was storing the value of: " + outputparam);

            Console.WriteLine("Part 3: Overload a method");
            Console.WriteLine("Please type a decimal number and we will overload the divideByTwo method: ");
            //Storing the user input
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            //call dividebyTwo method to use the overloaded method
            math.divideByTwo(userDec);
            //print result to the screen, using the mathResult
            Console.WriteLine(userDec + " Divided by 2 overloading the method = " + math.mathResult);

            Console.WriteLine("Part 4: The static class Author is declared, and now we will use it to get the author's name:");
            Console.WriteLine("Author's name is: " + Author.Author_name);
            Console.ReadLine();
        }
    }
}
