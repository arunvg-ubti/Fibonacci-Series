// See https://aka.ms/new-console-template for more information

//declaring and initializing first two terms of the fibonacci series
int a=0;
int b=1;

//Prompting the user for input
Console.WriteLine("Enter the number of terms in Fibonacci Series:- ");

//Storing the above input in the variable 'num' with string datatype 
string num=Console.ReadLine()!;

//Converting to string to int datatype
int n=int.Parse(num);

//if the input is valid condition
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
//fetches the fibonacci series if input is valid
}

//handles invalid input
else
{
    Console.WriteLine("Invalid Input");
}