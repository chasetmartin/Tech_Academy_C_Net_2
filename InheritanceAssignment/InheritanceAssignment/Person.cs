using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    public class Person
    {
        //Creating properties of First and Last Names for the Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Create a sayName Method
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
