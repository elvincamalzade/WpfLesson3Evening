using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLesson3
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
        public int Count { get; set; } = 0;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ++Count;
          //  btn.Content = Count.ToString();

          //  myframe.Source = new Uri($"https://www.google.com/search?q={txtbox.Text}");

        }

        private void btn_repeat_Click(object sender, RoutedEventArgs e)
        {
            ++Count;
         //   btn_repeat.Content = Count.ToString();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
