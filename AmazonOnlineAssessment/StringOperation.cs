using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonOnlineAssessment
{
    public class StringOperation
    {
        public bool isOneAway(string s1, string s2)
        {
            if (Math.Abs(s1.Length - s2.Length) == 2)
                return false;
            else if (s1.Length == s2.Length)
                return IsOneAwaySameLength(s1, s2);
            else if (s1.Length > s2.Length)
                return IsOneAwayDifferentLength(s1, s2);
            else if (s1.Length < s2.Length)
                return IsOneAwayDifferentLength(s2, s1);
            return true;
        }

        public bool IsOneAwaySameLength(string s1, string s2)
        {
            int errors = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    errors++;
                }

                if (errors > 1)
                    return false;
            }

            return true;
        }

        public bool IsOneAwayDifferentLength(string s1, string s2)
        {
            int errors = 0;
            int index = 0;

            while (index < s2.Length)
            {
                if (s1[index + errors] == s2[index])
                {
                    index++;
                }
                else
                {
                    errors++;
                    if (errors > 1)
                        return false;
                }
            }

            return true;
        }

    }
}