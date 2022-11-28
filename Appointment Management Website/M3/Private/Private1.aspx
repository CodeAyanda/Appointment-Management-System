<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Private1.aspx.cs" Inherits="M3.Private.Private1" MaintainScrollPositionOnPostback="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Clients</h3>
    <hr />
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large">CREATE NEW ACCOUNT</asp:LinkButton>
    </div>
    <div>    
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Size="Large">VIEW CLIENT INFORMATION</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Font-Size="Large">UPDATE CLIENT DETAILS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" Font-Size="Large">SEARCH CLIENTS</asp:LinkButton>
    </div>
    
    <hr />

    <asp:Panel ID="Panel1" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="createAccount">
                    <div class="form-horizontal">
                        <h4>CREATE NEW ACCOUNT</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal1" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="FirstName" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                                CssClass="text-danger" ErrorMessage="The First Name field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="LastName" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                                CssClass="text-danger" ErrorMessage="The Last Name field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Company Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="CompanyName" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="CompanyName"
                                CssClass="text-danger" ErrorMessage="The Company Name field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" AssociatedControlID="Address" CssClass="col-md-2 control-label">Address</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="Address" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Address"
                                CssClass="text-danger" ErrorMessage="The Address field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" AssociatedControlID="District" CssClass="col-md-2 control-label">District</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="District" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="District"
                                CssClass="text-danger" ErrorMessage="The District field is required." ValidationGroup="ValidationGroup1"/>
                                </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" AssociatedControlID="City" CssClass="col-md-2 control-label">City</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="City" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
                                CssClass="text-danger" ErrorMessage="The City field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" AssociatedControlID="ContactNumber" CssClass="col-md-2 control-label">Contact Number</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="ContactNumber" CssClass="form-control" runat="server" TextMode="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ContactNumber"
                                CssClass="text-danger" ErrorMessage="The Contact Number field is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button ID="Button1" runat="server" Text="CREATE ACCOUNT" CssClass="btn btn-default" OnClientClick="return confirm('Do you want to create new account ?');" ValidationGroup="ValidationGroup1" Width="172px" OnClick="Button1_Click"/>
                                
                                &nbsp;</div>
                        </div>
                        </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="viewClientInformation">
                    <div class="form-horizontal">
                        <h4>VIEW CLIENT INFORMATION</h4>
                        <hr />
                        <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
                        <asp:DetailsView ID="DetailsView1" runat="server" Height="95px" Width="409px" AutoGenerateRows="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="CLIENT_ID" DataSourceID="SqlDataSource1" ForeColor="Black">
                            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <Fields>
                                <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" ReadOnly="True" SortExpression="CLIENT_ID" />
                                <asp:BoundField DataField="CLIENTFNAME" HeaderText="FIRST NAME" SortExpression="CLIENTFNAME" />
                                <asp:BoundField DataField="CLIENTLNAME" HeaderText="LAST NAME" SortExpression="CLIENTLNAME" />
                                <asp:BoundField DataField="CLIENTCOMPANYNAME" HeaderText="COMPANY NAME" SortExpression="CLIENTCOMPANYNAME" />
                                <asp:BoundField DataField="CLIENTADDRESS" HeaderText="ADDRESS" SortExpression="CLIENTADDRESS" />
                                <asp:BoundField DataField="CLIENTDISTRICT" HeaderText="DISTRICT" SortExpression="CLIENTDISTRICT" />
                                <asp:BoundField DataField="CLIENTCITY" HeaderText="CITY" SortExpression="CLIENTCITY" />
                                <asp:BoundField DataField="CLIENTCONTACTNUMBER" HeaderText="CONTACT NUMBER" SortExpression="CLIENTCONTACTNUMBER" />
                                <asp:BoundField DataField="CLIENTEMAILADDRESS" HeaderText="EMAIL ADDRESS" SortExpression="CLIENTEMAILADDRESS" />
                            </Fields>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                        </asp:DetailsView>

                        

                        <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" Text="Login to view information" Visible="False"></asp:Label>

                        

                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Clients] WHERE ([CLIENTEMAILADDRESS] = @CLIENTEMAILADDRESS)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox1" Name="CLIENTEMAILADDRESS" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>



                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible =" false">
        <div class="row">
            <div class="col-md-8">
                <section id="updateClientInformation">
                    <div class="form-horizontal">
                        <h4>UPDATE CLIENT INFORMATION</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder2" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal2" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" AssociatedControlID="updateFN" CssClass="col-md-2 control-label">First Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateFN" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateFN"
                                CssClass="text-danger" ErrorMessage="The First Name field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" AssociatedControlID="updateFN" CssClass="col-md-2 control-label">Last Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateLN" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateLN"
                                CssClass="text-danger" ErrorMessage="The Last Name field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" AssociatedControlID="updateCN" CssClass="col-md-2 control-label">Company Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateCN" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateCN"
                                CssClass="text-danger" ErrorMessage="The Company Name field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label11" runat="server" AssociatedControlID="updateA" CssClass="col-md-2 control-label">Address</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateA" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateA"
                                CssClass="text-danger" ErrorMessage="The Address field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label12" runat="server" AssociatedControlID="updateD" CssClass="col-md-2 control-label">District</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateD" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateD"
                                CssClass="text-danger" ErrorMessage="The District field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label13" runat="server" AssociatedControlID="updateC" CssClass="col-md-2 control-label">City</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateC" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateC"
                                CssClass="text-danger" ErrorMessage="The City field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label14" runat="server" AssociatedControlID="updateN" CssClass="col-md-2 control-label">Contact Number</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="updateN" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="updateN"
                                CssClass="text-danger" ErrorMessage="The Contact Number field is required." ValidationGroup="ValidationGroup2"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button ID="Button2" runat="server" Text="UPDATE ACCOUNT INFORMATION" CssClass="btn btn-default" OnClick="Button2_Click" OnClientClick="return confirm('Are you sure you want to update your account ?')" ValidationGroup="ValidationGroup2" Width="273px"/>
                            </div>
                        </div>



                    </div>
                </section>
            </div>
        </div>

    </asp:Panel>
    <asp:Panel ID="Panel5" runat="server" Visible ="false">
        <div class="row">
            <div class="col-md-8">
                <section id="searchClients">
                    <div class="form-horizontal">
                        <h4>SEARCH FOR CLIENTS</h4>
                        <hr />
                        <div class="form-group">
                            <asp:Label ID="Label15" runat="server" AssociatedControlID="searchCli">Client ID/ Email Address/ First Name</asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="searchCli" runat="server"></asp:TextBox>
                                &nbsp;<asp:RequiredFieldValidator runat="server" ControlToValidate="searchCli"
                                CssClass="text-danger" ErrorMessage="First Name or Email Address is required." ValidationGroup="ValidationGroup3"/>
                                      
                            </div>
                            <hr />
                            <div>
                                <asp:Button ID="Button3" runat="server" CssClass="btn btn-default" Text="SEARCH CLIENT" OnClick="Button3_Click" ValidationGroup="ValidationGroup3"/>

                            </div>
                        </div>
                        <br />
                        <div>
                        <asp:DetailsView ID="DetailsView2" runat="server" Height="134px" Width="445px" AutoGenerateRows="False" DataKeyNames="CLIENT_ID" DataSourceID="SqlDataSource3" BackColor="#CCCCCC" BorderColor="#999999" BorderWidth="3px" CellPadding="4" ForeColor="Black" Visible="False" BorderStyle="Solid" CellSpacing="2" OnPageIndexChanging="DetailsView2_PageIndexChanging">
                            <EditRowStyle BackColor="#000099" ForeColor="White" Font-Bold="True" />
                            <Fields>
                                <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" ReadOnly="True" SortExpression="CLIENT_ID" />
                                <asp:BoundField DataField="CLIENTFNAME" HeaderText="FULL NAME" SortExpression="CLIENTFNAME" />
                                <asp:BoundField DataField="CLIENTLNAME" HeaderText="LAST NAME" SortExpression="CLIENTLNAME" />
                                <asp:BoundField DataField="CLIENTCOMPANYNAME" HeaderText="COMPANY NAME" SortExpression="CLIENTCOMPANYNAME" />
                                <asp:BoundField DataField="CLIENTADDRESS" HeaderText="ADDRESS" SortExpression="CLIENTADDRESS" />
                                <asp:BoundField DataField="CLIENTDISTRICT" HeaderText="DISTRICT" SortExpression="CLIENTDISTRICT" />
                                <asp:BoundField DataField="CLIENTCITY" HeaderText="CITY" SortExpression="CLIENTCITY" />
                                <asp:BoundField DataField="CLIENTCONTACTNUMBER" HeaderText="CONTACT NUMBER" SortExpression="CLIENTCONTACTNUMBER" />
                                <asp:BoundField DataField="CLIENTEMAILADDRESS" HeaderText="EMAIL ADDRESS" SortExpression="CLIENTEMAILADDRESS" />
                            </Fields>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                        </asp:DetailsView>


                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Clients] WHERE (([CLIENTFNAME] = @CLIENTFNAME) OR ([CLIENTEMAILADDRESS] = @CLIENTEMAILADDRESS) OR ([CLIENT_ID] = @CLIENT_ID))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="searchCli" Name="CLIENTFNAME" PropertyName="Text" Type="String" />
                                <asp:ControlParameter ControlID="searchCli" Name="CLIENTEMAILADDRESS" PropertyName="Text" Type="String" />
                                <asp:ControlParameter ControlID="searchCli" Name="CLIENT_ID" PropertyName="Text" Type="String"/>
                            </SelectParameters>
                        </asp:SqlDataSource>
                        </div>

                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>

</asp:Content>
