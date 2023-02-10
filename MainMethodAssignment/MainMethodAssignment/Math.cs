using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    public class Math
    {
        //create add 10 method for integer
        public int DoMath(int num1)
        {
            int result = num1 + 10;
            return result;
        }

        //create subtract 10 method for decimal input
        public int DoMath(decimal num1)
        {
            int numint = Convert.ToInt32(num1);
            int result = numint - 10;
            return result;
        }

        //create multiply by 5 method for string input
        public int DoMath(string num1)
        {
            int numint = Convert.ToInt32(num1);
            int result = numint * 5;
            return result;
        }
    }
}
