using System;
using System.Windows;

namespace Prac2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Логика для выполнения задания 1
            if (int.TryParse(textBoxA.Text, out int a) && int.TryParse(textBoxB.Text, out int b))
            {
                int result = a + b;
                textBoxOtvet.Text = result.ToString();
            }
            else
            {
                textBoxOtvet.Text = "Ошибка ввода";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Логика для выполнения задания 2
            if (int.TryParse(textBoxN.Text, out int n))
            {
                // Ваш код для задания 2
            }
            else
            {
                // Вывод сообщения об ошибке ввода
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Логика для выполнения задания 3
            if (int.TryParse(textBoxK.Text, out int k))
            {
                // Ваш код для задания 3
            }
            else
            {
                // Вывод сообщения об ошибке ввода
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Логика для выполнения задания 4
            if (int.TryParse(textBoxX.Text, out int x) && int.TryParse(textBoxA2.Text, out int a))
            {
                // Ваш код для задания 4
            }
            else
            {
                // Вывод сообщения об ошибке ввода
            }
        }
    }
}
