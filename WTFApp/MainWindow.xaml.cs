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

namespace WTFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cashCount = 0;
        private void Button1_click(object sender, RoutedEventArgs e)
        {
            if (perbutton.IsChecked == true)
            {
                MessageBox.Show("Crusty G Automation");
            }
            else if (eddbutton.IsChecked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"eduardo.wav");
                player.Play();
                MessageBox.Show("well well well");
                player.Stop();
            }
        }

        private void Button2Click(object sender, RoutedEventArgs e)
        {
            cashCount += 1;
            cash.Content = "cash: " + cashCount;
    }
    }
}
