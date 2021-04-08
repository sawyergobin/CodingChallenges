using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //+++Challenge+++
            //Starting with 1, 1
            //What is the index of the first term in the Fibonacci sequence to contain 10 digits?

            //+++Solution+++
            //Set up the variables to be used
            int num1 = 1;
            int num2 = 1;
            int fibResult = 0;
            long upperLimit = 1000000000;
            //I need to store the values in the sequence in a list to be able to access them
            //via numeric indexing. List<t> is initialized below. I chose this so I'd have access to a numeric
            //index without needing to utilize unboxing
            List<int> fibSeqNums = new List<int>() { num1, num2 };
            
            do
            {
                //Emulate the fibonacci sequence
                fibResult = num1 + num2;
                num1 = num2;
                num2 = fibResult;

                //Add the result to the list
                fibSeqNums.Add(fibResult);
                //Uncomment below for testing
                Console.WriteLine(fibResult);
                
            //I decided to make a variable for upperLimit so I could reuse it in the query and string below
            } while (fibResult < upperLimit);

            //Here I filter the results using Linq Syntax (knowing only 1 value will be returned)and run IndexOf() on it
            int lastResultIndex = fibSeqNums.IndexOf(fibSeqNums.Where(x => x > upperLimit).FirstOrDefault());

            Console.WriteLine($"The index of the result that breaks the limit of {upperLimit:n0} is {lastResultIndex}");
            




        }
    }
}
