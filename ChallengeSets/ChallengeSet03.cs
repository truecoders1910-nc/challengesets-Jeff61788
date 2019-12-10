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
            int[] myArray = new int[50];
            myArray[0] = 1;
            myArray[1] = 3;
            myArray[2] = 5;
            myArray[3] = 7;
            myArray[4] = 9;
            myArray[5] = 11;
            myArray[6] = 13;
            myArray[7] = 15;
            myArray[8] = 17;
            myArray[9] = 19;
            myArray[10] = 21;
            myArray[11] = 23;
            myArray[12] = 25;
            myArray[13] = 27;
            myArray[14] = 29;
            myArray[15] = 31;
            myArray[16] = 33;
            myArray[17] = 35;
            myArray[18] = 37;
            myArray[19] = 39;
            myArray[20] = 41;
            myArray[21] = 43;
            myArray[22] = 45;
            myArray[23] = 47;
            myArray[24] = 49;
            myArray[25] = 51;
            myArray[26] = 53;
            myArray[27] = 55;
            myArray[28] = 57;
            myArray[29] = 59;
            myArray[30] = 61;
            myArray[31] = 63;
            myArray[32] = 65;
            myArray[33] = 67;
            myArray[34] = 69;
            myArray[35] = 71;
            myArray[36] = 73;
            myArray[37] = 75;
            myArray[38] = 77;
            myArray[39] = 79;
            myArray[40] = 81;
            myArray[41] = 83;
            myArray[42] = 85;
            myArray[43] = 87;
            myArray[44] = 89;
            myArray[45] = 91;
            myArray[46] = 93;
            myArray[47] = 95;
            myArray[48] = 97;
            myArray[49] = 99;
            return myArray;
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
