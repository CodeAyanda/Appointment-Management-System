using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace M3.Private
{
    public partial class Private3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst15;Persist Security Info=True;User ID=GroupWst15;Password=2rjsc");
        SqlDataReader dr;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel4.Visible = false;


        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel4.Visible = false;
        }

        protected void AddPC_Click(object sender, EventArgs e)
        {
            if (PCid.Text == "" || PCName.Text == "" || PCSurname.Text == "" || PCPhone.Text == "" || PCEmail.Text == "")
            {

            }
            else
            {
                con.Open();
                string pestAvail = "Yes";
                SqlCommand command = new SqlCommand("INSERT INTO [Pest_Controller] (PEST_CONTROLLER_ID, NAME, SURNAME, PHONE_NUMBER, EMAIL, PEST_CONTROLLER_AVAILABILITY) VALUES ('" + PCid.Text + "','" + PCName.Text + "','" + PCSurname.Text + "','" + PCPhone.Text + "','" + PCEmail.Text + "', '" + pestAvail + "')", con);

                command.ExecuteNonQuery();


                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pest Controller Successfully Added.')", true);
                Panel1.Visible = false;

            }


        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel4.Visible = true;

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsView1.Visible = true;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;

            con.Open();

            string FetchData = "select * From Pest_Controller WHERE PEST_CONTROLLER_ID='" + DropDownList1.SelectedValue + "';";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                updatePCid.Text = dr[0].ToString();
                updatePCN.Text = dr[1].ToString();
                updatePCS.Text = dr[2].ToString();
                updatePCPN.Text = dr[3].ToString();
                updatePCE.Text = dr[4].ToString();

            }

            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (updatePCid.Text == "" || updatePCN.Text == "" || updatePCS.Text == "" || updatePCPN.Text == "" || updatePCE.Text == "")
            {

            }
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Pest_Controller SET PEST_CONTROLLER_ID='" + updatePCid.Text + "', NAME='" + updatePCN.Text + "', SURNAME='" + updatePCS.Text + "', PHONE_NUMBER='" + updatePCPN.Text + "' WHERE PEST_CONTROLLER_ID='" + DropDownList1.SelectedValue + "'", con);
                command.ExecuteNonQuery();


                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pest Controller Successfully Updated.')", true);

                Panel2.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PCid.Text = string.Empty;
            PCName.Text = string.Empty;
            PCSurname.Text = string.Empty;
            PCPhone.Text = string.Empty;
            PCEmail.Text = string.Empty;
        }
    }
}