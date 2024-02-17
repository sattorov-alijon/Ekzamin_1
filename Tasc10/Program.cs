void recursiya_toq(int a,int b)
{
    if(a==b)
    System.Console.Write(b);
    else
    {
        recursiya_toq(a,b-1);
        if(b%2!=0)
        System.Console.Write(" "+b);
    }
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

recursiya_toq(a,b);

// void recursiya_juft(int a,int b)
// {
//     if(a==b)
//     System.Console.Write("b");
//     else
//     {
//         recursiya_juft(a,b-1);
//         if(b%2==0)
//         System.Console.Write(" "+b);
//     }
// }
// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());

// recursiya_juft(a,b);