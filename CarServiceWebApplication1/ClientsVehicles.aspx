<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientsVehicles.aspx.cs" Inherits="CarServiceWebApplication1.ClientsVehicles" %>
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
<td colspan="4">
<asp:Label ID="LabelClients" runat="server" Text="Client's vehicles" Font-Size="20pt"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 137px">&nbsp;</td>
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
<asp:ListBox ID="ListBoxClientsVehicles" runat="server" Height="396px" style="margin-left: 0; overflow-x:auto;" Width="412px"></asp:ListBox>
</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="height: 9px"></td>
<td style="width: 118px; height: 9px;"></td>
<td style="width: 11px; height: 9px;"></td>
<td style="width: 15px; height: 9px;"></td>
<td colspan="4" style="height: 9px"></td>
<td style="height: 9px"></td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 137px">
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
<td style="width: 137px">
    <asp:DropDownList ID="DropDownListClients" runat="server" Height="26px" Width="136px">
    </asp:DropDownList>
</td>
<td style="width: 13px">&nbsp;</td>
<td>
<asp:Button ID="ButtonShowVehicles" runat="server" Height="30px" Text="SHOW VEHICLES" Width="130px" />
</td>
<td>
&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="height: 9px"></td>
<td style="width: 118px; height: 9px;"></td>
<td style="width: 11px; height: 9px;"></td>
<td style="width: 15px; height: 9px;"></td>
<td style="width: 137px; height: 9px;"></td>
<td style="width: 13px; height: 9px;"></td>
<td style="width: 176px; height: 9px;"></td>
<td style="width: 278px; height: 9px;"></td>
<td style="height: 9px"></td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">
    <asp:Button ID="ButtonClose" runat="server" Height="30px" Text="CLOSE" Width="342px" />
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
