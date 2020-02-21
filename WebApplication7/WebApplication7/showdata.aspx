<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showdata.aspx.cs" Inherits="WebApplication7.showdata" %>

<asp:Content ID="details" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Table">
            <asp:GridView ID ="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        </div>
</asp:Content>
