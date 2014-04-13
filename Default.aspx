<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Welcome to the CVTC College Clubs web site!
    <br />
    <br />
    Press this button to Login: 
    &nbsp;
    <asp:Button ID="btnLogin" runat="server" Text="Login" />

    <br />
    <br />
    You current status is: 
    &nbsp;
    <asp:Label ID="lblLogin" runat="server"></asp:Label>
    
</asp:Content>

