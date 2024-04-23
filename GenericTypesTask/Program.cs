using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<Employee> customColllection = new CustomCollection();
        start:
            Console.WriteLine("Please enter opetions number ");
            Console.WriteLine("*****************");
            Console.WriteLine("add employee - 1");
            Console.WriteLine("Find employee for ID - 2");
            Console.WriteLine("Show list - 3");
            Console.WriteLine("Stop operations - 0");
            Console.WriteLine("*****************");
        process:
            Console.WriteLine("Choose");
            string inputProcess = Console.ReadLine();
            bool checkProcess = byte.TryParse(inputProcess, out byte process);
            if (!checkProcess) goto process;

            switch (process)
            {
                case 1:
                    if (!AddEmployee()) goto start;
                    else Console.WriteLine("Emeliyyat sona catdi");
                    break;
                case 2:
                IdHead:
                    Console.WriteLine("Id daxil edin: ");
                    string inputId = Console.ReadLine();
                    bool check = int.TryParse(inputId, out int id);
                    if (!check) goto IdHead;
                    customColllection.GetById(id);
                    Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
                    string yesOrNo = Console.ReadLine();
                    if (yesOrNo.ToLower() == "beli")
                        goto start;
                    else Console.WriteLine("Emeliyyat sona catdi");
                    break;
                case 3:
                    GetAllEmployee();
                    Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
                    string choose = Console.ReadLine();
                    if (choose.ToLower() == "beli")
                        goto start;
                    else Console.WriteLine("Emeliyyat sona catdi");
                    break;
                case 0:
                    Console.WriteLine("Emeliyyat sona catdi");
                    break;
            }




            #region Task 1
            bool AddEmployee()
            {
                bool checking = false;
            nameHead:
                Console.WriteLine("Enter your Name: ");
                string name = Console.ReadLine();
                if (name == null || name.Length == 0) goto nameHead;
                surnameHead:
                Console.WriteLine("enter your Age: ");
                string surname = Console.ReadLine();
                if (surname == null || surname.Length == 0) goto surnameHead;
                head:
                Console.WriteLine("Enter your age: ");
                string input = Console.ReadLine();
                bool check = byte.TryParse(input, out byte age);
                if (!check) goto head;
                salaryHead:
                Console.WriteLine("Enter your salary ");
                string inputSalary = Console.ReadLine();
                bool checkSalary = double.TryParse(inputSalary, out double salary);
                if (!checkSalary) goto salaryHead;
                Employee employee = new CustomCollection(name, surname, age, Salary);
                CustomCollection<Employee> customCollection = new CustomCollection();
                customCollection.Add(employee);
                Console.WriteLine("employee added successfully");
                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Surname + " " + employee.Salary);
                Console.WriteLine("Continue or not");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() != "beli")
                {
                    checking = true;
                }
                return checking;
            }

            #endregion


            #region Task 2

            void GetAllEmployee()
            {
                Console.WriteLine("  Employee İnfo  ");
                foreach (var item in customColllection.GetAll())
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
                }
            }
            #endregion
        }
    }
}
