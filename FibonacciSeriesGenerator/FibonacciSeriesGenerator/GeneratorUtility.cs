using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesGenerator
{
    /// <summary>
    /// Generator class is a Utility class that is used for getting a valid input, generating a Fibonnaci series & Printing this series.
    /// </summary>
    public class GeneratorUtility
    {
        /// <summary>
        /// GetValidInput Method is a function which does not return the control valid input for Fibonnaci Series is not provided by the user.
        /// </summary>
        /// <returns>returns a number either equals to or greater than 2</returns>
        public static int GetValidInput()
        {
            GetValidInput:
            Console.WriteLine("Please enter the number of items terms that you would like me to generate:");
            var input = Console.ReadLine();
            var i = 1;
            if (!Int32.TryParse(input, out i))
            {
                Console.WriteLine("Invalid Input Keyed in, Please retry!");
                goto GetValidInput;
            }
            else if (i < 3)
            {
                Console.WriteLine("Please enter a number greater than 2!");
                goto GetValidInput;
            }
            return i;
        }
        /// <summary>
        /// Generates an integer array of Fibonnaci Series.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Returns an array of Fibonnaci series elements in the form of an integer array</returns>
        public static int[] GetFibonacciSeries(int i)
        {
            var result = new int[i];
            try
            {
                result[0] = 0;
                result[1] = 1;
                for (int j = 2; j < i; j++)
                {
                    result[j] = result[j - 2] + result[j - 1];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured, Following are exception details:" + ex.ToString());
            }
            return result;
        }
        /// <summary>
        /// Prints the number or elements to be printed and the Fibonnaci Series
        /// </summary>
        /// <param name="i">number of terms in fibonnaci Series</param>
        /// <param name="result">Fobannci series interger array</param>
        public static void PrintSeries(int i, int[] result)
        {
            var strResult = string.Join(", ", result);
            Console.WriteLine($"Fibonnaci Series for {i} terms is {strResult}");
        }
             
    }
}
