using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    result += number;
                }
                if (result % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(ch => char.IsUpper(ch) && password.Any(ch => char.IsLower(ch) && password.Any(ch => char.IsDigit(ch)))))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            
            foreach (var item in val)
            {
                return val[];
            }
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
