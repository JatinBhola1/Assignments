using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class OnPayrollEmployee: Employe
    {
        byte exp;
        double basicSalary;
        DateTime joiningDate;
        double hra, da, netSalary;
        public override void  GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Exp");
            exp = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the basic Salary");
            basicSalary =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Joining Date");
            joiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hra: ");
            hra=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The DA");
            da=double.Parse(Console.ReadLine());
            CalculatePayment(basicSalary,exp);
            DisplayDetails();

        }
        public void CalculatePayment(double basicsalary,byte exp)
        {
            
            if(exp>10)
            {
                netSalary = (((10 / 100) * basicSalary) + ((8.5 / 100) * basicSalary) - 6500);
            }
            else if(exp>7&& exp<10)
            {
                netSalary = (((7 / 100) * basicSalary) + ((6.5 / 100) * basicSalary) - 4100);
            }
            else if(exp>5 && exp<7)
            {
                netSalary = (((4.1 / 100) * basicSalary) + ((3.8 / 100) * basicSalary) - 1800);
            }
            else
            {
                netSalary = (((1.9 / 100) * basicSalary) + ((2.0 / 100) * basicSalary) - 1200);
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("The Basic Salary is ",basicSalary);
            Console.WriteLine("Da ", da);
            Console.WriteLine("Hra is ", hra);
            Console.WriteLine("total salary is ", netSalary);
        }

    }
}
