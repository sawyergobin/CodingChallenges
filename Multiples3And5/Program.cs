using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //+++Challenge+++
            //If we list all the natural numbers below 10
            //that are multiples of 3 or 5, we get 3, 5,
            //6 and 9.The sum of these multiples is 23.

            //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

            //for up to 1000, keep making multiples and store them into a collection

            //+++Solution+++
            //I designed my solution to be as dynamic and reusuble as possible. This has options for testing
            //and the ability to change the challenge numbers and retain functionality

            //Storing the parts of the problem as variables so the solution is dynamic
            int multiple1 = 3;
            int multiple2 = 5;
            int topNum = 1000;

            //I chose to use a list of multiples so that they could be accessed for advanced functionality if needed
            // Null initialization to be updated in the loop
            List<int> multiplesList1 = new List<int>(); 
            List<int> multiplesList2 = new List<int>();

            //How many times does the loop need to run? Store the result in variables.
            //Ints won't return fractional values or remainders so this operation is straightforward
            int repeatNum1 = topNum / multiple1;
            //Console.WriteLine(repeatNum1); make sure the result is right. Can be uncommented for testing
            int repeatNum2 = topNum / multiple2;
            //Console.WriteLine(repeatNum2); Uncomment for testing

            //Goal: Perform the math as many times as needed and update the list.
            for (int i = 1; i < repeatNum1; i++) //using i as our multiplier allows for incrementation here
            {
                //Get the new multiple
                int newNum = i * multiple1;
                //Add that new value to the list (If not using lists, just add to a running total variable here)
                multiplesList1.Add(newNum);

                //Uncomment below for testing
                //Console.WriteLine(newNum);
            }

            int multiple1Sum = multiplesList1.Sum();
            //Uncomment below for testing
            //Console.WriteLine(multiple1Sum);

            //Goal: Repeat the functionality for multiple2
            for (int i = 1; i < repeatNum2; i++)
            {
                //Get the new multiple
                int newNum = i * multiple2;
                multiplesList2.Add(newNum);

                //Uncomment below for testing
                //Console.WriteLine(newNum);
            }

            int multiple2Sum = multiplesList2.Sum();

            //Find the lowest product and run it through the same math
            int exNum = multiple1 * multiple2;
            List<int> excludes = new List<int>();
            int exRepeatTop = topNum / exNum;
            for (int i = 1; i < exRepeatTop; i++)
            {
                int newExc = i * exNum;
                excludes.Add(newExc);
                //Console.WriteLine(newExc);
            }
            
            //Uncomment below for testing
            //Console.WriteLine(multiple2Sum);

            //Get total sum as an int
            int totalSum = multiple1Sum + multiple2Sum;
            //Exclude duplicates
            totalSum -= excludes.Sum();

            Console.WriteLine($"The sum of all multiples of {multiple1} or {multiple2} below {topNum} are:" +
                $"\n {totalSum:n0}");

            //Idea for extra functionality: Gather multiples and topNum from user input.

        }//end Main()
    }//end Program
}//end Namespace
