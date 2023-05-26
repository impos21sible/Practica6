using System;
using System.Windows;

namespace  Zadanie4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double Function(double x)
        {
            double Reshenie = x * x + 2 * x + 1;

            if (Reshenie < 2)
            {
                return Reshenie;
            }
            else if (Reshenie >= 2 && Reshenie < 3)
            {
                return 1 / (Math.Pow(x, 2) - 1);
            }
            else
            {
                return 0;
            }
        }


        public void GenerateTableButton_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(inputA.Text);
            double b = double.Parse(inputB.Text);
            double h = double.Parse(inputH.Text);

            for (double x = a; x <= b; x+=h)
            {
                double y = Function(x);
                resultLabel.Content += $"x= {x} y = {y}\n";

            }
        }
        
    }
}
