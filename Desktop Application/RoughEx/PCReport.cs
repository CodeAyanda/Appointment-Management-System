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
    public partial class PCReport : Form
    {
        public PCReport()
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

        private void PCReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceAppointmentDS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter.Fill(this.serviceAppointmentDS.Service_Appointment);

        }

        private void service_AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //You need to copy and paste from your computer (ihave not downloaded the code yet)
            using (conn)
            {
                conn.ConnectionString = @"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc";
                conn.Open();
                string query = @"SELECT PEST_CONTROLLER_ID FROM Service_Appointment group by PEST_CONTROLLER_ID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                textBox1.Text = dr.GetValue(0).ToString(); //1st PestControllerID
                                while (dr.Read())
                                {
                                    textBox2.Text = dr.GetValue(0).ToString(); //2nd PestControllerID
                                    while (dr.Read())
                                    {
                                        textBox3.Text = dr.GetValue(0).ToString(); //3rd PestControllerID
                                        while (dr.Read())
                                        {
                                            textBox4.Text = dr.GetValue(0).ToString(); //4th PestControllerID
                                        }
                                    }
                                }
                            }
                        }

                    }

                    string query2 = @"select SUM(DATEDIFF(HH,SERVICE_APPOINTMENT_START_TIME, SERVICE_APPOINTMENT_END_TIME)) as hours_worked from Service_Appointment where PEST_CONTROLLER_ID='" + textBox1.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox8.Text = dr.GetValue(0).ToString(); //1st PestController hours worked

                                }
                            }
                        }

                    }

                    string query3 = @"select SUM(DATEDIFF(HH,SERVICE_APPOINTMENT_START_TIME, SERVICE_APPOINTMENT_END_TIME)) as hours_worked from Service_Appointment where PEST_CONTROLLER_ID='" + textBox2.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query3, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox7.Text = dr.GetValue(0).ToString();  //2nd PestController hours worked

                                }
                            }
                        }

                    }

                    string query4 = @"select SUM(DATEDIFF(HH,SERVICE_APPOINTMENT_START_TIME, SERVICE_APPOINTMENT_END_TIME)) as hours_worked from Service_Appointment where PEST_CONTROLLER_ID='" + textBox3.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query4, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox6.Text = dr.GetValue(0).ToString();  //3rd PestController hours worked

                                }
                            }
                        }

                    }

                    string query5 = @"select SUM(DATEDIFF(HH,SERVICE_APPOINTMENT_START_TIME, SERVICE_APPOINTMENT_END_TIME)) as hours_worked from Service_Appointment where PEST_CONTROLLER_ID='" + textBox4.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query5, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox5.Text = dr.GetValue(0).ToString();  //4th PestController hours worked

                                }
                            }
                        }

                    }

                    string query6 = @"SELECT SUM(SERVICE_APPOINTMENT_PRICE) as sum_price FROM Service_Appointment WHERE PEST_CONTROLLER_ID='" + textBox1.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query6, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox12.Text = dr.GetValue(0).ToString();  //1st PestController Sales

                                }
                            }
                        }

                    }

                    string query7 = @"SELECT SUM(SERVICE_APPOINTMENT_PRICE) as sum_price FROM Service_Appointment WHERE PEST_CONTROLLER_ID='" + textBox2.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query7, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox11.Text = dr.GetValue(0).ToString();  //2nd PestController Sales

                                }
                            }
                        }

                    }

                    string query8 = @"SELECT SUM(SERVICE_APPOINTMENT_PRICE) as sum_price FROM Service_Appointment WHERE PEST_CONTROLLER_ID='" + textBox3.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query8, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox10.Text = dr.GetValue(0).ToString();  //3rd PestController Sales

                                }
                            }
                        }

                    }

                    string query9 = @"SELECT SUM(SERVICE_APPOINTMENT_PRICE) as sum_price FROM Service_Appointment WHERE PEST_CONTROLLER_ID='" + textBox4.Text + "';";
                    using (SqlCommand cmd2 = new SqlCommand(query9, conn))
                    {
                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    textBox9.Text = dr.GetValue(0).ToString();  //4th PestController Sales

                                }
                            }
                        }

                    }

                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc";
            conn.Open();

            try
            {
                int month;
                month = Convert.ToInt32(textBox13.Text);

                int year;
                year = Convert.ToInt32(textBox14.Text);

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
    }
}
