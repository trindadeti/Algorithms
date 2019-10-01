using System;
using System.Collections.Generic;
using AmazonOnlineAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class StringOperationTest
    {
        
        [TestMethod]
        public void validate_one_away()
        {
            //Arrange
            string sla = "abcde";
            string slb = "abfde";

            string sla1 = "abcde";
            string slb1 = "abfxe";

            string sla2 = "abcde";
            string slb2 = "abde";

            string sla3 = "abde";
            string slb3 = "abcde";

            //Act
            StringOperation stringOperation = new StringOperation();
            bool result = stringOperation.isOneAway(sla, slb);
            bool result1 = stringOperation.isOneAway(sla1, slb1);
            bool result2 = stringOperation.isOneAway(sla2, slb2);
            bool result3 = stringOperation.isOneAway(sla3, slb3);

            //Assert
            Assert.AreEqual(result, true);
            Assert.AreEqual(result1, false);
            Assert.AreEqual(result2, true);
            Assert.AreEqual(result3, true);
        }

    }
}
