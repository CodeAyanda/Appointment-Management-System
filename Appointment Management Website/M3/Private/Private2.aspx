<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Private2.aspx.cs" Inherits="M3.Private.Private2" MaintainScrollPositionOnPostback="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Appointments</h3>
    <hr />
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large">CREATE APPOINTMENT</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Size="Large">VIEW APPOINTMENTS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Font-Size="Large">UPDATE APPOINTMENT DETAILS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Font-Size="Large">CANCEL APPOINTMENTS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" Font-Size="Large">APPOINTMENT SCHEDULE</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton6" runat="server" Font-Size="Large" OnClick="LinkButton6_Click">APPOINTMENT HISTORY</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton7" runat="server" Font-Size="Large" OnClick="LinkButton7_Click">FINALISE APPOINTMENT</asp:LinkButton>
    </div>
    <hr />

    <asp:Panel ID="Panel1" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="createAppointment">
                    <div class="form-horizontal">
                        <h4>CREATE NEW APPOINTMENT</h4>
                        <hr />
                        <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false">
                            <p class="text-danger">
                                <asp:Literal runat="server" ID="Literal1" />
                            </p>
                        </asp:PlaceHolder>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="PestController" CssClass="col-md-2 control-label">Pest Controller</asp:Label>
                            <div class="col-md-10">
                                <asp:DropDownList ID="PestController" CssClass="form-control" runat="server" OnSelectedIndexChanged="PestController_SelectedIndexChanged" AutoPostBack="True">
                                    <asp:ListItem Value="Select Pest Controller"></asp:ListItem>
                                    <asp:ListItem Value="AK004"></asp:ListItem>
                                    <asp:ListItem Value="RS003"></asp:ListItem>
                                    <asp:ListItem Value="JK001"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PestController"
                                CssClass="text-danger" ErrorMessage="The Pest Controller field is required." ValidationGroup="ValidationGroup1" InitialValue="Select Pest Controller"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" AssociatedControlID="Date" CssClass="col-md-2 control-label">Date</asp:Label>
                            <div class="col-md-10">
                                <asp:Calendar ID="Date" runat="server" OnSelectionChanged="Selection_Changed" SelectedDate="" ForeColor="Black"></asp:Calendar>
                                &nbsp;<asp:CustomValidator ID="dateCustVal" OnServerValidate="DateCustVal_Validate" runat="server" Visible="False"></asp:CustomValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="TimeSlot" CssClass="col-md-2 control-label">Time Slot</asp:Label>
                            <div class="col-md-10">
                                <asp:DropDownList ID="TimeSlot" CssClass="form-control" runat="server" OnSelectedIndexChanged="TimeSlot_SelectedIndexChanged">
                                        <asp:ListItem Value="Select time slot"></asp:ListItem>
                                        <asp:ListItem Text ="9h00 - 10h00" Value="9h00 - 10h00"></asp:ListItem>
                                        <asp:ListItem Text ="10h00 - 11h00" Value ="10h00 - 11h00"></asp:ListItem>
                                        <asp:ListItem Text ="11h00 - 12h00" Value ="11h00 - 12h00"></asp:ListItem>
                                        <asp:ListItem Text ="12h00 - 13h00" Value ="12h00 - 13h00"></asp:ListItem>
                                        <asp:ListItem Text ="13h00 - 14h00" Value ="13h00 - 14h00"></asp:ListItem>
                                        <asp:ListItem Text ="14h00 - 15h00" Value ="14h00 - 15h00"></asp:ListItem>
                                        <asp:ListItem Text ="15h00 - 16h00" Value ="15h00 - 16h00"></asp:ListItem>
                                    </asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="TimeSlot"
                                CssClass="text-danger" ErrorMessage="The Time Slot field is required." ValidationGroup="ValidationGroup1" InitialValue="Select time slot"/>

                                
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" AssociatedControlID="PaymentMethod" CssClass="col-md-2 control-label">Payment Method</asp:Label>
                            <div class="col-md-10">
                                <asp:DropDownList ID="PaymentMethod" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="Select payment method"></asp:ListItem>
                                    <asp:ListItem Value="EFT"></asp:ListItem>
                                    <asp:ListItem Value="Cash"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="PaymentMethod"
                                CssClass="text-danger" ErrorMessage="The Payment Method field is required." ValidationGroup="ValidationGroup1" InitialValue="Select payment method"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:Button ID="Button1" CssClass="btn btn-default" runat="server" Text="CREATE APPOINTMENT" ValidationGroup="ValidationGroup1" OnClick="Button1_Click" OnClientClick="return confirm('Are You Sure You Want To Create A New Appointment ?');" Width="216px"/>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="viewAppointents">
                    <div class="form-horizontal">
                        <h4>VIEW APPOINTMENTS</h4>
                        <hr />
                        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource3" ForeColor="Black" Visible="False" Width="904px" Height="157px" HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                            <Columns>
                                <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" SortExpression="APPOINTMENT_ID" ReadOnly="True" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" >
                                <HeaderStyle HorizontalAlign="Center" BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT" >
                                <HeaderStyle HorizontalAlign="Center" BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER" >
                                <HeaderStyle HorizontalAlign="Center" BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" >
                                <HeaderStyle HorizontalAlign="Center" BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD" >
                                <HeaderStyle HorizontalAlign="Center" BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" Text="Nothing at the moment..." Visible="False"></asp:Label>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([CLIENT_ID] = @CLIENT_ID)) AND STATUS ='Active'">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox1" Name="CLIENT_ID" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="updateAppointent">
                    <div class="form-horizontal">
                        <h4>UPDATE APPOINTMENTS</h4>
                        <hr />
                        <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
                        <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource2" ForeColor="Black" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Height="191px" Width="1097px">
                            <Columns>
                                <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT_ID" SortExpression="CLIENT_ID" Visible="false"/>
                                <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" SortExpression="APPOINTMENT_ID" ReadOnly="True" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER" >
                                
                                <HeaderStyle BackColor="#204C74" />
                                
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                
                                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" Text="UPDATE APPOINTMENT" CommandName="btnClick" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"/>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" Text="Nothing at the moment..." Visible="False"></asp:Label>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([CLIENT_ID] = @CLIENT_ID) AND ([STATUS] = @STATUS))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox2" Name="CLIENT_ID" PropertyName="Text" Type="String" />
                                <asp:Parameter DefaultValue="Active" Name="STATUS" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([CLIENT_ID] = @CLIENT_ID) AND ([STATUS] = @STATUS))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox2" Name="CLIENT_ID" PropertyName="Text" Type="String" />
                                <asp:Parameter DefaultValue="Active" Name="STATUS" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                        <asp:Panel ID="Panel4" runat="server" Visible="false">
                            <hr />
                            <asp:PlaceHolder runat="server" ID="PlaceHolder2" Visible="false">
                                <p class="text-danger">
                                    <asp:Literal runat="server" ID="Literal2" />
                                </p>
                            </asp:PlaceHolder>
                            <div>
                                <asp:Label ID="Label6" runat="server" Text="Pest Controller"></asp:Label>
                                <div>
                                    <asp:DropDownList ID="updatePC" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="updatePC_SelectedIndexChanged">
                                        <asp:ListItem Value="Select Pest Controller"></asp:ListItem>
                                        <asp:ListItem Value="AK004"></asp:ListItem>
                                        <asp:ListItem Value="RS003"></asp:ListItem>
                                        <asp:ListItem Value="JK001"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePC"
                                    CssClass="text-danger" ErrorMessage="The Pest Controller field is required." ValidationGroup="ValidationGroup3" InitialValue="Select Pest Controller"/>
                                </div>
                            </div>
                            <div>
                                <asp:Label ID="Label5" runat="server" Text="Date"></asp:Label>
                                <div>
                                    <asp:Calendar ID="updateDate" runat="server" OnSelectionChanged="updateDate_SelectionChanged" ForeColor="Black"></asp:Calendar>
                                    <asp:CustomValidator ID="CustomValidator1" OnServerValidate="DateCustVal_Validate" runat="server" Visible="False"></asp:CustomValidator>
                                </div>
                            </div>
                            <div>
                                <asp:Label ID="Label7" runat="server" Text="Time Slot"></asp:Label>
                                <div>
                                    <asp:DropDownList ID="updateTS" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="Select time slot"></asp:ListItem>
                                        <asp:ListItem>9h00 - 10h00</asp:ListItem>
                                        <asp:ListItem>10h00 - 11h00</asp:ListItem>
                                        <asp:ListItem>11h00 - 12h00</asp:ListItem>
                                        <asp:ListItem>12h00 - 13h00</asp:ListItem>
                                        <asp:ListItem>13h00 - 14h00</asp:ListItem>
                                        <asp:ListItem>14h00 - 15h00</asp:ListItem>
                                        <asp:ListItem>15h00 - 16h00</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updateTS"
                                    CssClass="text-danger" ErrorMessage="The Time Slot field is required." ValidationGroup="ValidationGroup3" InitialValue="Select time slot"/>
                                </div>
                            </div>
                            <div>
                                <asp:Label ID="Label8" runat="server" Text="Payment Method"></asp:Label>
                                <div>
                                    <asp:DropDownList ID="updatePM" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="Select payment method"></asp:ListItem>
                                        <asp:ListItem Value="EFT"></asp:ListItem>
                                        <asp:ListItem Value="Cash"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="updatePM"
                                    CssClass="text-danger" ErrorMessage="The Payment Method field is required." ValidationGroup="ValidationGroup3" InitialValue="Select payment method"/>
                                    <asp:TextBox ID="TextBox3" runat="server" InitialValue="" Visible="False"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="updateApp" CssClass="btn btn-default" runat="server" Text="UPDATE APPOINTMENT" ValidationGroup="ValidationGroup3" OnClick="updateApp_Click" OnClientClick="return confirm('Are You Sure You Want To Update Your Appointment ?');" Width="235px"/>
                            </div>
                        </asp:Panel>
                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel5" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="cancelAppointent">
                    <div class="form-horizontal">
                        <h4>CANCEL APPOINTMENTS</h4>
                        <hr />
                        <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
                        <asp:GridView ID="GridView3" runat="server" OnRowCommand="GridView3_RowCommand" AutoGenerateColumns="False" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource4" Visible="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="180px" Width="1052px">
                            <Columns>
                                <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" SortExpression="APPOINTMENT_ID" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button runat="server" CommandName="btn2Clickk" OnClientClick="return confirm('Are You Sure You Want To Delete Your Appointment ? This Cannot Be Undone')" Text="DELETE APPOINTMENT" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"/>
                                    </ItemTemplate>
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>




                        <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" Text="Nothing at the moment..." Visible="False"></asp:Label>




                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([CLIENT_ID] = @CLIENT_ID) AND ([STATUS] = @STATUS))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox4" Name="CLIENT_ID" PropertyName="Text" Type="String" />
                                <asp:Parameter DefaultValue="Active" Name="STATUS" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>




                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel6" runat="server" Visible="false">
        <div class="row">
            <div class="col-md-8">
                <section id="appointentSchedule">
                    <div class="form-horizontal">
                        <h4>APPOINTMENT SCHEDULE</h4>
                        <hr />
                        <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="Choose Schedule"></asp:ListItem>
                            <asp:ListItem>Active</asp:ListItem>
                            <asp:ListItem>Completed</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <div>
                            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged1" Text="All" AutoPostBack="True" />
                            &nbsp;
                            <asp:RadioButton ID="RadioButton5" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton5_CheckedChanged" Text="Today" />
                            &nbsp;
                            <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged1" Text="Filter By Date" AutoPostBack="True" />
                            &nbsp;</div>
                        <br />
                        <div>
                            <asp:Calendar ID="filterDate" runat="server" Visible="False"></asp:Calendar>
                        </div>
                        <hr />

                        <asp:GridView ID="GridView4" runat="server" Visible="False" AutoGenerateColumns="False" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource8" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="171px" Width="1022px">
                            <Columns>
                                <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" ReadOnly="True" SortExpression="APPOINTMENT_ID" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" SortExpression="CLIENT_ID" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([PEST_CONTROLLER] = @PEST_CONTROLLER) AND ([STATUS] = @STATUS))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox5" Name="PEST_CONTROLLER" PropertyName="Text" Type="String" />
                                <asp:ControlParameter ControlID="DropDownList1" Name="STATUS" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" Height="171px" Width="1022px" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource5" ForeColor="Black" OnSelectedIndexChanged="GridView5_SelectedIndexChanged" Visible="False">
                            <Columns>
                                <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" ReadOnly="True" SortExpression="APPOINTMENT_ID">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" SortExpression="CLIENT_ID" >
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD">
                                <HeaderStyle BackColor="#204C74" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([PEST_CONTROLLER] = @PEST_CONTROLLER) AND ([STATUS] = @STATUS) AND ([DATE] = @DATE))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TextBox5" Name="PEST_CONTROLLER" PropertyName="Text" Type="String" />
                                <asp:ControlParameter ControlID="DropDownList1" Name="STATUS" PropertyName="SelectedValue" Type="String" />
                                <asp:ControlParameter ControlID="filterDate" DbType="Date" Name="DATE" PropertyName="SelectedDate" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />
                        

                    </div>
                </section>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel7" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="ApptHistory">
                    <div class="form-horizontal">
                        <h4>APPOINTMENT HISTORY</h4>
                        <hr />
                        <div class="form-group">
                            <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
                            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource6" ForeColor="Black" Width="1085px" Height="179px">
                                <Columns>
                                    <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" ReadOnly="True" SortExpression="APPOINTMENT_ID">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PRICE" DataFormatString="R {0:N2}" HeaderText="PRICE" SortExpression="PRICE">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" Text="Nothing at the moment..." Visible="False"></asp:Label>

                            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([CLIENT_ID] = @CLIENT_ID) AND ([STATUS] = @STATUS))">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="TextBox6" Name="CLIENT_ID" PropertyName="Text" Type="String" />
                                    <asp:Parameter DefaultValue="Completed" Name="STATUS" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </div>
                    </div>
                </section>
            </div>
            
        </div>

    </asp:Panel>
    <asp:Panel ID="Panel8" runat="server" Visible="False">
        <div class="row">
            <div class="col-md-8">
                <section id="finaliseAppt">
                    <div class="form-horizontal">
                        <h4>FINALISE APPOINTMENT</h4>
                        <hr />
                        <div>
                            <asp:RadioButton ID="RadioButton3" runat="server" Text="All" AutoPostBack="True" OnCheckedChanged="RadioButton3_CheckedChanged" />
                            &nbsp;
                            <asp:RadioButton ID="RadioButton4" runat="server" Text="Filter By Date" AutoPostBack="True" OnCheckedChanged="RadioButton4_CheckedChanged" />
                            <asp:RadioButton ID="RadioButton6" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton6_CheckedChanged" Text="Today" />
                        </div>
                        <br />
                        <div>
                            <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:GridView ID="GridView7" OnRowCommand="GridView7_RowCommand" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource7" ForeColor="Black" Width="1230px" Height="270px" OnSelectedIndexChanged="GridView7_SelectedIndexChanged" Visible="False">
                                <Columns>
                                    <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" ReadOnly="True" SortExpression="APPOINTMENT_ID">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" SortExpression="CLIENT_ID">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" DataFormatString="R {0:N2}">
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Appt. Price">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                        <HeaderStyle BackColor="#204C74" />
                                        <ItemStyle Width="100px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="Button3" runat="server" Text="Update" CommandName="updatePriceClick" OnClientClick="return confirm('Are You Sure You Want To Update the price for this Appointment ?')" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"/>
                                        </ItemTemplate>
                                        <HeaderStyle BackColor="#204C74" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>





                            <asp:GridView ID="GridView8" OnRowCommand="GridView8_RowCommand" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="APPOINTMENT_ID" DataSourceID="SqlDataSource9" ForeColor="Black" Width="1230px" Height="270px" Visible="False">
                                <Columns>
                                    <asp:BoundField DataField="APPOINTMENT_ID" HeaderText="APPOINTMENT ID" ReadOnly="True" SortExpression="APPOINTMENT_ID" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="CLIENT_ID" HeaderText="CLIENT ID" SortExpression="CLIENT_ID" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TIMESLOT" HeaderText="TIMESLOT" SortExpression="TIMESLOT" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PEST_CONTROLLER" HeaderText="PEST CONTROLLER" SortExpression="PEST_CONTROLLER" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="PAYMENT METHOD" SortExpression="PAYMENT_METHOD" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" DataFormatString="R {0:N2}" >
                                    <HeaderStyle BackColor="#204C74" />
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Appt. Price">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                        <HeaderStyle BackColor="#204C74" />
                                        <ItemStyle Width="100px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="Button4" CommandName="updatePriceClick2" runat="server" Text="Update" OnClientClick="return confirm('Are You Sure You Want To Update the price for this Appointment ?')" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"/>
                                        </ItemTemplate>
                                        <HeaderStyle BackColor="#204C74" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        
                            <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE (([STATUS] = @STATUS) AND ([DATE] = @DATE))">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="Active" Name="STATUS" Type="String" />
                                    <asp:ControlParameter ControlID="Calendar1" DbType="Date" Name="DATE" PropertyName="SelectedDate" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        
                            <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:GroupWst15ConnectionString %>" SelectCommand="SELECT * FROM [Service_Appointment] WHERE ([STATUS] = @STATUS)">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="Active" Name="STATUS" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        
                        </div>
                    </div>
                </section>     
            </div>
        </div>
    </asp:Panel>
</asp:Content>
