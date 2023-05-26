using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Практика_5_задание_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainWindow = new MainWindow();
        [TestMethod]
        public void TestMethod1()
        {
            
            


            int number = 12345;
            int expected = 5;

            // Act
            int actual = mainWindow.GetLastDigit(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLastDigit_NegativeNumber_ReturnsLastDigit()
        {
            int number = 12345;
            int expected = 5;

            // Act
            int actual = mainWindow.GetLastDigit(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLastDigit_Zero_ReturnsZero()
        {
            // Arrange
            int number = 0;
            int expected = 0;

            // Act
            int actual = mainWindow.GetLastDigit(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
