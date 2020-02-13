<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="EmailSend.UserControl" %>
<asp:Label ID="EmailLabelName" runat="server"></asp:Label>
<asp:Label ID="ResponceStatus" runat="server" Enabled="False" Visible="False" CssClass="responce-status"></asp:Label>
<br />
<asp:TextBox ID="EmailField" runat="server" CssClass="email-field" OnTextChanged="OnEmailChanged"></asp:TextBox>
<br />
<asp:Label ID="Description" runat="server" ></asp:Label>
<br />
<asp:TextBox ID="EmailBody" runat="server" OnTextChanged="OnDescriptionChanged" Rows="10" TextMode="MultiLine" CssClass="email-body"></asp:TextBox>
<br />
<br />
<asp:Button ID="Post" runat="server" OnClick="Button1_Click" CssClass="button" />

