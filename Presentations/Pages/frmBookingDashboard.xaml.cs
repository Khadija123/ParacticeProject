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
using Repository.Class_Files;
using System.Windows.Navigation;
//using System.Windows.Shapes;
namespace Presentations.Pages
{
    /// <summary>
    /// Interaction logic for frmBookingDashboard.xaml
    /// </summary>
    public partial class frmBookingDashboard
    {
        LoggedUser MobjUser;
        public frmBookingDashboard(LoggedUser User)
        {
            MobjUser = User;
            InitializeComponent();
            this.Title = "Hello, "+MobjUser.FULLNAME;
        }

        private void btnpatientregistration_Click(object sender, RoutedEventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.ShowDialog();
            this.Close();
        }

        private void btnviewpatient_Click(object sender, RoutedEventArgs e)
        {
            ManagePatients mp = new ManagePatients();
            mp.ShowDialog();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            //string url = "/Pages/frmLogin.xaml";
            //MainWindow bblock = new MainWindow();
            //bblock.LinkNavigator.Navigate(new Uri(url, UriKind.Relative), this, NavigationHelper.FrameSelf);
        }

        private void btnbooking_Click(object sender, RoutedEventArgs e)
        {
            frmbookingreservation fmbookingreserve = new frmbookingreservation();
            fmbookingreserve.Show();
        }
    }
}
