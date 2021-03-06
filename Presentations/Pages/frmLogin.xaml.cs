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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Data;
using Services;
using Repository.Class_Files;
using ErrorLogNet;
using System.Data.Sql;


namespace Presentations.Pages
{
    /// <summary>
    /// Interaction logic for frmPatientRegistration.xaml
    /// </summary>
    public partial class frmLogin
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }
        #region MAINTAINING THE STAND BY TEXT OF USERNAME AND PASSWORD
        
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
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtname.Text == "")
            {
                MessageBox.Show("Please provide username");
            }
            else if (txtpass.Password == "")
            {
                MessageBox.Show("Please provide password");
            }
            else
            {
                ErrorLog elog = new ErrorLog();
                LoggedUser objUser = new LoggedUser();
         
                objUser.USERNAME = txtname.Text.ToLower();
                objUser.PASSWORD = txtpass.Password;
                ManagementServices objServices = new ManagementServices();
                DataSet dsUser = objServices.VerfiyingUserServices(objUser, ref elog);
                DataRow drow = dsUser.Tables[0].Rows[0];
                objUser.ROLEID = Convert.ToInt32(drow["user_role"].ToString());
                objUser.FULLNAME = drow["user_fullname"].ToString();
                objUser.USERID =Convert.ToInt32( drow["user_id"].ToString());
                if (dsUser != null && dsUser.Tables[0].Rows.Count > 0)
                {
                    if(objUser.ROLEID==1)
                    {
                        frmBookingDashboard obj = new frmBookingDashboard(objUser);
                        this.ShowInTaskbar = false;
                        obj.Show();
                        this.Close();
                        this.ShowInTaskbar = true;
                    }
                }
                else
                {
                    MessageBox.Show("You have entered invalid credentials");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            createAccount ca = new createAccount();
            ca.Show();
        }
    }
}
