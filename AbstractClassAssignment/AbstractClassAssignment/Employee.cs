using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Create an employee class and inherit from the Person abstract class and IQuittable interface
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
        }
        //Implementing the Quit method of the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Thanks for Playing, you quit.");
        }
    }
}
