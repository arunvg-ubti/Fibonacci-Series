# Time Complexity Calculation
## Below is the code

```csharp
//declaring and initializing first two terms of the fibonacci series
int a=0; //O(1)
int b=1; //O(1)

//Prompting the user for input
Console.WriteLine("Enter the number of terms in Fibonacci Series:- "); //O(1)

//Storing the above input in the variable 'num' with string datatype 
string num=Console.ReadLine()!; //O(n)

//Converting to string to int datatype
int n=int.Parse(num); //O(1)

//try block
try //O(n) + O(1) = O(n)
{
    if(n>0) //O(n)
    {
        Console.WriteLine("The Fibonacci Series is: "); //O(1)
        Console.WriteLine(a); //O(1)
        Console.WriteLine(b); //O(1)
        for(int i=2;i<n;i++) //O(n)
        {
            int c=a+b; //O(1)
            Console.WriteLine(c); //O(1)
            a=b; //O(1)
            b=c; //O(1)
        }
    //fetches the fibonacci series if input is valid
    }
    else //O(1)
    {
        throw new Exception("Invalid Input"); //throw statement -> throws an exception to catch block in case of errors //O(1)
    }
}

//catch block for exception handling
catch(Exception e) //O(1)
{
    Console.WriteLine(e.Message); //O(1)
}

//finally block which gets executed irrespective of whether an exception is thrown or not
finally //O(1)
{
    Console.WriteLine("The execution has been completed."); //O(1)
}
```
## Total Time Complexity = O(1) + O(1) + O(1) + O(n) + O(1) + O(n) + O(1) + O(1) = O(n)