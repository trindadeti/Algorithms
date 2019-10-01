using System;
using System.Collections.Generic;
using AmazonOnlineAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MatrixOperationTest
    {

        [TestMethod]
        public void validate_mine_sweeper()
        {
            //Arrange
            int[][] bombs = new int[2][];
            int[] bomb1 = new int[2] { 0, 0 };
            int[] bomb2 = new int[2] { 0, 1 };

            bombs[0] = bomb1;
            bombs[1] = bomb2;

            //Act
            MatrixOperation matrixOperation = new MatrixOperation();
            int[,] result = matrixOperation.mineSweeper(bombs, 3, 4);

            //Assert
            Assert.AreEqual(result[0, 0], -1);
            Assert.AreEqual(result[0, 1], -1);
            Assert.AreEqual(result[0, 2], 1);
            Assert.AreEqual(result[0, 3], 0);
            Assert.AreEqual(result[1, 0], 2);
            Assert.AreEqual(result[1, 1], 2);
            Assert.AreEqual(result[1, 2], 1);
            Assert.AreEqual(result[1, 3], 0);
            Assert.AreEqual(result[2, 0], 0);
            Assert.AreEqual(result[2, 1], 0);
            Assert.AreEqual(result[2, 2], 0);
            Assert.AreEqual(result[2, 3], 0);
            
        }

    }
}
