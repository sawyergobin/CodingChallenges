using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             The following iterative sequence is defined for the set of positive integers:

                n → n/2 (n is even)
                n → 3n + 1 (n is odd)

                Using the rule above and starting with 13, we generate the following sequence:
                13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

                It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it
                has not been proven yet (Collatz Problem), it is thought that all starting numbers finish at 1.

                Which starting number, under one thousand, produces the longest chain?

                NOTE: Once the chain starts the terms are allowed to go above one thousand.
             */
            
            //Create a variable to store our number and perform operations on
            int num;
            //Create a dictionary to store the eventual chain lengths along with their starting number
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>(); 

            //Since I know the amount of times an operation must be performed, a for loop makes the most sense.
            for (int i = 1; i < 1000; i++)
            {
                //These vars need reset every time the loop runs
                int chainCounter = 1;
                num = i;

                //This while loop emulates the Collatz Problem
                while (num != 1)
                {
                    //If num is even, divide by 2
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        //else num*3+1
                        num = num * 3 + 1;
                    }
                    //This variable is incremented every loop and counts the length
                    //of the process
                    chainCounter++;
                
                    //This loop will break when the number reaches 1 and at 
                    //that point, chainCounter will be holding the length of the process
                }//end while
                //uncomment below for testing
                //Console.WriteLine($"i = {i}, counter = {chainCounter}");

                //Store the starting value (i) and the length of the chain(chainCounter)
                keyValuePairs.Add(i, chainCounter);
            }

            //Find the longest length
            int maxChainLength = keyValuePairs.Values.Max();
            //Find which KeyValuePair that the maxChainLength belongs to (Linq syntax)
            KeyValuePair<int, int> number = keyValuePairs.Where(x => x.Value == maxChainLength).FirstOrDefault();
            
            //The key of that KVP holds the number that has the longest chain, so output it.
            Console.WriteLine($"{number.Key}");
        }
    }
}
