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

namespace Homework_9
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

        private void ButtonSplit_Click(object sender, RoutedEventArgs e)
        {             
            string inputstring = InputString.Text;
            string[] words = inputstring.Split(' ');
            foreach (string word in words)
            {
                OutputList.Items.Add(word);
            }
        }

        private void ButtonInverse_Click(object sender, RoutedEventArgs e)
        {
            string inputstring = InputStringReverse.Text;
            string[] words = inputstring.Split(' ');
            string outputstring = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                outputstring += words[i];
                if (i != 0) outputstring += " ";
            }
            OutputLabel.Content = outputstring;
        }
    }
}
