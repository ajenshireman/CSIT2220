<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="dcaw.aspx.cs" Inherits="dcaw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Devil’s Courthouse Adventure Weekend</h2>
    <form id="form1">
        <div id="basePackage">
            <asp:Label ID="lblNumBase" runat="server" Text="Number of people:"></asp:Label>
            <asp:TextBox ID="numBase" runat="server"></asp:TextBox>
        </div>
        <div id="extra1">
            <asp:Label ID="Label1" runat="server" Text="Climbing Instruction:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>People
        </div>
        <div id="extra2">
            <asp:Label ID="Label2" runat="server" Text="Equipment Rental:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> People
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> Days
        </div>
        <div>
            <asp:Button ID="btnBook" runat="server" Text="Book" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</asp:Content>

