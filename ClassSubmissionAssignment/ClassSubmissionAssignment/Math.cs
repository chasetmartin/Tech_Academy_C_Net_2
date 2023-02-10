using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
    public class Math
    {
        //give properties to mathResult so that we can perform methods on the instantiated class object
        public int mathResult { get; set; }

        //First required method - take an integer and divide by two
        public void divideByTwo(int a)
        {
           mathResult = a / 2;
        }

        //Second required method - with output parameters
        public void outputPar(out int x)
        {
            int holder = 12;
            x = holder;
        }

        //Third required method - overload one of the above methods
        public void divideByTwo(decimal a)
        {
            int b = Convert.ToInt32(a);
            mathResult = b / 2;
        }
    }
}
