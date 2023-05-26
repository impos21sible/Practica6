using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double TriangleP(double a, double h)
        {
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2)); // Вычисление боковой стороны треугольника
            double perimeter = 2 * b + a; // Вычисление периметра треугольника

            return perimeter;
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double a1 = double.Parse(inputA1.Text);
            double h1 = double.Parse(inputH1.Text);
            double a2 = double.Parse(inputA2.Text);
            double h2 = double.Parse(inputH2.Text);
            double a3 = double.Parse(inputA3.Text);
            double h3 = double.Parse(inputH3.Text);

            double perimeter1 = TriangleP(a1, h1);
            double perimeter2 = TriangleP(a2, h2);
            double perimeter3 = TriangleP(a3, h3);

            resultTextBlock.Text = $"Периметр треугольника 1: {perimeter1:f2}\n" +
                                   $"Периметр треугольника 2: {perimeter2:f2}\n" +
                                   $"Периметр треугольника 3: {perimeter3:f2}";
        }
    }
}
