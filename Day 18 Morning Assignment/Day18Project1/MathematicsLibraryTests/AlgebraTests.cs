using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_one_to_seven_Input()
        {
            //Arrange
            int n = 5;
            int expected = 120;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negative_Input()
        {
            //Arrange
            int n = -1;
            int expected = -9999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_greater_than_seven_Input()
        {
            //Arrange
            int n = 8;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPalindromeTest()
        {
            //Arrange
            int n = 121;
            bool expected = false;

            //Act
            bool actual = Algebra.IsPalindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}