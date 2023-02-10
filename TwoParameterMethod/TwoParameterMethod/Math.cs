using System;
using System.Collections.Generic;
using System.Text;

namespace TwoParameterMethod
{
    public class Math
    {
        //create method with two parameters, one optional withe a default
        public int DoMath(int num1, int times = 2)
        {
            int result = num1 * times;
            return result;
        }
    }
}
