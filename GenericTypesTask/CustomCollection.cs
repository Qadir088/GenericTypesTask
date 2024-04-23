using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesTask
{
    internal class CustomCollection<T> where T : Person
    {
        private static T[] _arr = new T[0];

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public void GetById(int id)
        {
            foreach (var item in _arr)
            {
                if (item.Id == id) Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age + " ");
                else Console.WriteLine("Not Found");
            }
            if (_arr.Length == 0) Console.WriteLine("Not Found");
        }
        public T[] GetAll()
        {
            return _arr;
        }

        public static implicit operator CustomCollection<T>(CustomCollection v)
        {
            throw new NotImplementedException();
        }
    }
}
