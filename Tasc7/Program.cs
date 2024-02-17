int sum=0;
 int SumOfDigits(int n)
 {
    for (int i = n; i >0; i/=10)
    {
        sum=sum+i%10;
    }
    return sum;

 }
 int n=Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("The sum of the digits of the number 1234 is : "+SumOfDigits(n));