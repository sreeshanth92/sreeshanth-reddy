<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="get.aspx.cs" Inherits="WebApplication7.get" %>

<asp:Content ID ="myget" ContentPlaceHolderID ="MainContent" runat="server">
    <asp:Label ID ="label1" Text ="Id" runat="server"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>