using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = new string(word.Reverse().ToArray());
            if (word == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
