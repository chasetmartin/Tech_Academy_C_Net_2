using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        //Creating ID, Fname, Lname properties for Employee class
        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Overloading the == operator to compare ID of Employee object
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.employeeID == employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Overloading the != operator to compare IDs
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.employeeID != employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
