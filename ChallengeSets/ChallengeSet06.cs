using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            if (words.Contains(word) == true)
            {
                return true;
            }
            if (words.Contains(word, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > max)
                            max = count;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] emptyArr = new double[] { };
            if (elements == null)
            {
                return emptyArr;
            }
            if (n <= 0)
            {
                return emptyArr;
            }
            double[] result = new double[elements.Count / n];
            for (int i = n -1; i < elements.Count; i += n)
            {
                result[i / n] = elements[i];
            }
            return result;
        }
    }
}
