﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_form_dotnet
{
    public partial class NewCustomerForm : Form
        {
        public NewCustomerForm()
            {
            InitializeComponent();
            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label4_Click(object sender, EventArgs e)
            {

            }

        private void label6_Click(object sender, EventArgs e)
            {

            }

        private void label10_Click(object sender, EventArgs e)
            {

            }

        private void bntClose_Click(object sender, EventArgs e)
            {
            //open dashboard form
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            //close this form
            this.Close();
            }

        //On Closing this form, the dashboard form will be opened
        protected override void OnFormClosing(FormClosingEventArgs e)
            {
            base.OnFormClosing(e); // Call the base class implementation

            // Open dashboard form
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            }
        }


    }
