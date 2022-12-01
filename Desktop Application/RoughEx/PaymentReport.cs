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
    public partial class PaymentReport : Form
    {
        public PaymentReport()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Service_Appointment", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;

        }

        private void service_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceAppointmentDS);

        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAppointmentDS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter.Fill(this.serviceAppointmentDS.Service_Appointment);

        }

        private void btnPSEarch_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc";
            conn.Open();

            try
            {
                int month;
                month = Convert.ToInt32(txtPaymentSearch .Text);

                int year;
                year = Convert.ToInt32(textBox1.Text);

                string query = @"SELECT * FROM Service_Appointment WHERE DATEPART(month, SERVICE_APPOINTMENT_DATE)='" + month + "' and DATEPART(year, SERVICE_APPOINTMENT_DATE)='" + year + "';";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                service_AppointmentDataGridView.DataSource = dt;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid date");
            }

            conn.Close();

        }
    


        

        private void btnGenerateP_Click(object sender, EventArgs e)
        {
            using (conn)
            {
                conn.ConnectionString = @"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc";
                conn.Open();
                string query = @"Select PAYMENT_METHOD, Count(PAYMENT_METHOD) as AggCompanyName from Service_Appointment
                                     group by PAYMENT_METHOD
                                     Order By Count(PAYMENT_METHOD) Desc;
                                     ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                txtPaymentM.Text = dr.GetValue(0).ToString();
                                txtNoUsed.Text = dr.GetValue(1).ToString();

                                string queryy = @"Select PAYMENT_METHOD, Count(PAYMENT_METHOD) as AggCompanyName from Service_Appointment
                                  group by PAYMENT_METHOD
                                  Order By Count(PAYMENT_METHOD) Desc;
                                  ";
                                using (SqlCommand cmd2 = new SqlCommand(queryy, conn))
                                {

                                    if (dr != null)
                                    {
                                        while (dr.Read())
                                        {
                                            txtLeast.Text = dr.GetValue(0).ToString();
                                            txtUsed.Text = dr.GetValue(1).ToString();
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
  }
                            
                       
                    
