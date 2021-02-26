<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASPNETDatabinding2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    Search:<asp:TextBox ID="txtCriteria" runat="server"/> 
    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
    <asp:GridView ID="grvProducts" runat="server"  AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ShowHeader="true" />
            <asp:BoundField DataField="Name" HeaderText="Name" ShowHeader="true" />
            <asp:BoundField DataField="Description" HeaderText="Description" ShowHeader="true" />
        </Columns>
    </asp:GridView>
    
</asp:Content>
