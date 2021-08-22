using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class PrimeNumbers
    {
        /// <summary>
        /// Check if a number is prime number
        /// </summary>
        /// <param name="number">Number to be validated whether is a prime or not.</param>
        /// <returns></returns>
        public bool CheckPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
