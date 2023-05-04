﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4
{
    internal class ContractBasis : Employe
    {
        DateTime contractDate;
        int duration;
        double charges;
        double paymentAmt;
        public ContractBasis(): base()
        {
            
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter The Contarct Date: ");
            contractDate=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter The Contract Duration in days: ");
            duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Charges: ");
            charges= Convert.ToDouble(Console.ReadLine());
            CalculatePayment();
           
        }
        public void CalculatePayment()
        {
            paymentAmt = charges * duration;
            DisplayDetails();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The Contract Duration is days is {0} ",duration);
            Console.WriteLine("The charges are: {0}",charges);
            Console.WriteLine("Total Payment Done: {0}", paymentAmt);
        }
    }
}
