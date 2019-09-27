using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOnlineAssessment
{
    public class ArrayOperation
    {
        public (int, int) Calculate(IList<int> array1, IList<int> array2, int target)
        {
            List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();

            foreach (var item1 in array1)
            {
                foreach (var item2 in array2)
                {
                    tupleList.Add(new Tuple<int, int, int>(item1, item2, Math.Abs(item1 + item2 - target)));

                }
            }

            tupleList.Sort((x, y) => y.Item3.CompareTo(x.Item3));

            return (tupleList[tupleList.Count - 1].Item1, tupleList[tupleList.Count - 1].Item2);
        }

        public (int, int) GetPairMultiple(int[] a1, int target)
        {
            int nextMultiple = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] > 0)
                    nextMultiple = target / a1[i];

                for (int j = i + 1; j < a1.Length; j++)
                {
                    if (a1[j] == nextMultiple)
                        return (a1[i], a1[j]);
                }
            }

            return (0, 0);
        }

        public int GetTheMostReccurancyNumber(int[] array, int[] array2)
        {
            Array.Sort(array);
            int maxCount = -1; int maxItem = -1;

            IDictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var item in array)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }

                if (dictionary[item] > maxCount)
                {
                    maxCount = dictionary[item];
                    maxItem = item;
                }
            }

            return maxItem;
        }
    }
    
}
