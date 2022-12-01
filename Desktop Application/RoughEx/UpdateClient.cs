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
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            if (txtClinetNo.TextLength == 10)
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Clients SET CLIENTFNAME='" + txtCfName.Text + "',CLIENTLNAME='" + txtCLname.Text + "',CLIENTCOMPANYNAME='" + txtCompName.Text + "',CLIENTADDRESS='" + txtCAddress.Text + "',CLIENTDISTRICT='" + txtDistrict.Text + "',CLIENTCITY='" + txtCity.Text + "',CLIENTCONTACTNUMBER='" + txtClinetNo.Text + "',CLIENTEMAILADDRESS='" + txtCEmail.Text + "' where CLIENT_ID= '" + label2.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                DialogResult res;
                res = MessageBox.Show("Are  you sure you want to update these details", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Updated successfully", "Update");
                    BindData();
                }

                else
                {
                    MessageBox.Show("Details not updated ", "Update Error");
                }
            }
            else
            {
                MessageBox.Show("A phone number must contain at least 10 digits", "Incorrect phone number");
            }

            txtCfName.Text = String.Empty;
            txtCLname.Text = String.Empty;
            txtCompName.Text = String.Empty;
            txtCAddress.Text = String.Empty;
            txtDistrict.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtClinetNo.Text = String.Empty;
            txtCEmail.Text = String.Empty;

        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Clients", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            clientsDataGridView.DataSource = dt;
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientDS);

        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDS.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientDS.Clients);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from [Clients] where CLIENTLNAME ='" + (textBox1.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            clientsDataGridView.DataSource = dt;
            {
                string var;
                var = textBox1.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("select CLIENT_ID, CLIENTFNAME,CLIENTLNAME,CLIENTCOMPANYNAME,CLIENTADDRESS, CLIENTDISTRICT, CLIENTCITY, CLIENTCONTACTNUMBER,CLIENTEMAILADDRESS from Clients where CLIENTLNAME = @CLIENTLNAME", con);
                command.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@CLIENTLNAME", var);
                SqlDataReader da = cmd.ExecuteReader();
                if (textBox1.Text != "")
                {
                    while (da.Read())
                    {
                        label2.Text = da.GetValue(0).ToString();
                        txtCfName.Text = da.GetValue(1).ToString();
                        txtCLname.Text = da.GetValue(2).ToString();
                        txtCompName.Text = da.GetValue(3).ToString();
                        txtCAddress.Text = da.GetValue(4).ToString();
                        txtDistrict.Text = da.GetValue(5).ToString();
                        txtCity.Text = da.GetValue(6).ToString();
                        txtClinetNo.Text = da.GetValue(7).ToString();
                        txtCEmail.Text = da.GetValue(8).ToString();

                    }
                }
                con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
