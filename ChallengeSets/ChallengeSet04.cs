using System;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                if (num % 2 != 0)
                {
                    result -= num;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //string[] strArr = str1.Split(' ');
            //string[] strArr2 = str2.Split(' ');
            //string[] strArr3 = str3.Split(' ');
            //string[] strArr4 = str4.Split(' ');
            //int maxx = int.MaxValue;

            //foreach (string item in strArr)
            //{
            //    if (item.Length < maxx)
            //    {
            //        maxx = item.Length;
            //    }
            //}
            //foreach (string item in strArr2)
            //{
            //    if (item.Length < maxx)
            //    {
            //        maxx = item.Length;
            //    }
            //}
            //foreach (string item in strArr3)
            //{
            //    if (item.Length < maxx)
            //    {
            //        maxx = item.Length;
            //    }
            //}
            //foreach (string item in strArr4)
            //{
            //    if (item.Length < maxx)
            //    {
            //        maxx = item.Length;
            //    }
            //}
            //return maxx;
            int word1 = str1.Length;
            int word2 = str2.Length;
            int word3 = str3.Length;
            int word4 = str4.Length;
            int count = 0;
            if (word1 < word2 && word1 < word3 && word1 < word4)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    count++;
                }
            }
            if (word2 <= word1 && word2 < word3 && word2 < word4)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    count++;
                }
            }
            if (word3 < word1 && word3 < word2 && word3 < word4)
            {
                for (int i = 0; i < str3.Length; i++)
                {
                    count++;
                }
            }
            if (word4 <= word1 && word4 <= word2 && word4 <= word3)
            {
                for (int i = 0; i < str4.Length; i++)
                {
                    count++;
                }
            }
            if (word1 == word2 & word1 == word3 && word1 < word4)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    count++;
                }
            }
            return count;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = { number1, number2, number3, number4 };
            return array.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            int myInt;
            decimal value;
            if (int.TryParse(input, out myInt))
            {
                return true;
            }
            if (Decimal.TryParse(input, out value))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) nullCount++;
            }
            if (nullCount > objs.Length / 2) return true;
            return false;

        }
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            double sum = 0, count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }

            }
            if ((int)count == 0) return 0;
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
