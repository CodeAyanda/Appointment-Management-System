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
    public partial class AddPC : Form
    {
        public AddPC()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");

        private void pest_ControllerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pest_ControllerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pCDS);

        }

        private void AddPC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCDS.Pest_Controller' table. You can move, or remove it, as needed.
            this.pest_ControllerTableAdapter.Fill(this.pCDS.Pest_Controller);

            BindData();


        }

        private void pest_ControllerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPCADD_Click(object sender, EventArgs e)
        {
            if (txtPCPhoneNo.TextLength == 10)
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [Pest_Controller](PEST_CONTROLLER_ID, NAME,SURNAME,PHONE_NUMBER, EMAIL, PEST_CONTROLLER_AVAILABILITY) VALUES ('" + txtPCID.Text + "','" + txtPCName.Text + "','" + txtPCSurname.Text + "','" + txtPCPhoneNo.Text + "','" + txtPCEMail.Text + "','" + txtAvail.Text + "')", con);
                    command.ExecuteNonQuery();
                    con.Close();

                    DialogResult res;
                    res = MessageBox.Show("Are  you sure you want to add  these details", "Add new details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Successfully added", "Succesfully added details");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Details not added ", "Details error");
                    }
                }
                catch (SqlException)
                {
                    for (int item = 0; item < pest_ControllerDataGridView.Rows.Count; item++) ;
                    {
                        MessageBox.Show("Client ID already exists.");
                        txtPCID.Clear();
                        return;
                    }

                }

            }

            else
            {
                MessageBox.Show("A phone number must contain at least 10 digits", "Incorrect phone number");

            }


        }


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Pest_Controller", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            pest_ControllerDataGridView.DataSource = dt;


        }

        private void btnAddPCExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPCSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchPC_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSearchPC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPestSearch_Click(object sender, EventArgs e)
        {



        }

        private void txtPCPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error , A phone number cannot contain letters", "Invalid Phone number");
            }
        }

        private void txtPCPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPCPhoneNo.TextLength == 10)

            {
                txtPCPhoneNo.ForeColor = Color.Black;
            }
            else
            {
                txtPCPhoneNo.ForeColor = Color.Red;

            }
        }

        private void btnPcUpdate_Click(object sender, EventArgs e)
        {
            if (txtPCPhoneNo.TextLength == 10)
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Pest_Controller SET NAME ='" + txtPCName.Text + "',SURNAME ='" + txtPCSurname.Text + "',PHONE_NUMBER='" + txtPCPhoneNo.Text + "',EMAIL='" + txtPCEMail.Text + "',PEST_CONTROLLER_AVAILABILITY='" + txtAvail.Text + "' where PEST_CONTROLLER_ID = '" + txtPCID.Text + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                DialogResult res;
                res = MessageBox.Show("Are  you sure you want to update these details", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Updated successfully", "Updated");
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
        }

        private void txtSearchPCname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPCSEARCHSURNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAvail.Clear();
            txtPCEMail.Clear();
            txtPCID.Clear();
            txtPCName.Clear();
            txtPCPhoneNo.Clear();
            txtPCSurname.Clear();
         
        }
    }
}
