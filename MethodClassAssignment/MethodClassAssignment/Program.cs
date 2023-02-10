using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will instantiate our class and call our void method:");
            //Instantiating our class
            Math math = new Math();
            //Calling the void method in our Math class, passing in two numbers:
            math.voidMethod(20, 45);

            //Now we will call the void method and specify the paramters by name
            math.voidMethod(a: 89, b: 12);

            Console.ReadLine();

        }
    }
}
