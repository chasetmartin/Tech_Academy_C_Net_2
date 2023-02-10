using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class Assignment \nInstantiate an Employee:");
            //Instantiate and Initialize employee, inheriting from the abstract class Person
            Employee employee = new Employee() { firstName = "Sample", lastName = "Employee" };
            //Call the superclass method SayName() on the Employee
            employee.SayName();

            Console.ReadLine();
        }
    }
}
