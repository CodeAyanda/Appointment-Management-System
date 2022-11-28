<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Private4.aspx.cs" Inherits="M3.Private.Private4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Reports</h3>
    <hr />
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Size="Large">CUSTOMER REPORTS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Size="Large">PEST CONTROLLER REPORTS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Font-Size="Large">TIME SLOT REPORTS</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Font-Size="Large">PAYMENT METHOD REPORTS</asp:LinkButton>
    </div>
</asp:Content>
