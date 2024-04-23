using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesTask
{
    internal class Employee : Person
    {
        private double salary;

        public int Salary { get; set; }

        public Employee(string name, string surname, int age, int salary) : base(name, surname, age)
        {
            Salary = salary;
        }

        public Employee(string name, string surname, int age, double salary) : base(name, surname, age)
        {
            this.salary = salary;
        }
    }
}
