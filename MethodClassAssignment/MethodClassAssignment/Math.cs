using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    public class Math
    {
        //writing our void method that takes two int parameters
        public void voidMethod(int a, int b)
        {
            int c = a * 12;
            //Our void method will not pass back variables, instead it will write to the screen
            Console.WriteLine("Result of a math operation (x12) involving the first parameter: " + c);
            Console.WriteLine("And here is the second parameter just diplayed to the screen: " + b);
        }
    }
}
