using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;


namespace Login_and_register_ّForm
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


        private void txt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox.Focus();
        }

        private void txtBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text) && txtBox.Text.Length > 0)
            {

                txt.Visibility = Visibility.Collapsed;

            }
            else
            {
                txt.Visibility = Visibility.Visible;
            }
        }

        private void txtPas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Pas.Focus();
        }

        private void Pas_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Pas.Password) && Pas.Password.Length > 0)
            {
                txtPas.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtPas.Visibility = Visibility.Visible;
            }
        }
    }
}
