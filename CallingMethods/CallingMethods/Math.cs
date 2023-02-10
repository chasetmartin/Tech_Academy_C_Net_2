using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Math
    {
        public int Add(int num1)
        {
            int result = num1 + 10;
            return result;
        }

        public int Sub(int num1)
        {
            int result = num1 - 10;
            return result;
        }

        public int Mult(int num1)
        {
            int result = num1 * 5;
            return result;
        }
    }
}
