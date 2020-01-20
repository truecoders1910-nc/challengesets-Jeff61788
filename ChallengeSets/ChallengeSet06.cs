﻿using System;
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
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
