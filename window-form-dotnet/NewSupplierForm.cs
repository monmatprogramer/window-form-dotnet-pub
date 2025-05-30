using System;
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
    public partial class NewSupplierForm : Form
        {
        public NewSupplierForm()
            {
            InitializeComponent();
            }

        private void label3_Click(object sender, EventArgs e)
            {

            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            //open dashboard form
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            //close this form
            this.Close();
            }
        protected override void OnFormClosing(FormClosingEventArgs e)
            {
            base.OnFormClosing(e); // Call the base class implementation

            // Open dashboard form
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            }
        }
    }
    
