using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAssignment
{
    //Creating employee class
    public class Employee
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
    //Creating an employee list Constructor to create a starting list quickly in main program
    public class EmployeeList
    {
        public EmployeeList() 
        {
            Employees = new List<Employee>();

            List<string> fNames = new List<string>() { "Joe", "Jim", "Joe", "Jerry", "Joe", "Beth", "Bob", "John", "Joe", "Steve"};
            List<string> lNames = new List<string>() { "Smith", "Martin", "Hayes", "Bill", "Johnson", "Brown", "Miller", "Davis", "Williams", "Jones" };
            List<int> iDent = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee();
                employee.Id = iDent[i];
                employee.fName = fNames[i];
                employee.lName = lNames[i];
                Employees.Add(employee);
            }
        }
        public List<Employee> Employees { get; set; }
    }
}
