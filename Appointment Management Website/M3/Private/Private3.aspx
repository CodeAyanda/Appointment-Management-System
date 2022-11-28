<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Private3.aspx.cs" Inherits="M3.Private.Private3" MaintainScrollPositionOnPostback="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Pest Controllers</h3>
    <hr />
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large">ADD PEST CONTROLLER</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Size="Large">UPDATE PEST CONTROLLER DETAILS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Font-Size="Large">SEARCH / VIEW PEST CONTROLLER</asp:LinkButton>
    </div>
    <hr />

    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="createAppointment">
                    <div class="form-horizontal">
                        <h4>ADD NEW PEST CONTROLLER</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal1" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label11" CssClass="col-md-2 control-label" runat="server" Text="Pest Controller ID"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="PCid" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PCid"
                                CssClass="text-danger" ErrorMessage="The Pest Controller ID is required." ValidationGroup="ValidationGroup1"/>
                            </div>

                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label1" CssClass="col-md-2 control-label" runat="server" Text="Name"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="PCName" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PCName"
                                CssClass="text-danger" ErrorMessage="The Pest Controller Name is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" CssClass="col-md-2 control-label" runat="server" Text="Surname"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="PCSurname" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PCSurname"
                                CssClass="text-danger" ErrorMessage="The Pest Controller Surname is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" CssClass="col-md-2 control-label" runat="server" Text="Phone Number"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="PCPhone" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PCPhone"
                                CssClass="text-danger" ErrorMessage="The Pest Controller Number is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label4" CssClass="col-md-2 control-label" runat="server" Text="Email"></asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox ID="PCEmail" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PCEmail"
                                CssClass="text-danger" ErrorMessage="The Pest Controller Email is required." ValidationGroup="ValidationGroup1"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button ID="AddPC" CssClass="btn btn-default" runat="server" Text="ADD PEST CONTROLLER" OnClick="AddPC_Click" ValidationGroup="ValidationGroup1" OnClientClick="return confirm('Are You Sure You Want To Add New Pest Controller ?')" Width="227px"/>
                                &nbsp;<asp:Button ID="Button1" CssClass="btn btn-default" runat="server" Text="Clear" OnClick="Button1_Click"/>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="UpdatePC">
                    <div class="form-horizontal">
                        <h4>UPDATE PEST CONTROLLER DETAILS</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder2" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal2" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label5" CssClass="col-md-2 control-label" runat="server" Text="Select Pest Controller"></asp:Label>
                            <div class="col-md-10">
                                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                                    <asp:ListItem Value="Select Pest Controller"></asp:ListItem>
                                    <asp:ListItem Value="AK004"></asp:ListItem>
                                    <asp:ListItem Value="RS003"></asp:ListItem>
                                    <asp:ListItem Value="JK001"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <asp:Panel ID="Panel3" runat="server" Visible="false">
                            <div class="form-group">
                                <asp:Label ID="Label12" CssClass="col-md-2 control-label" runat="server" Text="Pest Controller ID"></asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="updatePCid" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePCid"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller ID is required." ValidationGroup="ValidationGroup2"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label6" CssClass="col-md-2 control-label" runat="server" Text="Name"></asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="updatePCN" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePCN"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller Name is required." ValidationGroup="ValidationGroup2"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label7" CssClass="col-md-2 control-label" runat="server" Text="Surname"></asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="updatePCS" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePCS"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller Surname is required." ValidationGroup="ValidationGroup2"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label8" CssClass="col-md-2 control-label" runat="server" Text="Phone Number"></asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="updatePCPN" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePCPN"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller Number is required." ValidationGroup="ValidationGroup2"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label9" CssClass="col-md-2 control-label" runat="server" Text="Email"></asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="updatePCE" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePCE"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller Email is required." ValidationGroup="ValidationGroup2"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <asp:Button ID="Button2" CssClass="btn btn-default" ValidationGroup="ValidationGroup2" runat="server" Text="UPDATE DETAILS" OnClick="Button2_Click" OnClientClick="return confirm('Are You Sure You Want To Update Pest Controller Information ?')"/>
                                </div>
                            </div>
                        </asp:Panel>
                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="viewPC">
                    <div class="form-horizontal">
                        <h4>VIEW CONTROLLER DETAILS</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder4" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal3" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label10" CssClass="col-md-2 control-label" runat="server" Text="Select Pest Controller"></asp:Label>
                            <div class="col-md-10">
                                <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                                    <asp:ListItem Value="Select Pest Controller"></asp:ListItem>
                                    <asp:ListItem Value="AK004"></asp:ListItem>
                                    <asp:ListItem Value="RS003"></asp:ListItem>
                                    <asp:ListItem Value="JK001"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            
                        </div>
                        <hr />
                        <asp:DetailsView ID="DetailsView1" runat="server" Height="76px" Width="439px" AutoGenerateRows="False" DataKeyNames="PEST_CONTROLLER_ID" DataSourceID="SqlDataSource1" Visible="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <Fields>
                                <asp:BoundField DataField="PEST_CONTROLLER_ID" HeaderText="PEST CONTROLLER ID" ReadOnly="True" SortExpression="PEST_CONTROLLER_ID" />
                                <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                                <asp:BoundField DataField="SURNAME" HeaderText="SURNAME" SortExpression="SURNAME" />
                                <asp:BoundField DataField="PHONE_NUMBER" HeaderText="PHONE NUMBER" SortExpression="PHONE_NUMBER" />
                                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                                <asp:BoundField DataField="PEST_CONTROLLER_AVAILABILITY" HeaderText="PEST CONTROLLER AVAILABILITY" SortExpression="PEST_CONTROLLER_AVAILABILITY" />
                            </Fields>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                        </asp:DetailsView>





                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Pest_Controller] WHERE ([PEST_CONTROLLER_ID] = @PEST_CONTROLLER_ID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList2" Name="PEST_CONTROLLER_ID" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>





                    </div>
                </section>
             </div>
        </div>








    </asp:Panel>
</asp:Content>
