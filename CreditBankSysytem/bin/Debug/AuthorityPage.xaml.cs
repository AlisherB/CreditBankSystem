﻿using System;
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
    /// Логика взаимодействия для AuthorityPage.xaml
    /// </summary>
    public partial class AuthorityPage : Page
    {
        MainWindow mainWindow;
        public AuthorityPage()
        {
            InitializeComponent();
            incorrectTextBlock.Visibility = Visibility.Hidden;
        }

        private void TextBoxIIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (((int)e.Key <= 47 || (int)e.Key >= 59) && (int)e.Key != 8)
                e.Handled = true;
        }

        private void SignUpTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.mainFrame.NavigationService.Navigate(new Uri("RegistrationPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(textBoxIIN.Text) || textBoxIIN.Text.Length == 12) || !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {

            }

            incorrectTextBlock.Visibility = Visibility.Visible;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.mainFrame.NavigationService.Navigate(new Uri("RegistrationPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
