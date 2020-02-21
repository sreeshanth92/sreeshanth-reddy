<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<asp:Content ID="myid" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must enter id" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">enter id</asp:RequiredFieldValidator><br />
    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
<br />
<asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
<br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must enter name" ControlToValidate="TextBox2" ForeColor="#6600FF" ValidationGroup="vg">Name</asp:RequiredFieldValidator><br />
<asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
<br />
<asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
<br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="must enter location" ControlToValidate="TextBox3" ForeColor="#99FF66" ValidationGroup="vg">enter Location</asp:RequiredFieldValidator><br />
<asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>
<br />
<asp:TextBox ID="TextBox3" runat="server" Text=""></asp:TextBox>
<br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="must enter  course" ControlToValidate="TextBox4" ForeColor="#666699" ValidationGroup="vg">enter course</asp:RequiredFieldValidator><br />
<asp:Label ID="Label4" runat="server" Text="Course"></asp:Label>
<br />
<asp:TextBox ID="TextBox4" runat="server" Text=""></asp:TextBox>
<br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg" />
<asp:Button ID="Button1" runat="server" Text="insertdata" OnClick="Button1_Click" ValidationGroup="vg" />
<asp:GridView ID="GridView1" runat="server"></asp:GridView>

</asp:Content>