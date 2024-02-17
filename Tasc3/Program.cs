int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
int min=999999;
int max=-999999;
int imin;
int imax;
for(int i=0;i<n;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
if (arr[i]<min)
    {
        min=arr[i];
        imin=i;

    }
if (arr[i]>max)
    {
        max=arr[i];
        imax=i;
    
    }
}
System.Console.WriteLine(min);
System.Console.WriteLine(max);

// for (int i = min; i <= max; i++)
// {
// System.Console.WriteLine(arr[i]);
// }