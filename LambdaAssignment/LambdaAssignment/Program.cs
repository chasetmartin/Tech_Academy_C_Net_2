using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Assignment: \nInstantiate 10 Employees");
            //Instantiate 10 employees using EmployeeList constructor (4 have the first name Joe)
            EmployeeList employeelist = new EmployeeList();
            //Print list of employees to the screen to confirm 10 Employees created:
            foreach (Employee employee in employeelist.Employees)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + " ID= " + employee.Id);
            }

            //using a foreach loop to create a new list of all employees with the first name of "Joe"
            Console.WriteLine("Here we will iterate through the employee list and pull out those with the first name of Joe");
            //New empty list
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employeelist.Employees)
            {
                if (employee.fName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            //foreach loop to print results to the screen
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.fName + " " + employee.lName);
            }

            Console.WriteLine("Now here is the same exercise using a Lambda function:");
            //Now we will use a lambda function to do the same thing
            List<Employee> joeListLambda = employeelist.Employees.Where(x => x.fName == "Joe").ToList();
            //foreach loop to print lambda results to the screen
            foreach (Employee employee in joeListLambda)
            {
                Console.WriteLine(employee.fName + " " + employee.lName);
            }

            Console.WriteLine("Now we will use a Lambda function to create a list of employees with Id > 5:");
            //Lambda function to make a new list of employees with an Id > 5
            List<Employee> greaterthanfive = employeelist.Employees.Where(x => x.Id > 5).ToList();
            //Foreach loop to print lambda results to the screen
            foreach (Employee employee in greaterthanfive)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + " ID= " + employee.Id);
            }

            Console.ReadLine();
        }
    }
}
