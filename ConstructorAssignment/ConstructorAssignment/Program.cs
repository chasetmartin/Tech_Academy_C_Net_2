using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Assignment \nHere is a const variable");
            //Creating a const variable
            const string appname = "The Best App Ever";
            //Using on const variable
            Console.WriteLine("The const name of this app: " + appname);

            Console.WriteLine("Now lets use the var keyword to create a variable");
            //using var keyword to create a variable
            var timenow = DateTime.Now;
            //Print that var to the screen
            Console.WriteLine("The Date/Time now is: " + timenow);

            //Chaining constroctors - See the user class
            Console.WriteLine("To see my chaing of constructors, look at the code in the User class");

            Console.WriteLine("I will create a new User and only pass the name Chase to the constructor");
            Console.WriteLine("By chaining constructors they should have been assigned the ID = 101 automatically");
            //Creating an instance using the chained constructor
            User user = new User("Chase");
            //Print user ID to the console
            Console.WriteLine("Let's check on Chase's user ID: " + user.ID);
            
            Console.ReadLine();

        }
    }
}
