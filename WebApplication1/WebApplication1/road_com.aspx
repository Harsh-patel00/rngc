<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="road_com.aspx.cs" Inherits="Road_Garbage_Complain_System.road_com" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">
   

   
    
     <asp:Label ID="Label1" runat="server" Text="City :"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    

     <br />
     <asp:Label ID="Label5" runat="server" Text="Id :"></asp:Label>
     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
     <br />
    

     <asp:Label ID="Label2" runat="server" Text="City :"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>

     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

     <asp:Label ID="Label4" runat="server" Text="Your Complain :"></asp:Label>
     <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
     <br />

    <asp:FileUpload ID="FileUpload1" runat="server" />

    <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />

     

    
     <br />

     

    
</asp:Content>
