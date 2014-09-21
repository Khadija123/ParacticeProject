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
using ErrorLogNet;
using Services;
using Repository.Class_Files;

namespace Presentations.Pages
{
    /// <summary>
    /// Interaction logic for PatientRegistration.xaml
    /// </summary>
    public partial class PatientRegistration
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ErrorLog elog = new ErrorLog();

            BCPropOfPatient objProp = new BCPropOfPatient();
            objProp.Pname = txtPname.Text;
            objProp.Pfname = txtPfname.Text;
            objProp.Paddress = txtPaddress.Text;
            objProp.Pcontactno = txtPcontactno.Text;
            objProp.Pcnic = txtPcnic.Text;
            objProp.Prefencedby = txtPrefencedby.Text;
            objProp.CreateDate = System.DateTime.Now;
            objProp.Create_User = 1;

            ManagementServices objService = new ManagementServices();
            int chk = objService.PatientInsertionServices(ref elog, objProp);
            if(chk==1)
            {
                MessageBox.Show("Patient Registered");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
