int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
int cnt=0;
for(int i=0;i<n;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int b=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
if (arr[i]==b)
    {
cnt++;
    }
}
System.Console.WriteLine(cnt);