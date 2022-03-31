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
using System.Media;
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
        public SoundPlayer player = new(@"eduardo.wav");
        private void Button1_click(object sender, RoutedEventArgs e)
        {
            if ((bool)perbutton.IsChecked)
                MessageBox.Show("Crusty G Automation");
            else if ((bool)perbutton.IsChecked)
            {
                player.Play();
                MessageBox.Show("well well well");
            }
        }

        private void Button2Click(object sender, RoutedEventArgs e)
        {
            cashCount += 1;
            cash.Content = "cash: " + cashCount;
    }
    }
}
