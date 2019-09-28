using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> listNumber = new List<int>(a1);
            List<int> newListNumber = new List<int>();

            for (int i = 0; i < a1.Length; i++)
            {
                var item = a1[i];
                var nextItem = a1[i + 1];
                newListNumber.Add(item);

                var otherMultiple = target / nextItem;

                if (listNumber.Contains(otherMultiple)) {
                    return (nextItem, otherMultiple);
                }
            }

            return (0, 0);
        }

        public int GetTheMostReccurancyNumber(int[] array)
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

        public IEnumerable<int> GetIntersectElements(int[] arrayA, int[] arrayB)
        {
            var newData = arrayA.Intersect(arrayB);

            return newData;
        }

        public bool IsRotaion(int[] arrayA, int[] arrayB)
        {

            var value = arrayA[0];
            var indexB = Array.IndexOf(arrayB, value);
            int indexA = 0;


            for (int i = indexB; i < arrayB.Length; i++)
            {
                
                if (arrayB[i] != arrayA[indexA])
                {
                    return false;
                }

                indexA++;
            }

            for (int i = 0; i < indexB; i++)
            {
                if (arrayB[i] != arrayA[indexA])
                {
                    return false;
                }

                indexA++;
            }

            return true;
        }
    }

}