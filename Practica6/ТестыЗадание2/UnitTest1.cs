using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Задание_2;

namespace ТестыЗадание2
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow mainWindow = new MainWindow();

        [TestMethod]
        public void CalculateExpression_PositiveValues_ReturnsCorrectResult()
        {
            // Arrange
            double x = 2.5;
            int n = 3;
            double expected = 2.5 * 2.5 * 2.5 / 3;

            // Act
            double actual = mainWindow.CalculateExpression(x, n);

            // Assert
            Assert.AreEqual(expected, actual, 0.001); // Проверяем с погрешностью 0.001
        }

        [TestMethod]
        
        public void CalculateExpression_NegativeExponent_ReturnsCorrectResult()
        {
            // Arrange
            double x = 4;
            int n = -2;
            double expected = -0.03125;

            // Act
            double actual = mainWindow.CalculateExpression(x, n);

            // Assert
            Assert.AreEqual(expected, actual, 0.001);
        }




        [TestMethod]
        public void CalculateExpression_ZeroExponent_ReturnsInfinity()
        {
            // Arrange
            double x = 3;
            int n = 0;
            double expected = double.PositiveInfinity; // Ожидается бесконечность

            // Act
            double actual = mainWindow.CalculateExpression(x, n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
