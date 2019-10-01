using System;
using System.Collections.Generic;
using AmazonOnlineAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ArrayOperationTest
    {
        [TestMethod]
        public void Validate_IfItsReturningSmallerDistance()
        {
            //Arrange
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

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            var result = arrayOperation.Calculate(array1, array2, target);

            //Assert

            Assert.AreEqual(result.Item1, 5);
            Assert.AreEqual(result.Item2, 20);
        }

        [TestMethod]
        public void Validate_which_pairs_multiple_20()
        {
            //Arrange
            int[] a1 = { -1, 3, 4, 2, 9, 5 };

            int target = 20;

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            var result = arrayOperation.GetPairMultiple(a1, target);

            //Assert

            Assert.AreEqual(result.Item1, 4);
            Assert.AreEqual(result.Item2, 5);
        }

        [TestMethod]
        public void Validate_Which_Number_Has_More_Recurrency()
        {
            //Arrange
            int[] array = { 1, 3, 28, 3, 2, 1, 28, 28, 28 };

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            int result = arrayOperation.GetTheMostReccurancyNumber(array);

            //Assert

            Assert.AreEqual(result, 28);
        }

        [TestMethod]
        public void validate_which_values_there_are_in_commom_between_the_two()
        {
            //Arrange
            int[] array1 = { 1, 3, 28, 46, 48, 70 };

            int[] array2 = { 28, 48, 70 };

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            IEnumerable<int> result = arrayOperation.GetIntersectElements(array1, array2);


            //Assert
            Assert.AreEqual(28, 28);
        }

        [TestMethod]
        public void validate_if_arrayA_is_rotation_of_arrayB()
        {
            //Arrange
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };

            int[] array2 = { 2, 3, 4, 5, 6, 7, 1 };

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            bool result = arrayOperation.IsRotation(array1, array2);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void return_first_non_repeating_letter()
        {
            //Arrange
            string str = "aabcc";
            string strA = "aabccbeffeh";
            string strB = "abbcc";
            string strC = "aabbcc";

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            char? result = arrayOperation.NonRepeating(str);
            char? resultA = arrayOperation.NonRepeating(strA);
            char? resultB = arrayOperation.NonRepeating(strB);
            char? resultC = arrayOperation.NonRepeating(strC);

            //Assert
            Assert.AreEqual(result, 'b');
            Assert.AreEqual(resultA, 'h');
            Assert.AreEqual(resultB, 'a');
            Assert.AreEqual(resultC, null);
        }

        public void validate_if_this_string_is_one_way_of_the_other()
        {
            //Arrange
            string str = "aabcc";
            string strA = "aabccbeffeh";
            string strB = "abbcc";
            string strC = "aabbcc";

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            char? result = arrayOperation.NonRepeating(str);
            char? resultA = arrayOperation.NonRepeating(strA);
            char? resultB = arrayOperation.NonRepeating(strB);
            char? resultC = arrayOperation.NonRepeating(strC);

            //Assert
            Assert.AreEqual(result, 'b');
            Assert.AreEqual(resultA, 'h');
            Assert.AreEqual(resultB, 'a');
            Assert.AreEqual(resultC, null);
        }

        [TestMethod]
        public void validate()
        {
            int[] array = { 1, 0, 0, 0, 0, 1, 0, 0 };
            int[] array2 = { 1, 1, 1, 0, 1, 1, 1, 1 };
            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] result = arrayOperation.cellCompete(array, 1);
            int[] result2 = arrayOperation.cellCompete(array2, 2);

            int[] arrayResult = { 0, 1, 0, 0, 1, 0, 1, 0 };
            int[] arrayResult2 = { 0, 0, 0, 0, 0, 1, 1, 0 };

            //Assert
            Assert.AreEqual(result[0], arrayResult[0]);
            Assert.AreEqual(result[1], arrayResult[1]);
            Assert.AreEqual(result[2], arrayResult[2]);
            Assert.AreEqual(result[3], arrayResult[3]);
            Assert.AreEqual(result[4], arrayResult[4]);
            Assert.AreEqual(result[5], arrayResult[5]);
            Assert.AreEqual(result[6], arrayResult[6]);
            Assert.AreEqual(result[7], arrayResult[7]);

            Assert.AreEqual(result2[0], arrayResult2[0]);
            Assert.AreEqual(result2[1], arrayResult2[1]);
            Assert.AreEqual(result2[2], arrayResult2[2]);
            Assert.AreEqual(result2[3], arrayResult2[3]);
            Assert.AreEqual(result2[4], arrayResult2[4]);
            Assert.AreEqual(result2[5], arrayResult2[5]);
            Assert.AreEqual(result2[6], arrayResult2[6]);
            Assert.AreEqual(result2[7], arrayResult2[7]);
        }

        [TestMethod]
        public void validate_GDC()
        {
            //Arrange
            int[] a = { 2, 3, 4, 5, 6 };

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            int result = arrayOperation.findGCD(a, 5);

            //Assert
            Assert.AreEqual(result, 1);
        }


    }
}
