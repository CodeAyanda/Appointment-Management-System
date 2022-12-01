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
    public partial class SearchPestController : Form
    {
        public SearchPestController()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst15; User ID = GroupWst15; Password =2rjsc");

        private void pest_ControllerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pest_ControllerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pCDS);

        }

        private void SearchPestController_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCDS.Pest_Controller' table. You can move, or remove it, as needed.
            this.pest_ControllerTableAdapter.Fill(this.pCDS.Pest_Controller);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pest_Controller where NAME like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            pest_ControllerDataGridView.DataSource = dt;

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pest_Controller where SURNAME like('" + textBox2.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            pest_ControllerDataGridView.DataSource = dt;

            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pest_Controller where EMAIL like('" + textBox3.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            pest_ControllerDataGridView.DataSource = dt;

            conn.Close();
        }
    }
}
