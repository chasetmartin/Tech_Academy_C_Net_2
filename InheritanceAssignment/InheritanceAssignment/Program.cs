using System;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Assignment \nInstantiate and initialize an Employee:");
            //Instantiate and Initialize employee
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Employee" };
            //Call the superclass method SayName() on the Employee
            employee.SayName();

            Console.ReadLine();
        }
    }
}
