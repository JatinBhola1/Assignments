using Assignment5;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment5.StringFuctions newStringFunctions= new Assignment5.StringFuctions();
            Assignment5.NumericFunctions newFunctions = new Assignment5.NumericFunctions(); 
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1.Add\n2.Subtract\n3.Product\n4.Divide\n5.Find Max\n6.Find Min\n7.Check Even\n8.Check odd\n9.Check Prime" +
                "\n10.Even in Range\n11.Odd in Range\n12.Prime in Range\n13.Table Of a Number\n14.Table in a Given Range\n15.Reverse a number\n" +
                "16.Number of characters in String\n17.Is palidrome\n18.Reverse the sentence" +
                "\n19.Convert To UpperCase\n20.Convert to Lowercase\n21.Combine two Sentence" +
                "\n22.Count Words\n23.Search SubString");
            int ch=Byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1: Console.WriteLine(newFunctions.Add(1, 2, 3, 4, 5, 6, 7, 8));
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter The First Number:");
                        int num1=Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter The Second Number:");
                        int num2=Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Result is: ");
                        Console.WriteLine(newFunctions.Subtract(num1, num2));
                        break;
                    }
                   case 3: {
                        Console.WriteLine("Enter The First Number:");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter The Second Number:");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Result is: ");
                        Console.WriteLine(newFunctions.Product(num1,num2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter The First Number:");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter The Second Number:");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Result is: ");
                        Console.WriteLine(newFunctions.Divide(num1,num2));
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("The Maximum is: ");
                        Console.WriteLine(newFunctions.MaxNum(1, 2, 3, 4, 5, 6, 7, 8));
                        break;

                    }
                    case 6:
                    {
                        Console.WriteLine("The Minimum is: ");
                        Console.WriteLine(newFunctions.MinNum(1, 2, 3, 4, 5, 6, 7, 8));
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("Enter The number to be checked: ");
                        int num = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.IsEven(num));
                        break;
                    }
                    case 8:
                    {
                        Console.WriteLine("Enter The number to be checked: ");
                        int num = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.IsOdd(num));
                        break;
                    }
                    case 9:
                    {
                        Console.WriteLine("Enter The number to be checked: ");
                        int num = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.IsPrime(num));
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Enter the number you want to check from");
                        int num1= Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the number you want to check from");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.EvenInRange(num1,num2));
                        break;

                    }
                    case 11: {
                        Console.WriteLine("Enter the number you want to check from");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the number you want to check from");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.OddInRange(num1, num2));
                        break;
                    }
                    case 12:
                    {
                        Console.WriteLine("Enter the number you want to check from");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the number you want to check from");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.PrimeInRange(num1, num2));
                        break;
                    }
                    case 13:
                    {
                        Console.WriteLine("Enter The Number Whose Table You Want to Print");
                        int num= Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.TableOfNumber(num));
                            break;
                    }
                    case 14:
                    {
                        Console.WriteLine("Enter the number you want to check from");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the number you want to check from");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.TableInGivenRange(num1, num2));
                        break;
                    }
                    case 15:
                    {
                        Console.WriteLine("Enter The number You want to reverse:");
                        int num=Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(newFunctions.ReverseNumber(num));
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("Enter The string to check length;");
                        string str=Console.ReadLine();
                        Console.WriteLine(newStringFunctions.NoOfCharacters(str));
                        break;
                    }
                    case 17: {
                        Console.WriteLine("Enter the String");
                        string str = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.IsPalidrome(str)); 
                        break;
                    }
                    case 18:
                    {
                        Console.WriteLine("Enter the String");
                        string str = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.ReverseString(str));
                        break;
                    }   
                    case 19:
                    {
                        Console.WriteLine("Enter The String");
                        string str = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.ConvertUpperCase(str));
                        break;
                    }
                    case 20:
                    {
                        Console.WriteLine("Enter The String");
                        string str = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.ConvertLowerCase(str));
                        break;
                    }
                    case 21:
                    {
                        Console.WriteLine("Enter the String 1");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter The String 2");
                        string str2 = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.CombineTwoSentence(str1, str2));
                        break;
                    }   
                    case 22:
                    {
                        Console.WriteLine("Enter The string");
                        string str = Console.ReadLine();
                        Console.WriteLine(newStringFunctions.CountWords(str));
                        break;
                    }
                    case 23:
                    {
                        Console.WriteLine("Enter The String");
                        string mainstr = Console.ReadLine();
                        Console.WriteLine("Enter The Substring");
                        string str= Console.ReadLine();
                        Console.WriteLine(newStringFunctions.SearchSubstring(str,mainstr));
                        break;
                    }
                    
            }
        }
    }
}