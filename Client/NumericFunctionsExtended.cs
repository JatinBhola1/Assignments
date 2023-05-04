using Assignment5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal static class NumericFunctionsExtended
    {
        static NumericFunctions nfs;
        public static String  EvenInRange(this NumericFunctions numericFunctions,int start,int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=start;i<=end;i++)
            {
                if(i%2 == 0)
                    sb.Append(i + "\n");

            }
            return sb.ToString();
        }
        public  static string OddInRange(this NumericFunctions numericFunctions,int start,int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                    sb.Append(i + "\n");

            }
            return sb.ToString();
        }
        public static string PrimeInRange(this NumericFunctions numericFunctions, int start,int end)
        {
            StringBuilder sb = new StringBuilder();


            for (int num = start; num <= end; num++)
            {
                int count = 0;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                    
                }
                if (count == 0)
                {
                    sb.Append(num + "\n");
                   
                }
                //else
                //{
                //    count = 0;
                //}
            }

                return sb.ToString() ;
             
               
                
           
        }
        public static String TableOfNumber(this NumericFunctions numericFunctions, int num)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=1; i<=10; i++)
            {
                sb.Append(num + " * " + i + " = " + num * i+"\n");
            }
            return sb.ToString();
        }
        public static string TableInGivenRange(this NumericFunctions numberFunctions, int start,int end)
        {
           StringBuilder sb = new StringBuilder();

            for(int num= start; num <= end; num++)
            {
               
                for (int i=1;i<=10;i++)
                {
                    sb.Append(num + " * " + i + " = " + num * i + "\n");
                }
                sb.Append("\n");

            }
            return sb.ToString();
        }

        public static int ReverseNumber(this NumericFunctions numberFunctions,int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;
        }
 

    }
}
