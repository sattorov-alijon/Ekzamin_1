int n=Convert.ToInt32(Console.ReadLine());
int cnt=0;
int[] arr=new int[n];
for(int i=0;i<n;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < n; i++)
{
cnt=0;
for (int j = 0; j <i; j++)

    if (arr[i]!=arr[j] && i!=j)
    {
        cnt++;
    }
    }
        System.Console.WriteLine(cnt);
