// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int a=0;
int b=1;
Console.WriteLine("Enter the number of terms in Fibonacci Series:- ");
string num=Console.ReadLine()!;
int n=int.Parse(num);
if(n>0)
{
    Console.WriteLine("The Fibonacci Series is: ");
    Console.WriteLine(a);
    Console.WriteLine(b);
    for(int i=2;i<n;i++)
    {
        int c=a+b;
        Console.WriteLine(c);
        a=b;
        b=c;
    }
}
else
{
    Console.WriteLine("Invalid Input");
}