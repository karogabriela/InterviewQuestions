using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterviewQuestions
{
    public class LambdaExpressions
    {
        /// <summary>
        /// Returns the count of how many time a pattern expression appears.
        /// </summary>
        /// <returns></returns>
        public int GetTotalCountFromArray(string[] array, string pattern)
        {
            int counter = 0;
            return counter = array.Count(x => x.StartsWith(pattern, StringComparison.CurrentCultureIgnoreCase));
        }

        /// <summary>
        /// Returns the count of how many time a regular expression appears.
        /// </summary>
        /// <returns></returns>
        public int GetTotalCountWithRegex(string[] array, string pattern)
        {
            int counter = 0;
            return counter = array.Count(x => {
                return Regex.IsMatch(x, "^[pattern]");
            });
        }
    }
}
