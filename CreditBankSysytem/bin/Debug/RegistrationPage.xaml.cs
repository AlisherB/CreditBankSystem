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

namespace CreditBankSysytem
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        MainWindow mainWindow;
        public RegistrationPage()
        {
            InitializeComponent();
            incorrectTextBlock.Visibility = Visibility.Hidden;
        }

        private void TextBoxIIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (((int)e.Key <= 47 || (int)e.Key >= 59) && (int)e.Key != 8)
                e.Handled = true;
        }

        private void TelephoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (((int)e.Key <= 47 || (int)e.Key >= 59) && (int)e.Key != 8)
                e.Handled = true;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(fullNameTextBox.Text) || 
                (!string.IsNullOrWhiteSpace(textBoxIIN.Text) || textBoxIIN.Text.Length == 12) ||
                !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                mainWindow = new MainWindow();
                mainWindow.mainFrame.NavigationService.Navigate(new Uri("AuthorityPage.xaml", UriKind.Relative));
            }
            else incorrectTextBlock.Visibility = Visibility.Visible;

        }
    }
}
