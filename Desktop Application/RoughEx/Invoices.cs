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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
            dateTimePicker1 .Format = DateTimePickerFormat.Custom;
            dateTimePicker1 .CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Today;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Service_Appointment", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           InvoiceDataGrid.DataSource = dt;

        }

        private void service_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoicesDS);

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoicesRDS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter1.Fill(this.invoicesRDS.Service_Appointment);
            // TODO: This line of code loads data into the 'invoicesDS.Service_Appointment' table. You can move, or remove it, as needed.
           // this.service_AppointmentTableAdapter.Fill(this.invoicesDS.Service_Appointment);
            BindData();
        }

        private void btnInvoicesSearch_Click(object sender, EventArgs e)
        {
            string var;
            var = txtISASearch.Text;

            SqlCommand command = new SqlCommand("select * from Service_Appointment where SERVICE_APPOINTMENT_ID = '" + var + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            InvoiceDataGrid.DataSource = dt;
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
          
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void txtISASearch_TextChanged(object sender, EventArgs e)
        {
            string var;
            var = txtISASearch.Text;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select SERVICE_APPOINTMENT_DATE, SERVICE_APPOINTMENT_START_TIME, SERVICE_APPOINTMENT_END_TIME, PAYMENT_METHOD, CLIENT_ID, PEST_CONTROLLER_ID, SERVICE_APPOINTMENT_PRICE,SERVICE_APPOINTMENT_STATUS from Service_Appointment where SERVICE_APPOINTMENT_ID = @SERVICE_APPOINTMENT_ID", conn);
            cmd.Parameters.AddWithValue("@SERVICE_APPOINTMENT_ID", var);
            SqlDataReader da = cmd.ExecuteReader();
            if (txtISASearch.Text != "")
            {
                while (da.Read())
                {
                   
                    dateTimePicker1.Text = da.GetValue(0).ToString();
                    txtStartT.Text = da.GetValue(1).ToString();
                    TXTendTime.Text = da.GetValue(2).ToString();
                    txtPayment.Text = da.GetValue(3).ToString();
                    txtClientIDI.Text = da.GetValue(4).ToString();
                    txtPCIDI.Text = da.GetValue(5).ToString();
                    txtStatusID.Text = da.GetValue(7).ToString(); 
                  txtPrice.Text = da.GetValue(6).ToString();
                    

                }

            }
            conn.Close();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Just Environmental Services", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, new PointF(200, 100));
            e.Graphics.DrawString("Service Appointment ID : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(txtISASearch.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 150));
            e.Graphics.DrawString("Service Appointment Date : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 175));
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 175));
            e.Graphics.DrawString("Service Appointment Start Time : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 195));
            e.Graphics.DrawString(txtStartT.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 195));
            e.Graphics.DrawString("Service Appointment End Time : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 215));
            e.Graphics.DrawString(TXTendTime .Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 215));
            e.Graphics.DrawString("Payment Method : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 235));
            e.Graphics.DrawString(txtPayment.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 235));
            e.Graphics.DrawString("Client ID : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 255));
            e.Graphics.DrawString(txtClientIDI.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 255));
            e.Graphics.DrawString("Pest Controller ID : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 275));
            e.Graphics.DrawString(txtPCIDI.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 275));
            e.Graphics.DrawString("Service Appointment Status : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 295));
            e.Graphics.DrawString(txtStatusID.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 295));
            e.Graphics.DrawString("Price : ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 315));
            e.Graphics.DrawString(txtPrice.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(500, 315));
        }
    }
}
       
      