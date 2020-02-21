<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplication7.update" %>

<asp:Content ID = "myupdate" ContentPlaceHolderID = "MainContent" runat="server">
<asp:Label ID = "label1" Text ="Id" runat="server"></asp:Label>
    <asp:TextBox ID ="TextBox1" runat="server" Text=""></asp:TextBox>
    <asp:TextBox ID ="label2" Text="Location" runat="server"></asp:TextBox>
    <asp:TextBox ID = "TextBox2" runat="server" Text=""></asp:TextBox>
    <asp:Button ID  ="button1" runat ="server" Text =" Updatedata" OnClick = "button1_Click" />
    <asp:GridView ID ="GridView1" runat="server"></asp:GridView>
</asp:Content>


