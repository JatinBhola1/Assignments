using System.Linq.Expressions;

namespace Assignment4
{

    static class Decide
        {
         static public void Decide1(Employe emp)
        {
            emp.GetDetails();
            
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter hoice");
            int ch = Byte.Parse(Console.ReadLine());
            Employe employe = new Employe();
            switch (ch)
            {
                case 1:  employe = new ContractBasis(); break;
                case 2:  employe= new OnPayrollEmployee(); break;
            }

            Decide.Decide1(employe);
        }
        }
    }
