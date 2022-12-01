using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RoughEx
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }



        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login Login = new Login();
            Login.ShowDialog();

            if (Login.LoginSuccess == true && Login.username == "AM002")
            {

                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                clientToolStripMenuItem.Enabled = true;
                pestControllerToolStripMenuItem.Enabled = true;
                serviceAppointmentToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
                lblLogged.Text = "Logged in as : " + Login.LoggedInAS;


            }
            else if (Login.LoginSuccess == false)
            {

                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = false;
                clientToolStripMenuItem.Enabled = false;
                pestControllerToolStripMenuItem.Enabled = false;
                serviceAppointmentToolStripMenuItem.Enabled = false;
                reportsToolStripMenuItem.Enabled = false;
            }
            else
            {

                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                clientToolStripMenuItem.Enabled = true;
                pestControllerToolStripMenuItem.Enabled = false;
                serviceAppointmentToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = false;
                lblLogged.Text = "Logged in as : " + Login.LoggedInAS;
            }










        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDCLIENT dfrm = new ADDCLIENT();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
            lblLogged.Show();
        }

        private void updateCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPestControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPC dfrm = new AddPC();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            pestControllerToolStripMenuItem.Enabled = false;
            serviceAppointmentToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Enabled = false;


        }

        private void searchClientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UpdateClient dfrm = new UpdateClient();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();

        }




        private void addAppointmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAADD dfrm = new SAADD();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }



        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            pestControllerToolStripMenuItem.Enabled = false;
            serviceAppointmentToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Enabled = false;
            MessageBox.Show("Logout Successfull", "You have logged out ");
            lblLogged.Text = "No one is currently logged in";

            Login.LoginSuccess = false;
            Login.LoggedInAS = "";


        }

        private void generateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoices dfrm = new Invoices();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void generatePestControllerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCReport dfrm = new PCReport();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void generatePaymentReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentReport dfrm = new PaymentReport();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void generateClientsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport dfrm = new ClientReport();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void accessControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelServiceAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelAppointment dfrm = new CancelAppointment();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void pestControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchPestControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPestController dfrm = new SearchPestController();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void updateServiceAppointmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAppt dfrm = new UpdateAppt();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void cancelServiceAppointmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CancelAppointment dfrm = new CancelAppointment();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }

        private void searchClientDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchClient dfrm = new SearchClient();
            dfrm.MdiParent = this;
            dfrm.Dock = DockStyle.Fill;
            dfrm.Show();
        }
    }
}


