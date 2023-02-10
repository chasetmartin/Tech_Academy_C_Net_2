using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Create an employee class and inherit from the Person class
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
        }
    }
}
