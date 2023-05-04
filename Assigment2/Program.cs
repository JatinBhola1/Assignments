using System.Security.Cryptography;

namespace Assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st Question;

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Console.WriteLine("The Araay Elements Are:");
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //SumAndAverage(num);



            ////2nd question
            //int[,] arr1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] arr2 = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            //SumOfMatrix(arr1, arr2);



            // 3rd Question
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Console.WriteLine("The Elements of the Array are:");
            //foreach(int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //MaxElement(num);


            // 4th Questiion
            //int[,] mat= new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //ColWiseSum(mat);



            //5th question
            int[,] mat = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            RowWiseSum(mat);



        }

        // 1t question
        //public static void SumAndAverage(int [] num)
        //{

        //    int sum=(from x in num select x).Sum();
        //    Console.WriteLine("Sum is:"+sum);
        //    double avg=(from x in num select x).Average();
        //    Console.WriteLine("Average is :"+avg);
        //}



        //2nd Question
        //public static void SumOfMatrix(int[,] arr1, int[,] arr2) {
        //    int[,] sum  = new int[3,3];
        //    for(int i=0;i<3;i++)
        //    {
        //        for(int  j=0;j<3;j++)
        //        {
        //            sum[i,j] = arr1[i, j] + arr2[i,j];
        //        }
        //    }

        //    for(int i=0;i<=3;i++)
        //    {
        //        for(int j=0 ; j<3 ; j++)
        //        {
        //            Console.Write(sum[i,i]+"\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}



        // 3rd Question
        //public static void MaxElement(int[]num)
        //{
        //    int max=(from x in num select x).Max();
        //    Console.WriteLine("Max Element is : "+max);
        //}


        // 4th Question
        //public static void ColWiseSum(int[,] matrix)
        //{

        //    for (int i = 0; i < 3; i++)
        //    {
        //        int sum = 0;
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(matrix[i, j]+"\t");
        //        }
        //        Console.WriteLine();


        //    }
        //    for (int i=0;i<3;i++)
        //    {
        //        int sum = 0;
        //        for(int j = 0; j < 3; j++) {
        //            sum = sum + matrix[j, i];
        //        }
        //        Console.Write(sum+"\t");

        //    }


        //}


        //5th question

        public static void RowWiseSum(int[,] matrix)
        {

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();


            }
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + matrix[i, j];
                }
                Console.Write(sum + "\t");

            }

        }
    }
}