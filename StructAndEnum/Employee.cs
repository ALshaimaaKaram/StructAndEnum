using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndEnum
{
    struct Employee
    {
        public string Name;
        public int Salary;
        public Role role;

        public Employee(string _name, int _salary, Role _role)
        {
            Name = _name;
            Salary = _salary;
            role = _role;
        }

        public void Display()
        {
            Console.WriteLine($"Name is {Name}, Salary is {Salary}, Role is {role}");
        }

        public void AssignRole(Role role)
        {
            this.role = this.role | role;
        }

        public bool HasRole(Role role)
        {

            if ((this.role & role) == role)
                return true;
            return false;
        }
    }
}
