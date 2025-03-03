// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            //try block
            try
            {   
                //declaring and initializing first two terms of the fibonacci series
                int a=0;
                int b=1;

                //Prompting the user for input
                Console.WriteLine("Enter the number of terms in Fibonacci Series:- ");

                //Storing the above input in the variable 'num' with string datatype 
                string num=Console.ReadLine()!;

                if(string.IsNullOrEmpty(num)) //input validation block
                {
                    throw new Exception("Number of terms cannot be null! Please provide a valid input!");
                }

                //Converting to string to int datatype
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
                //fetches the fibonacci series if input is valid
                }
                else
                {
                    throw new Exception("Invalid Input"); //throw statement -> throws an exception to catch block in case of errors
                }
            }

            //catch block for exception handling
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                continue; //to continue with next iteration after handling errors
            }

            //finally block which gets executed irrespective of whether an exception is thrown or not
            finally
            {
                Console.WriteLine("The execution has been completed.");
            }
            break;
        }
    }
}
