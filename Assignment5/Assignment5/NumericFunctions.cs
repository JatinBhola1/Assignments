namespace Assignment5
{
    public class NumericFunctions
    {
        public int  Add(params int[] nums)
        {
            return nums.Sum();
        }
        public int Subtract( int? num1,int? num2) 
        {
            num1 = num1 ?? 10;
            num2=num2 ?? 10;
            return num1.Value - num2.Value;
        }
        public int Product(int? num1,int? num2)
        {
            num1=num1 ?? 10;
            num2=num2 ?? 10;
            return num1.Value * num2.Value;
        }
        public int Divide(int? num1,int? num2) 
        {
            num1 = num1 ?? 10;
            num2 = num2 ?? 10;
            return num1.Value / num2.Value;
        }
        public int MaxNum(params int[] nums)
        {
            return nums.Max();
        }
        public int MinNum(params int[] nums)
        {
            return nums.Min();
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0?true:false;
        }
        public bool IsOdd(int num)
        {
            return num%2!=0?true:false;
        }
        public bool IsPrime(int num)
        { 
            for(int i=2;i*i<=num;i++)
            {
                if(num%i==0)
                 return false; 
            }
            return true;
        }

    }
}