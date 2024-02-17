 void Swap(ref int a, ref int b)
 {
  int c=a;
  a=b;
  b=c;
//   System.Console.WriteLine(a+" "+b);

 }
 System.Console.Write("x= ");
 int a=Convert.ToInt32(Console.ReadLine());
 System.Console.Write("y= ");
 int b=Convert.ToInt32(Console.ReadLine());
 Swap(ref a,ref b);
 System.Console.WriteLine("x= "+a);
 System.Console.Write("y= "+b);

