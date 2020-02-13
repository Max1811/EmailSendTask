<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPager.Master" AutoEventWireup="true" CodeBehind="SuccessfulSendPage.aspx.cs" Inherits="EmailSend.PohPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="SuccessfulResponce" runat="server" Text="Label"></asp:Label>
<br />
<asp:Button ID="GoBackButton" runat="server" CssClass="button" OnClick="BackButtonClick" />
</asp:Content>
