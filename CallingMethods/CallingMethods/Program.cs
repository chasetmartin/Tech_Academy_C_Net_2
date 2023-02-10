using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for an integer to do some math on
            Console.WriteLine("Type an integer (whole number) and we'll do some math:");
            //Store user input as userNum
            int userNum = Convert.ToInt32(Console.ReadLine());
            
            //Create a mathoperator using the Math class, which includes our math methods we will call on the userNum
            Math mathoperator = new Math();
            
            Console.WriteLine("First we'll call a method to add 10 to your number:");
            //Call the Add method of mathoperator to add ten and store the result
            int addingten =  mathoperator.Add(userNum);
            Console.WriteLine("Your number + 10 = " + addingten);

            Console.WriteLine("Next we'll call a method to subtract 10 from your number:");
            //Call the Sub method of mathoperator to subtract ten and store the result
            int subtractten = mathoperator.Sub(userNum);
            Console.WriteLine("Your number - 10 = " + subtractten);

            Console.WriteLine("Finally we'll call a method to multiply your number by 5:");
            //Call the Mult method of mathoperator to multiply by 5 and store the result
            int multbyfive = mathoperator.Mult(userNum);
            Console.WriteLine("Your number x 5 = " + multbyfive);

            Console.ReadLine();
        }
    }
}
