using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesTask
{
    internal class Person
    {
        private static int startId = 1;
        public int Id;
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name, string surname, int age)
        {
            Id = startId++;
            Name = name;
            Surname = surname;
            Age = age;
        }

        internal static void AddPerson()
        {
            Console.WriteLine();
        }

        internal static void FindEmployee()
        {
            Console.WriteLine();
        }
    }
}
