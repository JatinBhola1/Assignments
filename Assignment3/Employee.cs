using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Employee
    {
        public byte id;
        public string name;
        public string dept;
        public double salary;
        public void GetDetails()
        {
            Console.WriteLine("Enter the Id: ");
            byte.TryParse(Console.ReadLine(),out id);
            Console.WriteLine("Enter the Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter the Salary: ");
            salary=Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine("The id is {0}",id);
            Console.WriteLine("The Name is {0}",name);
            Console.WriteLine("The department is {0}",dept);
            Console.WriteLine("The salary is {0}",salary);
        }
    }
}
