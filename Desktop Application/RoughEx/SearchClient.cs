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
    public partial class SearchClient : Form
    {
        public SearchClient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst15;User ID=GroupWst15;Password=2rjsc");
        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientDS);

        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientDS.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientDS.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchClient.Text !="")
            {
                SqlCommand command = new SqlCommand("Select * from Clients where CLIENT_ID ='" +(txtSearchClient.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                clientsDataGridView.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Enter Client ID");          
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSearchCSurname.Text != "")
            {
                SqlCommand command = new SqlCommand("Select * from Clients where CLIENTLNAME ='" + (txtSearchCSurname.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                clientsDataGridView.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Enter Client Surname");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearchCComp .Text != "")
            {
                SqlCommand command = new SqlCommand("Select * from Clients where CLIENTCOMPANYNAME ='" + (txtSearchCComp.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                clientsDataGridView.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Enter Client Company Name");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSearchCEmailA .Text != "")
            {
                SqlCommand command = new SqlCommand("Select * from Clients where CLIENTEMAILADDRESS ='" + (txtSearchCEmailA.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                clientsDataGridView.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Enter Client Email Address");
            }
        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients where CLIENT_ID like('" + txtSearchClient.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientsDataGridView.DataSource = dt;

            con.Close();
        }

        private void txtSearchCSurname_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients where CLIENTLNAME like('" + txtSearchCSurname.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientsDataGridView.DataSource = dt;

            con.Close();
        }

        private void txtSearchCComp_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients where CLIENTCOMPANYNAME like('" + txtSearchCComp.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientsDataGridView.DataSource = dt;

            con.Close();
        }

        private void txtSearchCEmailA_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clients where CLIENTEMAILADDRESS like('" + txtSearchCEmailA.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientsDataGridView.DataSource = dt;

            con.Close();
        }
    }
}
  
