<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPager.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmailSend.Default" %>
<%@ Register src="UserControl.ascx" tagname="UserControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserControl ID="UserControl1" runat="server" />
</asp:Content>
