using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism Assignment \nInstantiate an Employee (leftover from Abstract Assignment):");
            //Instantiate and Initialize employee, inheriting from the abstract class Person
            Employee employee = new Employee() { firstName = "Sample", lastName = "Employee" };
            //Call the superclass method SayName() on the Employee
            employee.SayName();

            //Polymorphism to create an object of IQuittable
            IQuittable iquitabble = new Employee() { firstName = "Polymorphism", lastName = "Example" };
            //Calling the quite method on my iquittable object
            Console.WriteLine("Calling the Quit method using an IQuittable oject (polymorphism):");
            iquitabble.Quit();

            Console.ReadLine();
        }
    }
}
