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
    public partial class CancelAppointment : Form
    {
        public CancelAppointment()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            InitializeComponent();
            FillCombo();
        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;


        void FillCombo()
        {
            con.Open();
            cmd = new SqlCommand("select CLIENT_ID From Clients", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comboBox1.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();
        }


        private void service_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sADS);

        }

        private void CancelAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sADS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter.Fill(this.sADS.Service_Appointment);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from [Service_Appointment] where DATE ='" + (dateTimePicker1.Value).ToString("yyyyMMdd") + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;
            {
                string var;
                var = (dateTimePicker1.Value).ToString("yyyyMMdd");

                con.Open();
                SqlCommand cmd = new SqlCommand("select APPOINTMENT_ID, CLIENT_ID, TIMESLOT, PEST_CONTROLLER, STATUS, PAYMENT_METHOD, PRICE from Service_Appointment where DATE = @DATE", con);
                cmd.Parameters.AddWithValue("@DATE", var);
                SqlDataReader da = cmd.ExecuteReader();
                {
                    if (dateTimePicker1.Text != "")
                    {
                        while (da.Read())
                        {
                            label7.Text = da.GetValue(0).ToString();
                            comboBox1.Text = da.GetValue(1).ToString();
                            comboBox3.Text = da.GetValue(2).ToString();
                            comboBox2.Text = da.GetValue(3).ToString();
                            comboBox4.Text = da.GetValue(4).ToString();
                            comboBox5.Text = da.GetValue(5).ToString();
                            textBox1.Text = da.GetValue(6).ToString();
                        }
                    }
                }
                da.Dispose();
                da.Close();
                con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete Service_Appointment where APPOINTMENT_ID = '" + (label7.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Appointment has been cancelled");
                BindData();
            }

            else if (dialogResult == DialogResult.No)
                MessageBox.Show("Appointment not cancelled");


            comboBox5.Text = String.Empty;
            comboBox4.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;
            textBox1.Text = String.Empty;
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Service_Appointment", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;
        }


    }
}

