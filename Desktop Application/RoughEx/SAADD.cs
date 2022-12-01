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
    public partial class SAADD : Form
    {
        public SAADD()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            InitializeComponent();
            GetSAID();
            FillCombo();
        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;

        public void GetSAID()
        {
            try
            {
                sql = "select MAX([APPOINTMENT_ID]) from Service_Appointment";
                cmd = new SqlCommand(sql, con);
                con.Open();
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    label7.Text = "A-00001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 5));
                    intval++;
                    label7.Text = String.Format("A-{0:00000}", intval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    


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
            this.tableAdapterManager.UpdateAll(this.serviceADS);

        }

        private void SAADD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sADS.Service_Appointment' table. You can move, or remove it, as needed.
            this.service_AppointmentTableAdapter2.Fill(this.sADS.Service_Appointment);
            // TODO: This line of code loads data into the 'serviceAppointmentDS1.Service_Appointment' table. You can move, or remove it, as needed.
            //this.service_AppointmentTableAdapter1.Fill(this.serviceAppointmentDS1.Service_Appointment);
            // TODO: This line of code loads data into the 'serviceADS.Service_Appointment' table. You can move, or remove it, as needed.
            //  this.service_AppointmentTableAdapter.Fill(this.serviceADS.Service_Appointment);






        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {




        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Service_Appointment", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;
        }
        private void btnADDSAExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            con.Open();

            if (dateTimePicker1.Value > DateTime.Now)
            {
                if (comboBox3.Text != "" && comboBox1.Text != "" && comboBox5.Text != "" && comboBox4.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
                {

                    SqlCommand command = new SqlCommand("INSERT INTO [Service_Appointment] (APPOINTMENT_ID, CLIENT_ID, DATE, TIMESLOT, PEST_CONTROLLER, STATUS, PAYMENT_METHOD, PRICE) VALUES ('" + label7.Text + "','" + comboBox1.Text + "','" + (dateTimePicker1.Value).ToString("yyyyMMdd") + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + double.Parse(textBox1.Text) + "')", con);
                    command.ExecuteNonQuery();
                    DialogResult res;
                    res = MessageBox.Show("Are  you sure you want to add this appointment", "Add new appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Successfully Created.");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Appointment not added.");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter All Details");
                }
            }
            else
            {
                MessageBox.Show("Please select a date greater than or equal to today's date.");
            }


            con.Close();
            GetSAID();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;


            void BindData()
            {
                SqlCommand command = new SqlCommand("select * from Service_Appointment", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                service_AppointmentDataGridView.DataSource = dt;
            }
        }
    





        private void btnDelete_Click(object sender, EventArgs e)
        {

           

        }



        private void service_AppointmentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.service_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceADS);

        }

        private void service_AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchSA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCIDSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPCIDSearchSa_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ResetCombo();
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            SqlCommand command = new SqlCommand("Select * from [Service_Appointment] where DATE ='" + (dateTimePicker1.Value).ToString("yyyyMMdd") + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            service_AppointmentDataGridView.DataSource = dt;
            {
                string var;
                var = dateTimePicker1.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("select APPOINTMENT_ID, CLIENT_ID, TIMESLOT, PEST_CONTROLLER, STATUS, PAYMENT_METHOD, PRICE from Service_Appointment where DATE = @DATE", con);
                cmd.Parameters.AddWithValue("@DATE", var);
                SqlDataReader da = cmd.ExecuteReader();
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






    

