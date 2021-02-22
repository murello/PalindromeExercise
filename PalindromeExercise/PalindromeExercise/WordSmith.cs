using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {

            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
          
        }
    }
}
