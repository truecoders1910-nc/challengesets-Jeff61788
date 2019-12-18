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
            }
            if (result % 2 != 0)
            {
                return true;
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
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }
        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int num = 0; num < 100; num++)
            {
                if (num % 2 != 0)
                {
                    nums.Add(num);
                }
            }
            return nums.ToArray();
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
