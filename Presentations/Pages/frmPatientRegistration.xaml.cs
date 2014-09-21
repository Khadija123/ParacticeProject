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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace Presentations.Pages
{
    /// <summary>
    /// Interaction logic for frmPatientRegistration.xaml
    /// </summary>
    public partial class frmPatientRegistration
    {
        public frmPatientRegistration()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
           if(txtname.Text=="Email Address")
           {
               txtname.Text = "";
               txtname.Foreground = Brushes.Black;
           }
        }

        private void txtname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Email Address";
                txtname.Foreground = Brushes.LightGray;
            }
        }

        private void txtpass_GotFocus(object sender, RoutedEventArgs e)
        {
            if(txtpass.Password=="Password")
            {
                txtpass.Password = "";
                txtpass.Foreground = Brushes.Black;
            }
        }

        private void txtpass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtpass.Password == "")
            {
                txtpass.Password = "Password";
                txtpass.Foreground = Brushes.LightGray;
            }
        }
    }
}
