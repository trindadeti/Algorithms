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
            var result = arrayOperation.GetPairMultiple(a1,target);

            //Assert

            Assert.AreEqual(result.Item1, 4);
            Assert.AreEqual(result.Item2, 5);
        }

        [TestMethod]
        public void Validate_Which_Number_Has_More_Recurrency()
        {
            //Arrange
            int[] array = { 1, 3, 28, 3, 2, 1, 28,  28 ,28 };

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
            int[] array1 = { 1, 3, 28, 46, 48, 70};

            int[] array2 = { 28, 48, 70};

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

            int[] array2 = { 5, 1, 7, 6, 2, 3, 4  };

            //Act
            ArrayOperation arrayOperation = new ArrayOperation();
            bool result = arrayOperation.IsRotaion(array1, array2);

            //Assert
            Assert.AreEqual(result, false);
        }
    }
}
