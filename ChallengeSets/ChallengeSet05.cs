using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int output = ((startNumber / n) + 1) * n;
            return output;
            
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                    return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int count = 0;
            for(int i = 0; i < numbers.Length-1; ++i)
            {
                if (numbers[i] % 2 == 0)
                {
                    count += numbers[i+1];
                }
            }
            return count;
        }

        public string TurnWordsIntoSentence(string[] words) 
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] FourthElement = new double[0];
            if (elements == null)
            {
                return FourthElement;
            }
            return elements.Where((x, i) => i % 4 == 3).ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = nums[i] + nums[k];
                        if (sum == targetNumber)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
