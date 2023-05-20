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

namespace ДопЗадания
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(textBoxA.Text);
                int B = Convert.ToInt32(textBoxB.Text);
                int C = Convert.ToInt32(textBoxС.Text);
                int k = (A / C) * (B / C);
                int a = (A * B) - (k * C * C);
                textBoxOtvet.Text = $"Ответ:Количество квадратов = {k:f2}\n" + $"Площадь незанятой части прямоугольника = {a:f2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt16(textBoxA1.Text);
            int b = (a / 100) + 1;
            textBoxOtvet1.Text = $"Столетие = {b}";
        }
    }
}
