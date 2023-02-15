using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    public class User
    {
        public User(string name) : this(name, 101)
        {
        }
        public User (string name, int id)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
