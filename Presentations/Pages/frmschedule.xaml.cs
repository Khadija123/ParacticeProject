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
using ErrorLogNet;
using DAL;
using System.Data;
using System.Data.SqlClient;
using Services;
using Repository.Class_Files;

namespace Presentations.Pages
{
    /// <summary>
    /// Interaction logic for frmschedule.xaml
    /// </summary>
    public partial class frmschedule
    {
        public frmschedule()
        {
            InitializeComponent();
        }


        ErrorLog elog = new ErrorLog();
        BCschedule bll = new BCschedule();
        BCscheduleProperties objP = new BCscheduleProperties();
        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {

                  objP.daysch = comboScheduleDay.Text;
                  DataSet ds = bll.callScheduleDay(ref elog, objP);
                  if (ds != null && ds.Tables[0].Rows.Count > 0)
                  {
                      MessageBox.Show("schedule already added");
                  }
                  else
                  {
                      objP.schDay = comboScheduleDay.Text;
                      objP.schClosingTime = Convert.ToDateTime("2014/01/01    " + cbin5.Text + ":" + cbin6.Text + "" + cbin7.Text);
                      objP.schStartingTime = Convert.ToDateTime("2014/01/01   " + cbin1.Text + ":" + cbin2.Text + "" + cbin4.Text);
                      objP.schCreateUser = 1;
                      objP.schEffectiveDate = System.DateTime.Now;
                      objP.schExpiryDate = System.DateTime.Now.AddYears(80);
                      objP.schDisableBit = false;
                      objP.schCreateDate = System.DateTime.Now;



                      ManagementServices objService = new ManagementServices();
                      int chk = objService.SchedulePatientServices(ref elog, objP);
                      if (chk == 1)
                      {
                          MessageBox.Show("Inserted");
                      }
                  }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 00; i < 12; i++)
            {
                cbin1.Items.Add(i.ToString());
                cbin5.Items.Add(i.ToString());

            }
            for (int i = 00; i < 60; i++)
            {
                cbin2.Items.Add(i.ToString());
               cbin6.Items.Add(i.ToString());
            }
            cbin4.Items.Add("AM");
            cbin4.Items.Add("PM");
            cbin7.Items.Add("AM");
            cbin7.Items.Add("PM");
        }
        
        private void GVschedule_Loaded(object sender, RoutedEventArgs e)
        {
            DataSet ds = bll.fillingschedule(ref elog);
            GVschedule.ItemsSource = ds.Tables[0].DefaultView;
            
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }







    }
}
