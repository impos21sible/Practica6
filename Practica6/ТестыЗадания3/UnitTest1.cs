using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zadanie3;

namespace ТестыЗадания3
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainWindow = new MainWindow();

        [TestMethod]
        public void TriangleP_ValidValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            double a = 3;
            double h = 4;
            double expected = 11.5440037453175; // Ожидаемый периметр

            // Act
            double actual = mainWindow.TriangleP(a, h);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }


        [TestMethod]
        public void TriangleP_ZeroValues_ReturnsZeroPerimeter()
        {
            // Arrange
            double a = 0;
            double h = 0;
            double expected = 0; // Ожидаемый периметр: 0

            // Act
            double actual = mainWindow.TriangleP(a, h);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }


        [TestMethod]
        public void TriangleP_NegativeValues_ReturnsCorrectPerimeter()
        {
            // Arrange
            double a = -2;
            double h = -3;
            double expected = 4.32455532033676; // Ожидаемый периметр

            // Act
            double actual = mainWindow.TriangleP(a, h);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}