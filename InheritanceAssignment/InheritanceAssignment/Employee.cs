using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    //Create an employee class and inherit from the Person class
    public class Employee : Person
    {
        //ID property that is specific to the Employee
        public int Id { get; set; }
    }
}
