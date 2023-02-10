using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //Creating properties of First and Last Names for the abtract Person class
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Create a sayName Method
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
