<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateOwner.aspx.cs" Inherits="CarServiceWebApplication1.UpdateOwner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 144px">&nbsp;</td>
<td style="width: 13px">&nbsp;</td>
<td style="width: 176px">
<asp:Label ID="LabelClients" runat="server" Text="Clients"></asp:Label>
</td>
<td style="width: 278px">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 144px">&nbsp;</td>
<td style="width: 13px">&nbsp;</td>
<td style="width: 176px">&nbsp;</td>
<td style="width: 278px">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">
<asp:ListBox ID="ListBoxClients" runat="server" style="margin-left: 0; overflow-x:auto;" Height="396px" Width="412px"></asp:ListBox>
</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="height: 11px"></td>
<td style="width: 118px; height: 11px;"></td>
<td style="width: 11px; height: 11px;"></td>
<td style="width: 15px; height: 11px;"></td>
<td colspan="4" style="height: 11px"></td>
<td style="height: 11px"></td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 144px">
<asp:Label ID="Label2" runat="server" Text="Client ID"></asp:Label>
</td>
<td style="width: 13px">&nbsp;</td>
<td style="width: 176px">&nbsp;</td>
<td style="width: 278px">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 144px">
<asp:TextBox ID="TextBoxClientID" runat="server" Height="26px" Width="112px"></asp:TextBox>
</td>
<td style="width: 13px">&nbsp;</td>
<td>
<asp:Button ID="ButtonUpdateInfo" runat="server" Height="30px" Text="UPADATE INFO" Width="122px" />
</td>
<td>
&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 144px">&nbsp;</td>
<td style="width: 13px">&nbsp;</td>
<td style="width: 176px">&nbsp;</td>
<td style="width: 278px">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">
    <asp:Button ID="ButtonClose" runat="server" Height="30px" Text="CLOSE" Width="278px" />
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">&nbsp;</td>
<td>&nbsp;</td>
</tr>
</table>
</asp:Content>
