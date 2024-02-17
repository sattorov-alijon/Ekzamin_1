void IncrementArrayElements(ref int  []Arr,ref int n)
{
  
    for(int i=0;i<Arr.Length;i++){

       Arr[i]=Arr[i]+n;
    }
    for(int i=0;i<5;i++)
Console.Write(Arr[i]+",");
}
int n;
int[]Arr =new int[]{1,2,3,4,5};
n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("[");
IncrementArrayElements(ref Arr,ref n);
System.Console.Write("]");
