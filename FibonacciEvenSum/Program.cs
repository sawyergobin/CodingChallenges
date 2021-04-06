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
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            int num1 = 1;
            int num2 = 2;
            int fibResult = 0;
            int runningTotal = 0;

            while (num1+num2 < 4000000)
            {
                fibResult = num1 + num2;
                num1 = num2;
                num2 = fibResult;
                //Uncomment below for testing
                //Console.WriteLine(fibResult);
                if (fibResult % 2 ==0)
                {
                    runningTotal += fibResult;
                }
                //uncomment below for testing
                //Console.WriteLine("RT =" +runningTotal);
            }

            Console.WriteLine($"The sum of all even values in the Fibonacci Sequence without any " +
                $"\nvalues in the sequence surpassing 4,000,000 is {runningTotal:n0}.");


        }
    }
}
