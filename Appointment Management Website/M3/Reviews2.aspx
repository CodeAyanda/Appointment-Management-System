
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reviews2.aspx.cs" Inherits="M3.Reviews2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-repeat: repeat; background-color: #CCFFD2;">
        <h1>Reviews</h1>
        <asp:Panel ID="Panel12" runat="server" Height="67px" Visible="True">
            <h3>Login To Leave Us a Review</h3></asp:Panel>
            <asp:Panel ID="Panel11" runat="server" Height="224px" Visible="False" Width="926px">
                <h4> Leave a review down below </h4>
                    <asp:TextBox ID="TextBox1" runat="server" Height="114px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="636px"></asp:TextBox>
                    <script type="text/javascript" >
                        function ConfirmOnDelete()
                        {
                            if (confirm("Submit Review?")) 
                                if (TextBox1.Text != "") {
                                    return alert("REVIEW SUBMITTED");

                                }

                                else
                                    return false;
                           
                        }
                    </script>
                    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return ConfirmOnDelete();" Text="Submit" />
                

&nbsp;&nbsp;<asp:Label ID="Label33" runat="server" Visible="False"></asp:Label>
                <br /><br /><asp:Label ID="Label31" runat="server" Text="Number Of Stars"></asp:Label>
&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="47px" Width="50px" ForeColor="Black">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <br />
                <br />
        </asp:Panel>
        <br />
        <p>

            <asp:Label ID="Label32" runat="server" Text="<u>User Reviews</u>"></asp:Label>

        </p>
         
        <asp:Panel ID="Panel1" runat="server" Height="76px" style="margin-top: 0px" Width="622px" Visible="False">
            <asp:Image ID="Image1" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label21" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="76px" Width="917px" Visible="False">
            <asp:Image ID="Image2" runat="server" Height="25px" ImageAlign="Middle" Width="123px" />
            <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label22" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="77px" Visible="False">
            <asp:Image ID="Image3" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label23" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image4" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label24" runat="server" Text="Label" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel5" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image5" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label25" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel6" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image6" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label26" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel7" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image7" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label17" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label27" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel8" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image8" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label28" runat="server" Text="Label" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel9" runat="server" Height="75px" Visible="False">
            <asp:Image ID="Image9" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label19" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label29" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel10" runat="server" Height="76px" Visible="False">
            <asp:Image ID="Image10" runat="server" Height="25px" Width="123px" />
            <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            &nbsp;
            <asp:Label ID="Label30" runat="server" Font-Italic="True"></asp:Label>
        </asp:Panel>
        <br />
                &nbsp;</div>

</asp:Content>

