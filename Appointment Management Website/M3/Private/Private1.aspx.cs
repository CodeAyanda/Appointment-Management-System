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
    public partial class Private1 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst15;Persist Security Info=True;User ID=GroupWst15;Password=2rjsc");
        SqlDataReader dr;
        SqlCommand cmd;
        string newClientID;
        string UserEmail;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserEmail = Context.User.Identity.Name;
            TextBox1.Text = UserEmail;

            if (UserEmail != "ayeshamalhi@gmail.com")
            {
                LinkButton5.Visible = false;

            }
            if (UserEmail == "ayeshamalhi@gmail.com")
            {
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = true;
                LinkButton5.Visible = true;

            }
            if (UserEmail == "Ameerak@vodamail.co.za" || UserEmail == "Jodiek@gmail.co.za" || UserEmail == "Rae23@gmail.co.za")
            {
                LinkButton1.Visible = false;
                LinkButton2.Visible = false;
                LinkButton3.Visible = false;
                LinkButton5.Visible = true;

            }


            con.Open();
            string FetchData = "select top 1 CLIENT_ID From Clients WHERE CLIENTEMAILADDRESS='" + UserEmail + "'";

            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                LinkButton1.Visible = false;

            }

            con.Close();

            
        }




        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = false;
            Panel1.Visible = true;
            FirstName.Text = "";
            LastName.Text = "";
            CompanyName.Text = "";
            Address.Text = "";
            District.Text = "";
            City.Text = "";
            ContactNumber.Text = "";

        }

        /*
        private static void Clicka(object sender, EventArgs e)
        {
            Private1 prv = new Private1();
            prv.Button1_Click(sender, e);
        }*/


        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string FetchData = "select top 1 CLIENT_ID From Clients Order By CLIENT_ID Desc;";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lastClient;
                lastClient = dr[0].ToString();

                string lastFour = lastClient.Substring(lastClient.Length - 4);
                int newFourNum = Convert.ToInt32(lastFour) + 1;
                string newLastFour = newFourNum.ToString();


                if (newLastFour.Length == 1)
                {
                    newClientID = "C-000" + newLastFour;

                }
                if (newLastFour.Length == 2)
                {
                    newClientID = "C-00" + newLastFour;


                }
                if (newLastFour.Length == 3)
                {
                    newClientID = "C-0" + newLastFour;

                }
                if (newLastFour.Length == 4)
                {
                    newClientID = "C-" + newLastFour;

                }
            }
            con.Close();


            if (FirstName.Text == "" || LastName.Text == "" || CompanyName.Text == "" || Address.Text == "" || District.Text == "" || City.Text == "" || ContactNumber.Text == "")
            {

            }

            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [Clients] (CLIENT_ID, CLIENTFNAME, CLIENTLNAME, CLIENTCOMPANYNAME, CLIENTADDRESS, CLIENTDISTRICT, CLIENTCITY, CLIENTCONTACTNUMBER, CLIENTEMAILADDRESS) VALUES ('" + newClientID + "','" + FirstName.Text + "','" + LastName.Text + "','" + CompanyName.Text + "','" + Address.Text + "','" + District.Text + "','" + City.Text + "','" + ContactNumber.Text + "','" + UserEmail + "')", con);
                command.ExecuteNonQuery();
                con.Close();

                Panel2.Visible = false;

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Account Successfully Created.'); window.location.href='" + Request.RawUrl + "'; ", true); 
                Panel1.Visible = false;
                //await task
                //Response.Redirect(Request.RawUrl);

            }
            

        }



        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = false;
            Panel2.Visible = true;
            if(DetailsView1 == null || DetailsView1.Rows.Count == 0)
            {
                DetailsView1.Visible = false;
                Label17.Visible = true;
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel5.Visible = false;
            Panel3.Visible = true;

            con.Open();
            string FetchData = "select * From Clients WHERE CLIENTEMAILADDRESS = '" + TextBox1.Text + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                updateFN.Text = dr[1].ToString();
                updateLN.Text = dr[2].ToString();
                updateCN.Text = dr[3].ToString();
                updateA.Text = dr[4].ToString();
                updateD.Text = dr[5].ToString();
                updateC.Text = dr[6].ToString();
                updateN.Text = dr[7].ToString();

            }

            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (updateFN.Text == "" || updateLN.Text == "" || updateCN.Text == "" || updateA.Text == "" || updateD.Text == "" || updateC.Text == "" || updateN.Text == "")
            {

            }
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Clients SET CLIENTFNAME='" + updateFN.Text + "', CLIENTLNAME='" + updateLN.Text + "', CLIENTCOMPANYNAME='" + updateCN.Text + "', CLIENTADDRESS='" + updateA.Text + "', CLIENTDISTRICT='" + updateD.Text + "', CLIENTCITY='" + updateC.Text + "', CLIENTCONTACTNUMBER='" + updateN.Text + "', CLIENTEMAILADDRESS='" + UserEmail + "' WHERE CLIENTEMAILADDRESS='" + UserEmail + "'", con);
                command.ExecuteNonQuery();
                con.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Account Successfully Updated.'); window.location.href='" + Request.RawUrl + "';", true);
                Panel3.Visible = false;



            }
            DetailsView1.DataBind();
        }



        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = true;
            DetailsView2.Visible = false;
            searchCli.Text = "";
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DetailsView2.Visible = true;


        }

        protected void DetailsView2_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

    }
}   
