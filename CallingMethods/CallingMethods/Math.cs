using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Math
    {
        //create add 10 method
        public int Add(int num1)
        {
            int result = num1 + 10;
            return result;
        }

        //create subtract 10 method
        public int Sub(int num1)
        {
            int result = num1 - 10;
            return result;
        }

        //create multiply by 5 method
        public int Mult(int num1)
        {
            int result = num1 * 5;
            return result;
        }
    }
}
