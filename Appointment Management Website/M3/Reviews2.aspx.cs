using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace M3
{
    public partial class Reviews2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst15;Persist Security Info=True;User ID=GroupWst15;Password=2rjsc");
        SqlDataReader dr;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

            bool val1 = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == true)
            {
                Panel12.Visible = false;
                Panel11.Visible = true;

            }
            con.Open();
            string FetchData = "Select * from Reviews Order By Date Desc";
            cmd = new SqlCommand(FetchData, con);
            dr = cmd.ExecuteReader();
            //<asp:Image ID="Image1" runat="server" Height="47px" Width="47px" />
            //<img src="starIcon.png" alt="Pests" style="width:40%">
            //Image myImage = new Image();



            while (dr.Read())
            {
                Label21.Text = dr[0].ToString();
                Label1.Text = dr[1].ToString();
                Label11.Text = dr[2].ToString();
                string Rating = dr[3].ToString();

                if (Rating.ToString() != "")
                {
                    Panel1.Visible = true;
                    switch (Rating)
                    {
                        case "5":
                            Image1.ImageUrl = "~/fiveStars.png";
                            break;
                        case "4":
                            Image1.ImageUrl = "~/fourStars.png";
                            break;
                        case "3":
                            Image1.ImageUrl = "~/threeStars.png";
                            break;
                        case "2":
                            Image1.ImageUrl = "~/twoStars.png";
                            break;
                        case "1":
                            Image1.ImageUrl = "~/oneStar.png";
                            break;
                        case "0":
                            Image1.ImageUrl = "~/zeroStars.png";
                            break;

                    }

                }


                while (dr.Read())
                {
                    Label22.Text = dr[0].ToString();
                    Label2.Text = dr[1].ToString();
                    Label12.Text = dr[2].ToString();
                    string Rating2 = dr[3].ToString();
                    if (Rating2 != "")
                    {
                        Panel2.Visible = true;
                        switch (Rating2)
                        {
                            case "5":
                                Image2.ImageUrl = "~/fiveStars.png";
                                break;
                            case "4":
                                Image2.ImageUrl = "~/fourStars.png";
                                break;
                            case "3":
                                Image2.ImageUrl = "~/threeStars.png";
                                break;
                            case "2":
                                Image2.ImageUrl = "~/twoStars.png";
                                break;
                            case "1":
                                Image2.ImageUrl = "~/oneStar.png";
                                break;
                            case "0":
                                Image2.ImageUrl = "~/zeroStars.png";
                                break;

                        }


                    }

                    while (dr.Read())
                    {
                        Label23.Text = dr[0].ToString();
                        Label3.Text = dr[1].ToString();
                        Label13.Text = dr[2].ToString();
                        string Rating3 = dr[3].ToString();

                        if (Rating3 != "")
                        {
                            Panel3.Visible = true;
                            switch (Rating3)
                            {
                                case "5":
                                    Image3.ImageUrl = "~/fiveStars.png";
                                    break;
                                case "4":
                                    Image3.ImageUrl = "~/fourStars.png";
                                    break;
                                case "3":
                                    Image3.ImageUrl = "~/threeStars.png";
                                    break;
                                case "2":
                                    Image3.ImageUrl = "~/twoStars.png";
                                    break;
                                case "1":
                                    Image3.ImageUrl = "~/oneStar.png";
                                    break;
                                case "0":
                                    Image3.ImageUrl = "~/zeroStars.png";
                                    break;

                            }


                        }


                        while (dr.Read())
                        {
                            Label24.Text = dr[0].ToString();
                            Label4.Text = dr[1].ToString();
                            Label14.Text = dr[2].ToString();
                            string Rating4 = dr[3].ToString();

                            if (Rating4 != "")
                            {
                                Panel4.Visible = true;
                                switch (Rating4)
                                {
                                    case "5":
                                        Image4.ImageUrl = "~/fiveStars.png";
                                        break;
                                    case "4":
                                        Image4.ImageUrl = "~/fourStars.png";
                                        break;
                                    case "3":
                                        Image4.ImageUrl = "~/threeStars.png";
                                        break;
                                    case "2":
                                        Image4.ImageUrl = "~/twoStars.png";
                                        break;
                                    case "1":
                                        Image4.ImageUrl = "~/oneStar.png";
                                        break;
                                    case "0":
                                        Image4.ImageUrl = "~/zeroStars.png";
                                        break;

                                }


                            }


                            while (dr.Read())
                            {
                                Label25.Text = dr[0].ToString();
                                Label5.Text = dr[1].ToString();
                                Label15.Text = dr[2].ToString();
                                string Rating5 = dr[3].ToString();

                                if (Rating5 != "")
                                {
                                    Panel5.Visible = true;
                                    switch (Rating5)
                                    {
                                        case "":
                                            break;
                                        case "5":
                                            Image5.ImageUrl = "~/fiveStars.png";
                                            break;
                                        case "4":
                                            Image5.ImageUrl = "~/fourStars.png";
                                            break;
                                        case "3":
                                            Image5.ImageUrl = "~/threeStars.png";
                                            break;
                                        case "2":
                                            Image5.ImageUrl = "~/twoStars.png";
                                            break;
                                        case "1":
                                            Image5.ImageUrl = "~/oneStar.png";
                                            break;
                                        case "0":
                                            Image5.ImageUrl = "~/zeroStars.png";
                                            break;

                                    }



                                }


                                while (dr.Read())
                                {
                                    Label26.Text = dr[0].ToString();
                                    Label6.Text = dr[1].ToString();
                                    Label16.Text = dr[2].ToString();
                                    string Rating6 = dr[3].ToString();

                                    if (Rating6 != "")
                                    {
                                        Panel6.Visible = true;
                                        switch (Rating6)
                                        {
                                            case "5":
                                                Image6.ImageUrl = "~/fiveStars.png";
                                                break;
                                            case "4":
                                                Image6.ImageUrl = "~/fourStars.png";
                                                break;
                                            case "3":
                                                Image6.ImageUrl = "~/threeStars.png";
                                                break;
                                            case "2":
                                                Image6.ImageUrl = "~/twoStars.png";
                                                break;
                                            case "1":
                                                Image6.ImageUrl = "~/oneStar.png";
                                                break;
                                            case "0":
                                                Image6.ImageUrl = "~/zeroStars.png";
                                                break;

                                        }


                                    }


                                    while (dr.Read())
                                    {
                                        Label27.Text = dr[0].ToString();
                                        Label7.Text = dr[1].ToString();
                                        Label17.Text = dr[2].ToString();
                                        string Rating7 = dr[3].ToString();


                                        if (Rating7 != "")
                                        {
                                            Panel7.Visible = true;
                                            switch (Rating7)
                                            {
                                                case "5":
                                                    Image7.ImageUrl = "~/fiveStars.png";
                                                    break;
                                                case "4":
                                                    Image7.ImageUrl = "~/fourStars.png";
                                                    break;
                                                case "3":
                                                    Image7.ImageUrl = "~/threeStars.png";
                                                    break;
                                                case "2":
                                                    Image7.ImageUrl = "~/twoStars.png";
                                                    break;
                                                case "1":
                                                    Image7.ImageUrl = "~/oneStar.png";
                                                    break;
                                                case "0":
                                                    Image7.ImageUrl = "~/zeroStars.png";
                                                    break;

                                            }


                                        }


                                        while (dr.Read())
                                        {
                                            Label28.Text = dr[0].ToString();
                                            Label8.Text = dr[1].ToString();
                                            Label18.Text = dr[2].ToString();
                                            string Rating8 = dr[3].ToString();

                                            if (Rating8 != "")
                                            {
                                                Panel8.Visible = true;
                                                switch (Rating8)
                                                {
                                                    case "5":
                                                        Image8.ImageUrl = "~/fiveStars.png";
                                                        break;
                                                    case "4":
                                                        Image8.ImageUrl = "~/fourStars.png";
                                                        break;
                                                    case "3":
                                                        Image8.ImageUrl = "~/threeStars.png";
                                                        break;
                                                    case "2":
                                                        Image8.ImageUrl = "~/twoStars.png";
                                                        break;
                                                    case "1":
                                                        Image8.ImageUrl = "~/oneStar.png";
                                                        break;
                                                    case "0":
                                                        Image8.ImageUrl = "~/zeroStars.png";
                                                        break;

                                                }

                                            }

                                            while (dr.Read())
                                            {
                                                Label29.Text = dr[0].ToString();
                                                Label9.Text = dr[1].ToString();
                                                Label19.Text = dr[2].ToString();
                                                string Rating9 = dr[3].ToString();

                                                if (Rating9 != "")
                                                {
                                                    Panel9.Visible = true;

                                                    switch (Rating9)
                                                    {
                                                        case "5":
                                                            Image9.ImageUrl = "~/fiveStars.png";
                                                            break;
                                                        case "4":
                                                            Image9.ImageUrl = "~/fourStars.png";
                                                            break;
                                                        case "3":
                                                            Image9.ImageUrl = "~/threeStars.png";
                                                            break;
                                                        case "2":
                                                            Image9.ImageUrl = "~/twoStars.png";
                                                            break;
                                                        case "1":
                                                            Image9.ImageUrl = "~/oneStar.png";
                                                            break;
                                                        case "0":
                                                            Image9.ImageUrl = "~/zeroStars.png";
                                                            break;

                                                    }


                                                }


                                            }

                                            while (dr.Read())
                                            {
                                                Label30.Text = dr[0].ToString();
                                                Label10.Text = dr[1].ToString();
                                                Label20.Text = dr[2].ToString();
                                                string Rating10 = dr[3].ToString();

                                                if (Rating10 != "")
                                                {
                                                    Panel10.Visible = true;
                                                    switch (Rating10)
                                                    {
                                                        case "5":
                                                            Image10.ImageUrl = "~/fiveStars.png";
                                                            break;
                                                        case "4":
                                                            Image10.ImageUrl = "~/fourStars.png";
                                                            break;
                                                        case "3":
                                                            Image10.ImageUrl = "~/threeStars.png";
                                                            break;
                                                        case "2":
                                                            Image10.ImageUrl = "~/twoStars.png";
                                                            break;
                                                        case "1":
                                                            Image10.ImageUrl = "~/oneStar.png";
                                                            break;
                                                        case "0":
                                                            Image10.ImageUrl = "~/zeroStars.png";
                                                            break;

                                                    }

                                                }




                                            }


                                        }

                                    }

                                }
                            }

                        }

                    }
                }
            }
            con.Close();
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string loggedInUsername = "";
            if (User.Identity.IsAuthenticated)
            {
                loggedInUsername = User.Identity.Name;
                if (TextBox1.Text != "")
                {
                    DateTime now = DateTime.Now;
                    SqlCommand command = new SqlCommand("INSERT INTO [Reviews] (ReviewerName, Review, Date, NumberOfStars) VALUES ('" + loggedInUsername + "','" + TextBox1.Text + "','" + now + "','" + DropDownList1.SelectedIndex + "')", con);
                    command.ExecuteNonQuery();

                    Label33.Visible = true;
                    Label33.Text = "REVIEW SUBMITTED";
                    TextBox1.Text = "";



                }
                else
                {
                    Label33.Visible = true;
                    Label33.Text = "REVIEW CANNOT BE EMPTY";
                }


            }
            con.Close();


            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}
        
