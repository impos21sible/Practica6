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

namespace Практика_5_задание_1
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

        public int GetLastDigit(int number)
        {
            return number % 10; // Возвращает младшую цифру числа
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(inputA.Text);
            int b = int.Parse(inputB.Text);

            int result = GetLastDigit(a) + GetLastDigit(b);

            resultTextBlock.Text = result.ToString();
        }
    }
}
