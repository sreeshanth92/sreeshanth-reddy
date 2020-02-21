<%@ Page Language="C#" MasterPageFile ="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<asp:Content ID="id122" ContentPlaceHolderID ="MainContent" runat="server">
<div class ="sarcastic">
<asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
<br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
<br />
<asp:Calendar ID="calender1" runat="server" OnSelectionChanged="calender1_SelectionChanged"></asp:Calendar>
<br />
<asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>male</asp:ListItem>
    <asp:ListItem>female</asp:ListItem>
    </asp:RadioButtonList>
<br />
<asp:Label ID="Label4" runat="server" Text="mark hobbies"></asp:Label>
<br />
<asp:CheckBoxList ID="CheckBoxList1" runat="server">
    <asp:ListItem>Badminton</asp:ListItem>
    <asp:ListItem>Singing</asp:ListItem>
    <asp:ListItem>snookers</asp:ListItem>
    <asp:ListItem>football</asp:ListItem>
    </asp:CheckBoxList>
<br />
<asp:Label ID ="label5" runat ="server" Text ="Education"></asp:Label>
<br />
<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
<br />
<asp:Button ID ="btn1" Text ="submit" runat ="server" OnClick="btn1_Click" />


</div>
<div class ="sarcastic">

</div>
</asp:Content>

