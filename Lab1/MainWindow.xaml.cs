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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit = Int32.Parse(limit.Text);
            int clockedSpeed = Int32.Parse(clocked.Text);
            int speedDifference = clockedSpeed - speedLimit;
            int fine = 60;
            int eachAdditionalMPH = 7;
            int twentyFiveOver = 250;

            if (speedDifference > 0)
            {
                legality.Content = "ILLEGAL!";
                speedingTracker.Background = Brushes.Yellow;
                for (int i = 0; i <= speedDifference; i++)
                {
                    fine += eachAdditionalMPH;
                }
                if (speedDifference >= 25)
                {
                    fine += twentyFiveOver;
                    speedingTracker.Background = Brushes.Red;

                }
                MessageBox.Show("Illegal speed! Your fine is $" + fine + ".");
            } else
            {
                legality.Content = "LEGAL!";
                speedingTracker.Background = Brushes.Green;
                MessageBox.Show("Your speed is at or below the speed limit.");
            }

            

        }
    }
}
