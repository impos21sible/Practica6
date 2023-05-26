using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie4;

namespace ТестыЗадания4
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainWindow = new MainWindow();



        [TestMethod]
        public void Function_LessThan2_ReturnsSquare()
        {
            // Arrange
            double x = 1;
            double expected = 4;

            // Act
            double actual = mainWindow.Function(x);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Function_Between2And3_ReturnsFraction()
        {
            // Arrange
            double x = 2.5;
            double expected = -0.5;

            // Act
            double actual = mainWindow.Function(x);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Function_GreaterThanOrEqual3_ReturnsZero()
        {
            // Arrange
            double x = 4;
            double expected = 0;

            // Act
            double actual = mainWindow.Function(x);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }








    }
}