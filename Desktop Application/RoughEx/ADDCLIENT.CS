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
    public partial class ADDCLIENT : Form
    {
        public ADDCLIENT()
        {
            InitializeComponent();
            GetClientID();
        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;



        public void GetClientID()
        {
            try
            {
                sql = "select MAX([CLIENT_ID]) from Clients";
                cmd = new SqlCommand(sql, con);
                con.Open();
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    label2.Text = "C-0001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 4));
                    intval++;
                    label2.Text = String.Format("C-{0:0000}", intval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientDS);

        }

        private void ADDCLIENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDS.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientDS.Clients);

            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            if (txtClinetNo.TextLength == 10)
            {
                
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [Clients] (CLIENT_ID, CLIENTFNAME,CLIENTLNAME,CLIENTCOMPANYNAME,CLIENTADDRESS, CLIENTDISTRICT, CLIENTCITY, CLIENTCONTACTNUMBER,CLIENTEMAILADDRESS) VALUES ('" + label2.Text + "','" + txtCfName.Text + "','" + txtCLname.Text + "','" + txtCompName.Text + "','" + txtCAddress.Text + "','" + txtDistrict.Text + "','" + txtCity.Text + "','" + txtClinetNo.Text + "','" + txtCEmail.Text + "')", con);
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
               
      

            }

            else
            {
                MessageBox.Show("A phone number must contain at least 10 digits", "Incorrect phone number");

            }


        }
          


            void BindData()
            {
                SqlCommand command = new SqlCommand("select * from Clients", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                clientsDataGridView.DataSource = dt;
            }

        



        private void txtCfName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCfirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
        }

        private void btnPreviousC_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();

        }

        private void btnLastC_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
          
        }
   

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtClinetNo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                 e.Handled = true ;
                 MessageBox.Show("Error , A phone number cannot contain letters");
            }

        }

        private void txtClinetNo_TextChanged(object sender, EventArgs e)
        {
            if (txtClinetNo.TextLength == 10)

            {
                txtClinetNo.ForeColor = Color.Black; 
            }
            else
            {
                txtClinetNo.ForeColor = Color.Red;

            }
        }
    }
}
