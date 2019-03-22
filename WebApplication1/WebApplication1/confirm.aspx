﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="Road_Garbage_Complain_System.confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="city">
                <Columns>
                    <asp:BoundField DataField="city" HeaderText="city" ReadOnly="True" SortExpression="city" />
                    <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                    <asp:BoundField DataField="complaint" HeaderText="complaint" SortExpression="complaint" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:constrng %>" SelectCommand="SELECT [city], [location], [complaint] FROM [Road]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="ID :"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="City :"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="location :"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="complaint :"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        </p>
    </form>
</body>
</html>
