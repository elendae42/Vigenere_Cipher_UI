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

namespace Vigenere_Cipher_UI
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

        private string text;
        private string key;

        private void executeClick(object sender, RoutedEventArgs e)
        {
            if ((bool)encodeButton.IsChecked)
            {
                OutputText.Text = Vigenere_Square.encode(text, key);
            }
            else if ((bool)decodeButton.IsChecked)
            {
                OutputText.Text = Vigenere_Square.decode(text, key);
            }
            else
            {
                throw new InvalidOperationException("No operation selected, please select to either encode or decode your string.");
            }
        }

        private void InputKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            key = ((TextBox)sender).Text;
        }

        private void InputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            text = ((TextBox)sender).Text;
        }
    }

}
