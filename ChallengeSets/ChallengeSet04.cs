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
            string[] strings = {};
            int minLength = strings.Min(y => y.Length);
            return minLength;
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
            throw new NotImplementedException();
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
            object majority = null;
            int count = 0;
            object[] array = { };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(majority))
                {
                    count++;
                }
            }
            if (count > (array.Length / 2))
            {
                return true;
            }
            return false;

        }
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double result = 0;
            double average = numbers.Average();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }
            return average;
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
