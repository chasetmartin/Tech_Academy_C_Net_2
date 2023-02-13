using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets see if our overloaded operators work");
            //Instantiating two objects of the Employee class
            Employee bob = new Employee() { employeeID = 1, firstName= "Bob", lastName= "Smith" };
            Employee john = new Employee() { employeeID = 2, firstName = "John", lastName = "Smith" };

            //Using my overloaded operators to compare bob and john
            Console.WriteLine("Using the overloaded == operator (should be a false comparison):");
            Console.WriteLine(bob == john);
            Console.WriteLine("Using hte overloaded != operator (should be a true comparison):");
            Console.WriteLine(bob != john);

            //Trying the same ID numbers to see if the logic still works
            Employee jim = new Employee() { employeeID = 2, firstName = "Jim", lastName = "Smith" };
            Console.WriteLine("Using == on two employees with the same ID but different names (should be true):");
            Console.WriteLine(jim == john);

            Console.ReadLine();
        }
    }
}
