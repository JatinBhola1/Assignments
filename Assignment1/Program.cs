using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Assignment1
{
    internal class Program
    {
        static void Main()
        {
            //1st Question
            //Console.WriteLine("Hello, World!");

            // calling for second Question

            //int add, subtract, product, quo;
            //operation(10, 100,out add,out subtract,out product,out quo);
            //Console.WriteLine("The sum od two numbers is {0}",add);
            //Console.WriteLine("The difference of two numbers is {0}",subtract);
            //Console.WriteLine("The product of two numbers is {0}",product);
            //Console.WriteLine("The quotient of two numbers is {0}",quo);

            // 3rd question calling
            //int x = 10, y = 100;
            //Console.WriteLine("Enter the choice from 1 to 4 where 1 is add, 2 is subtract, 3 is product and 4 is quotient");
            //int z=Convert.ToInt32(Console.ReadLine());
            //ChoiceOperation(x, y, z);

            // 4th question
            //Console.WriteLine("Enter your Name");
            //string name=Console.ReadLine();
            //Console.WriteLine("Your name Will be Displayed 10 times");
            //DisplayName(name);


            //5th question
            //Console.WriteLine("All the even Numbers from 1-10");
            //DisplayEvenNum();


            //6th Question
            //Console.WriteLine("All the odd numbers from 50-7");
            //DisplayOddNuber();


            //7th question
            //Console.WriteLine("Eneter the number whose table is to be Displayed");
            //int num=Byte.Parse(Console.ReadLine());
            //DisplayTable(num);


            //8th question
            //Console.WriteLine("The Gap of 3 from 100 to 7 is:");
            //DisplayWithGap();


            //9th Question
            //int x = 10, y = 20, z = 30;
            //Console.WriteLine("The Integers Displayed in a Single Line first is: {0} second is: {1} and third is: {2}",x,y,z);


            //10th Question
            int x=10,y=20,z=30; ;
            Console.WriteLine("The Integers Displayed in Different Lines");
            Console.WriteLine("The first number is: "+x);
            Console.WriteLine("The Second number is: "+y);
            Console.WriteLine("The Third number is: "+z);

        }

        //2nd Question
        //public static void operation(int x, int y, out int add, out int subtract, out int product, out int quo)
        //{
        //    add = x + y;
        //    subtract = x - y;
        //    product = x * y;
        //    quo = x / y;
        //}


        //3rd Question
        //public static void ChoiceOperation(int x, int y, int z)
        //{
        //    switch (z)
        //    {
        //        case 1:
        //            Console.WriteLine("The sum of two numbers is {0}", x + y);
        //            break;
        //        case 2:
        //            Console.WriteLine("The difference of the numbers is {0}", x - y);
        //            break;
        //        case 3:
        //            Console.WriteLine("The product of two numbers is {0}", x * y);
        //            break;
        //        case 4:
        //            Console.WriteLine("The quoient of two numbers is {0}", x / y);
        //            break;
        //        default:
        //            Console.WriteLine("Enter a valid input");
        //            break;
        //    }
        //}

        //4Th question
        //public static void DisplayName(String Name)
        //{
        //    for(int i=0;i<10;i++)
        //    {
        //        Console.WriteLine(Name);
        //    }
        //}

        //5th question
        //public static void DisplayEvenNum()
        //{
        //    for(int i=2;i<=10;i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i+" is a even number");
        //        }
        //    }
        //}


        //6th question
        //public static void DisplayOddNuber()
        //{
        //    for(int i = 50; i >= 7; i--)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            Console.WriteLine(i);
        //        }

        //    }
        //}
        
        //7th question
        //public static void DisplayTable(int num)
        //{
        //    for(int i=1;i<=10;i++)
        //    {
        //        Console.WriteLine("{0} * {1} is {2}",num,i,num*i);
        //    }
        //}


        //8th Question
        //public static void DisplayWithGap()
        //{
        //    for(int i = 100; i >= 5; i = i-3)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

    }
}
