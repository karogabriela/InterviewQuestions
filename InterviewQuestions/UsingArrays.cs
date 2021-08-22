using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class UsingArrays
    {
        /// <summary>
        /// This function takes an array of integers and returns the number of triplets in the array.
        /// 
        /// A triplet is three consecutive identical integers.
        /// 
        /// For example: 
        ///     [1,1,2,2,1] contains no triplets.
        ///     [3, 7, 2, 2, 2, 5] contains 1 triplet
        ///     [4, 3, 3, 3, 6, 1, 1, 1] contains 2 triplets
        ///     [5, 5, 5, 5, 5, 5] contains 2 triplets as each value can only be counted in a single triplet.
        /// </summary>
        /// <param name="input">Array to be used to find number tripplets.</param>
        /// <returns></returns>
        public int FindTriplets(int[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if((i+2)<input.Length && (i%2) != 0)
                {
                    if(input[i] == input[i+1] && input[i] == input[i + 2])
                    {
                        result += 1;
                    }
                }
            }
            return result;
        }
    }
}
