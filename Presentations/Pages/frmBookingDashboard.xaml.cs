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
    }
}
