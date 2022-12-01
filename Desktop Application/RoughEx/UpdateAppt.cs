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
    public partial class UpdateAppt : Form
    {
        public UpdateAppt()
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
        void ResetCombo()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.Insert(0, "9h00-10h00");
            comboBox3.Items.Insert(1, "10h00-11h00");
            comboBox3.Items.Insert(2, "11h00-12h00");
            comboBox3.Items.Insert(3, "12h00-13h00");
            comboBox3.Items.Insert(4, "13h00-14h00");
            comboBox3.Items.Insert(5, "14h00-15h00");
            comboBox3.Items.Insert(6, "15h00-16h00");


        }
        private void service_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sADS);

        }

        private void UpdateAppt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDS.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientDS.Clients);
            // TODO: This line of code loads data into the 'sADS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter.Fill(this.sADS.Service_Appointment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && comboBox1.Text != "" && comboBox5.Text != "" && comboBox4.Text != "" && comboBox2.Text != "" && textBox1.Text != "")

            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Service_Appointment SET CLIENT_ID = '" + comboBox1.Text + "', DATE='" + dateTimePicker1.Value + "',TIMESLOT='" + comboBox3.Text + "', PEST_CONTROLLER ='" + comboBox2.Text + "', STATUS='" + comboBox4.Text + "', PAYMENT_METHOD='" + comboBox5.Text + "', PRICE= '" + double.Parse(textBox1.Text) + "' where APPOINTMENT_ID = '" + label7.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                DialogResult res;
                res = MessageBox.Show("Are you sure you want to update these details", "Add new details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully Updated.", "Updated");
                    BindData();
                }
                else
                {
                    MessageBox.Show("Appointment not updated.", "Not updated");
                }
            }


            else
            {
                MessageBox.Show("Please Enter Details.");
            }

            comboBox1.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox4.Text = String.Empty;
            comboBox5.Text = String.Empty;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Select * from [Service_Appointment] where CLIENT_ID ='" + (textBox3.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;
            {
                string var;
                var = textBox3.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("select APPOINTMENT_ID, CLIENT_ID, DATE, TIMESLOT, PEST_CONTROLLER, STATUS, PAYMENT_METHOD, PRICE from Service_Appointment where CLIENT_ID = @CLIENT_ID", con);
                cmd.Parameters.AddWithValue("@CLIENT_ID", var);
                SqlDataReader da = cmd.ExecuteReader();
               
                if (textBox3.Text != "")
                {
                    while (da.Read())
                    {
                        label7.Text = da.GetValue(0).ToString();
                        comboBox1.Text = da.GetValue(1).ToString();
                        dateTimePicker1.Text = da.GetValue(2).ToString();
                        comboBox3.Text = da.GetValue(3).ToString();
                        comboBox2.Text = da.GetValue(4).ToString();
                        comboBox4.Text = da.GetValue(5).ToString();
                        comboBox5.Text = da.GetValue(6).ToString();
                        textBox1.Text = da.GetValue(7).ToString();
                     
                    }
                  
                }
             
            }
            
            dr.Close();
            con.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from [Clients] where [CLIENTLNAME] ='" + (textBox2.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            clientsDataGridView.DataSource = dt;
            {
                string var;
                var = textBox2.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("select CLIENT_ID, CLIENTFNAME, CLIENTCOMPANYNAME, CLIENTADDRESS, CLIENTDISTRICT, CLIENTCITY, CLIENTCONTACTNUMBER, CLIENTEMAILADDRESS from Clients where CLIENTLNAME = @CLIENTLNAME", con);
                cmd.Parameters.AddWithValue("@CLIENTLNAME", var);
                SqlDataReader da = cmd.ExecuteReader();
                con.Close();
                dr.Close();

            }
           
        }




        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //con.Open();
            comboBox3.SelectedIndex = -1;

            string var;
            var = (dateTimePicker1.Value).ToString("yyyyMMdd");

            SqlCommand command = new SqlCommand("Select * from [Service_Appointment] where DATE ='" + (dateTimePicker1.Value).ToString("yyyyMMdd") + "'", con);
            command.Parameters.AddWithValue("@DATE", var);
            SqlDataReader da = command.ExecuteReader();

            int appointmentFound;
            appointmentFound = 0;

                while (da.Read())
            {
                string AppointmentTimeSlot;
                AppointmentTimeSlot = da.GetValue(3).ToString();

                string AppointmentPestController;
                AppointmentPestController = da.GetValue(4).ToString();

                if (AppointmentPestController == comboBox2.Text)
                {

                    if (appointmentFound == 0)
                    {
                        ResetCombo();

                    }

                    comboBox3.Items.Remove(AppointmentTimeSlot);
                    appointmentFound++;

                }

                if (AppointmentPestController != comboBox2.Text)
                {
                    if (appointmentFound > 0)
                    {
                        continue;
                    }
                    else
                    {
                        ResetCombo();

                    }

                }

            }
           con.Close();
        }
    

    

    private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    }