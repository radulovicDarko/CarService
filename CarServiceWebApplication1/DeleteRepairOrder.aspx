<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteRepairOrder.aspx.cs" Inherits="CarServiceWebApplication1.DeleteRepairOrder" %>
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
<asp:Label ID="Label1" runat="server" Text="Active car inspections" Font-Size="20pt"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 159px">&nbsp;</td>
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
    <asp:ListBox ID="ListBoxActive" runat="server" Height="457px" style="margin-left: 0; overflow-x:auto;" Width="364px"></asp:ListBox>
</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="height: 4px"></td>
<td style="width: 118px; height: 4px;"></td>
<td style="width: 11px; height: 4px;"></td>
<td style="width: 15px; height: 4px;"></td>
<td colspan="4" style="height: 4px"></td>
<td style="height: 4px"></td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td style="width: 159px">
<asp:Label ID="Label2" runat="server" Text="Car Inspection ID"></asp:Label>
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
<td style="width: 159px">
<asp:TextBox ID="TextBoxCarInspectionsID" runat="server" Height="26px" Width="116px"></asp:TextBox>
</td>
<td colspan="2">
<asp:Button ID="ButtonDeleteInfo" runat="server" Height="30px" Text="DELETE INFO" Width="119px" />
    </td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="height: 11px"></td>
<td style="width: 118px; height: 11px;"></td>
<td style="width: 11px; height: 11px;"></td>
<td style="width: 15px; height: 11px;"></td>
<td style="width: 159px; height: 11px;"></td>
<td style="width: 13px; height: 11px;"></td>
<td style="width: 176px; height: 11px;"></td>
<td style="width: 278px; height: 11px;"></td>
<td style="height: 11px"></td>
</tr>
<tr>
<td>&nbsp;</td>
<td style="width: 118px">&nbsp;</td>
<td style="width: 11px">&nbsp;</td>
<td style="width: 15px">&nbsp;</td>
<td colspan="4">
    <asp:Button ID="ButtonClose" runat="server" Height="30px" Text="CLOSE" Width="280px" />
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
