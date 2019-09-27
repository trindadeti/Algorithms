using AmazonOnlineAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tree tree = new Tree();
            //tree.buildTree();


            List<int> array1 = new List<int>();

            array1.Add(-1);
            array1.Add(3);
            array1.Add(8);
            array1.Add(2);
            array1.Add(9);
            array1.Add(5);

            List<int> array2 = new List<int>();

            array2.Add(4);
            array2.Add(1);
            array2.Add(2);
            array2.Add(10);
            array2.Add(5);
            array2.Add(20);

            int target = 24;
            ArrayOperation arrayOperation = new ArrayOperation();


            var result = arrayOperation.Calculate(array1, array2, target); 
        }
    }
}
