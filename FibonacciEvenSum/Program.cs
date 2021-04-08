using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //+++Challenge+++
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.


            //+++Solution+++
            //Set up the variables I need to be reassigned and input starting values for fib nums
            int num1 = 1;
            int num2 = 2;
            int fibResult = 0;
            //This needs to start at 2 to include the starting value of 2 as an even 
            int runningTotal = 2;

            //set the upper limit. Could also be a variable if different upper limits were needed
            while (num1+num2 < 4000000)
            {
                //Emulate the sequence
                fibResult = num1 + num2;
                num1 = num2;
                num2 = fibResult;
                //Uncomment below for testing
                Console.WriteLine(fibResult);

                //check for even nums. If even, add to runningTotal
                if (fibResult % 2 ==0)
                {
                    runningTotal += fibResult;
                }
                
                //uncomment below for testing
                Console.WriteLine("RT =" +runningTotal);
            }

            //output RT to console.
            Console.WriteLine($"The sum of all even values in the Fibonacci Sequence without any " +
                $"\nvalues in the sequence surpassing 4,000,000 is {runningTotal:n0}.");


        }
    }
}
