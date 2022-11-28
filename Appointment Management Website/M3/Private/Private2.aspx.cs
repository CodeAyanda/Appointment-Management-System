using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace M3.Private
{
    public partial class Private2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst15;Persist Security Info=True;User ID=GroupWst15;Password=2rjsc");
        SqlDataReader dr;
        SqlCommand cmd;
        string newApptID;
        string UserEmail;
        string loggedInClientID;

        protected void Page_Load(object sender, EventArgs e)
        {
            string UserEmaill = Context.User.Identity.Name;
            if (UserEmaill == "Ameerak@vodamail.co.za" || UserEmaill == "Jodiek@gmail.co.za" || UserEmaill == "Rae23@gmail.co.za")
            {
                LinkButton1.Visible = false;
                LinkButton2.Visible = false;
                LinkButton3.Visible = false;
                LinkButton4.Visible = false;
                LinkButton7.Visible = false;
                LinkButton6.Visible = false;
                LinkButton5.Visible = true;
            }

            if (UserEmaill == "ayeshamalhi@gmail.com")
            {
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = true;
                LinkButton4.Visible = true;
                LinkButton5.Visible = true;
                LinkButton6.Visible = true;
                LinkButton7.Visible = true;
            }
            if (UserEmaill != "Ameerak@vodamail.co.za" && UserEmaill != "Jodiek@gmail.co.za" && UserEmaill != "Rae23@gmail.co.za" && UserEmaill != "ayeshamalhi@gmail.com")
            {
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = true;
                LinkButton4.Visible = true;
                LinkButton6.Visible = true;
                LinkButton5.Visible = false;
                LinkButton7.Visible = false;

            }





        }

        protected void DateCustVal_Validate(object source, ServerValidateEventArgs args)
        {
            if (Date.SelectedDate == null
                || Date.SelectedDate == new DateTime(0001, 1, 1, 0, 0, 0))
            {

                args.IsValid = Date.SelectedDate != default(DateTime);
            }
            else
            {
                args.IsValid = Date.SelectedDate != default(DateTime);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;

            PestController.SelectedIndex = 0;
            TimeSlot.SelectedIndex = 0;
            PaymentMethod.SelectedIndex = 0;
        }





        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string FetchData = "select top 1 APPOINTMENT_ID From Service_Appointment Order By APPOINTMENT_ID Desc;";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lastAppt;
                lastAppt = dr[0].ToString();

                string lastFour = lastAppt.Substring(lastAppt.Length - 4);
                int newFourNum = Convert.ToInt32(lastFour) + 1;
                string newLastFour = newFourNum.ToString();


                if (newLastFour.Length == 1)
                {
                    newApptID = "A-000" + newLastFour;

                }
                if (newLastFour.Length == 2)
                {
                    newApptID = "A-00" + newLastFour;


                }
                if (newLastFour.Length == 3)
                {
                    newApptID = "A-0" + newLastFour;

                }
                if (newLastFour.Length == 4)
                {
                    newApptID = "A-" + newLastFour;

                }

            }
            con.Close();

            con.Open();
            string UserEmaill = Context.User.Identity.Name;
            string FetchData2 = "Select CLIENT_ID from Clients WHERE CLIENTEMAILADDRESS='" + UserEmaill + "'";
            cmd = new SqlCommand(FetchData2, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                loggedInClientID = dr[0].ToString();

            }

            con.Close();

            con.Open();
            string status = "Active";

            DateTime selectedDate = Date.SelectedDate;
            DateTime mydate, todaysDate = new DateTime();
            mydate = new DateTime(0001, 1, 1, 0, 0, 0);
            todaysDate = DateTime.Now;
            if (selectedDate == mydate)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pick a date for the Appointment')", true);

            }
            else if (selectedDate < todaysDate)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pick a date greater than todays date')", true);

            }
            else
            {
                if (PestController.SelectedIndex == 0 || selectedDate == mydate || TimeSlot.SelectedIndex == 0 || PaymentMethod.SelectedIndex == 0)
                {

                }
                else
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Service_Appointment] (APPOINTMENT_ID, CLIENT_ID, DATE, TIMESLOT, PEST_CONTROLLER, STATUS, PAYMENT_METHOD) VALUES ('" + newApptID + "','" + loggedInClientID + "','" + selectedDate + "','" + TimeSlot.SelectedValue + "','" + PestController.SelectedValue + "', '" + status + "', '" + PaymentMethod.SelectedValue + "')", con);

                    command.ExecuteNonQuery();
                    con.Close();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Appointment Successfully Created.'); window.location.href='" + Request.RawUrl + "';", true);
                    Panel1.Visible = false;


                }

            }



        }

        public void InitialiseTimeSlots()
        {
            TimeSlot.Items.Clear();
            TimeSlot.Items.Insert(0, "Select time slot");
            TimeSlot.Items.Insert(1, "9h00 - 10h00");
            TimeSlot.Items.Insert(2, "10h00 - 11h00");
            TimeSlot.Items.Insert(3, "11h00 - 12h00");
            TimeSlot.Items.Insert(4, "12h00 - 13h00");
            TimeSlot.Items.Insert(5, "13h00 - 14h00");
            TimeSlot.Items.Insert(6, "14h00 - 15h00");
            TimeSlot.Items.Insert(7, "15h00 - 16h00");


        }

        protected void Selection_Changed(object sender, EventArgs e)
        {

            InitialiseTimeSlots();


            TimeSlot.SelectedIndex = 0;
            DateTime selectedDate = new DateTime();
            selectedDate = Date.SelectedDate;

            con.Open();

            UserEmail = Context.User.Identity.Name;
            string FetchData1 = "Select CLIENT_ID from Clients WHERE CLIENTEMAILADDRESS='" + UserEmail + "'";
            cmd = new SqlCommand(FetchData1, con);
            dr = cmd.ExecuteReader();

            string thisClientID = "";
            while (dr.Read())
            {
                thisClientID = dr[0].ToString();
            }



            con.Close();

            con.Open();

            List<string> unavailableSlots = new List<string>();

            string FetchData = "Select TIMESLOT From Service_Appointment WHERE DATE = '" + selectedDate + "' AND STATUS = 'Active' AND PEST_CONTROLLER = '" + PestController.SelectedValue + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            int count = dr.FieldCount;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string slot = dr[0].ToString();
                    unavailableSlots.Add(slot);

                }

            }

            foreach (string item in unavailableSlots)
            {
                TimeSlot.Items.Remove(TimeSlot.Items.FindByValue(item));
            }

            Date.DataBind();
            TimeSlot.DataBind();


            con.Close();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;

            con.Open();
            string loggedIn = Context.User.Identity.Name;
            string FetchData = "select CLIENT_ID From Clients WHERE CLIENTEMAILADDRESS = '" + loggedIn + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TextBox1.Text = dr[0].ToString();

            }

            con.Close();
            GridView1.Visible = true;
            if (GridView1 == null || GridView1.Rows.Count == 0)
            {
                Label16.Visible = true;
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel3.Visible = true;
            Panel7.Visible = false;
            Panel8.Visible = false;

            con.Open();
            string loggedIn = Context.User.Identity.Name;
            string FetchData = "select CLIENT_ID From Clients WHERE CLIENTEMAILADDRESS = '" + loggedIn + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TextBox2.Text = dr[0].ToString();

            }

            con.Close();
            GridView2.Visible = true;

            if (GridView2 == null || GridView2.Rows.Count == 0)
            {
                Label17.Visible = true;
            }
        }



        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int rowindex;
            string timeSlot;
            string pestC;
            string selectedDate;
            string paymentMethod;
            string SAid;


            if (e.CommandName == "btnClick")
            {
                rowindex = Convert.ToInt32(e.CommandArgument);
                selectedDate = GridView2.Rows[rowindex].Cells[2].Text;
                timeSlot = GridView2.Rows[rowindex].Cells[3].Text;
                pestC = GridView2.Rows[rowindex].Cells[4].Text;
                paymentMethod = GridView2.Rows[rowindex].Cells[6].Text;
                SAid = GridView2.Rows[rowindex].Cells[1].Text;



                updatePC.SelectedValue = pestC;
                updateTS.SelectedValue = timeSlot;
                DateTime mydate = Convert.ToDateTime(selectedDate);
                updateDate.SelectedDate = mydate;
                updatePM.SelectedValue = paymentMethod;
                TextBox3.Text = SAid;

                /*
                GridView2.Columns[0].Visible = true;
                GridView2.DataBind();
                
                GridView2.Columns[0].Visible = false;
                */
                Panel4.Visible = true;


            }



        }

        protected void updateApp_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = updateDate.SelectedDate;
            DateTime mydate, todaysDate = new DateTime();
            mydate = new DateTime(0001, 1, 1, 0, 0, 0);
            todaysDate = DateTime.Now;

            if (selectedDate == mydate)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pick a date for the Appointment')", true);

            }
            else if (selectedDate < todaysDate)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pick a date greater than todays date')", true);

            }
            else
            {
                if (updatePC.SelectedIndex == 0 || selectedDate == mydate || updateTS.SelectedIndex == 0 || updatePM.SelectedIndex == 0)
                {

                }
                else
                {
                    con.Open();

                    DateTime finalDate = updateDate.SelectedDate;
                    string finalPC = updatePC.SelectedValue;
                    string finalTimeSlots = updateTS.SelectedValue;
                    string finalPM = updatePM.SelectedValue;
                    //String ApptID = 



                    string sql = "UPDATE Service_Appointment SET DATE='" + updateDate.SelectedDate + "', TIMESLOT='" + updateTS.SelectedValue + "', PEST_CONTROLLER='" + updatePC.SelectedValue + "', PAYMENT_METHOD='" + updatePM.SelectedValue + "' WHERE APPOINTMENT_ID='" + TextBox3.Text + "'";

                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Appointment Successfully Updated.'); window.location.href='" + Request.RawUrl + "';", true);
                    GridView2.DataBind();

                }


            }


        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel6.Visible = false;
            Panel5.Visible = true;
            Panel7.Visible = false;
            Panel8.Visible = false;

            con.Open();
            string loggedIn = Context.User.Identity.Name;
            string FetchData = "select CLIENT_ID From Clients WHERE CLIENTEMAILADDRESS = '" + loggedIn + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TextBox4.Text = dr[0].ToString();

            }

            con.Close();
            GridView3.Visible = true;
            if (GridView3 == null || GridView3.Rows.Count == 0)
            {
                Label18.Visible = true;
            }
        }


        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int rowindex;
            string ServAppID;
            if (e.CommandName == "btn2Clickk")
            {

                rowindex = Convert.ToInt32(e.CommandArgument);
                ServAppID = GridView3.Rows[rowindex].Cells[0].Text;

                con.Open();

                string deleteSql = "DELETE FROM Service_Appointment WHERE APPOINTMENT_ID='" + ServAppID + "';";
                SqlCommand command = new SqlCommand(deleteSql, con);
                command.ExecuteNonQuery();


                con.Close();

                GridView3.DataBind();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Appointment Successfully Deleted.'); window.location.href='" + Request.RawUrl + "';", true);

            }



        }

        protected void PestController_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date.SelectedDate = new DateTime(0001, 1, 1, 0, 0, 0);
            TimeSlot.SelectedIndex = 0;

            PestController.DataBind();
            Date.DataBind();
            TimeSlot.DataBind();

        }

        protected void TimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void updatePC_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDate.SelectedDate = new DateTime(0001, 1, 1, 0, 0, 0);
            updateTS.SelectedIndex = 0;

            updatePC.DataBind();
            updateDate.DataBind();
            updateTS.DataBind();
        }

        public void InitialiseUpdateTS()
        {
            updateTS.Items.Clear();
            updateTS.Items.Insert(0, "Select time slot");
            updateTS.Items.Insert(1, "9h00 - 10h00");
            updateTS.Items.Insert(2, "10h00 - 11h00");
            updateTS.Items.Insert(3, "11h00 - 12h00");
            updateTS.Items.Insert(4, "12h00 - 13h00");
            updateTS.Items.Insert(5, "13h00 - 14h00");
            updateTS.Items.Insert(6, "14h00 - 15h00");
            updateTS.Items.Insert(7, "15h00 - 16h00");


        }

        protected void updateDate_SelectionChanged(object sender, EventArgs e)
        {
            InitialiseUpdateTS();


            updateTS.SelectedIndex = 0;
            DateTime selectedDate = new DateTime();
            selectedDate = updateDate.SelectedDate;

            con.Open();

            UserEmail = Context.User.Identity.Name;
            string FetchData1 = "Select CLIENT_ID from Clients WHERE CLIENTEMAILADDRESS='" + UserEmail + "'";
            cmd = new SqlCommand(FetchData1, con);
            dr = cmd.ExecuteReader();

            string thisClientID = "";
            while (dr.Read())
            {
                thisClientID = dr[0].ToString();
            }
            con.Close();

            con.Open();

            List<string> unavailableSlots2 = new List<string>();

            string FetchData = "Select TIMESLOT From Service_Appointment WHERE DATE = '" + selectedDate + "' AND STATUS = 'Active' AND PEST_CONTROLLER = '" + updatePC.SelectedValue + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            int count = dr.FieldCount;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string slot = dr[0].ToString();
                    unavailableSlots2.Add(slot);

                }

            }

            foreach (string item in unavailableSlots2)
            {
                updateTS.Items.Remove(updateTS.Items.FindByValue(item));
            }

            updateDate.DataBind();
            updateTS.DataBind();

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Panel6.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;

            string UserEmaill = Context.User.Identity.Name;
            con.Open();
            string FetchData = "select PEST_CONTROLLER_ID From Pest_Controller WHERE EMAIL='" + UserEmaill + "'";

            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                TextBox5.Text = dr[0].ToString();

            }

            con.Close();

            RadioButton1.Checked = true;


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView4.DataBind();
            if (DropDownList1.SelectedIndex == 0)
            {

            }
            if (RadioButton1.Checked == true)
            {
                GridView4.Visible = true;
                GridView5.Visible = false;
            }
            if (RadioButton2.Checked == true)
            {
                GridView5.Visible = true;
                GridView4.Visible = false;
            }

        }

        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            filterDate.Visible = false;
            GridView4.Visible = true;
            GridView5.Visible = false;
            RadioButton2.Checked = false;
            RadioButton5.Checked = false;
            
            GridView4.DataBind();
            GridView5.DataBind();
            RadioButton2.DataBind();
            RadioButton5.DataBind();

        }

        protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {
            filterDate.SelectedDates.Clear();
            filterDate.Visible = true;
            GridView5.Visible = true;
            GridView4.Visible = false;
            RadioButton1.Checked = false;
            RadioButton5.Checked = false;
            
            GridView4.DataBind();
            GridView5.DataBind();
            RadioButton1.DataBind();
            RadioButton5.DataBind();
            filterDate.DataBind();

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            filterDate.SelectedDate = DateTime.Now;
            filterDate.Visible = false;
            GridView5.Visible = true;
            GridView4.Visible = false;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton1.DataBind();
            RadioButton2.DataBind();
            GridView4.DataBind();
            GridView5.DataBind();
            


        }

        protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void getLoggedInClientID()
        {
            string loggedInID;
            string Emaill = Context.User.Identity.Name;
            con.Open();
            string FetchData = "Select * from Clients WHERE CLIENTEMAILADDRESS='" + Emaill + "'";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                loggedInID = dr[0].ToString();
                TextBox6.Text = loggedInID;

            }

        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {



            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = true;
            Panel8.Visible = false;

            getLoggedInClientID();
            GridView6.Visible = true;
            if (GridView6 == null || GridView6.Rows.Count == 0)
            {
                Label19.Visible = true;
                //GridView6.Visible = false;
            }
        }

        protected void GridView7_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "updatePriceClick")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string apptId = GridView7.Rows[rowIndex].Cells[0].Text;
                string newPrice = "";

                try
                {
                    newPrice = (GridView7.Rows[rowIndex].FindControl("TextBox7") as TextBox).Text;

                    if (newPrice == "")
                    {

                    }
                    else
                    {
                        con.Open();
                        string sql = "UPDATE Service_Appointment SET PRICE='" + Convert.ToDecimal(newPrice) + "' WHERE APPOINTMENT_ID='" + apptId + "'";

                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        con.Close();
                        GridView7.DataBind();
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "Updated", "alert('Appointment Successfully Updated.')", true);
                    }
                }
                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Error", "alert('Enter A Valid Price')", true);

                }

            }



        }

        protected void GridView8_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "updatePriceClick2")
            {
                
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string apptId = GridView8.Rows[rowIndex].Cells[0].Text;
                string newPrice = "";

                try
                {
                    newPrice = (GridView8.Rows[rowIndex].FindControl("TextBox8") as TextBox).Text;
                    if (newPrice == "")
                    {

                    }
                    else
                    {
                        con.Open();
                        string sql = "UPDATE Service_Appointment SET PRICE='" + Convert.ToDecimal(newPrice) + "' WHERE APPOINTMENT_ID='" + apptId + "'";

                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        con.Close();
                        GridView8.DataBind();
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "Updated", "alert('Appointment Successfully Updated.')", true);

                    }
                }
                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Error", "alert('Enter A Valid Price')", true);

                }
            }

        }

        protected void GridView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton4.Checked = false;
            RadioButton6.Checked = false;
            GridView7.Visible = true;
            GridView8.Visible = false;
            Calendar1.Visible = false;
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            RadioButton3.Checked = false;
            RadioButton6.Checked = false;
            GridView8.Visible = true;
            GridView7.Visible = false;
            Calendar1.Visible = true;

        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Now;
            Calendar1.Visible = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            GridView8.Visible = true;
            GridView7.Visible = false;

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Panel8.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;



        }

        
    }

}