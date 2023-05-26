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

namespace Задание_2
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
        public double CalculateExpression(double x, int n)
        {
            return Math.Pow(x, n) / n;
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(inputX.Text);

            double result = CalculateExpression(x, 2) + CalculateExpression(x, 4) + CalculateExpression(x, 6);

            resultTextBlock.Text = $"Результат:{result:f2} "; 
        }
    }
}
