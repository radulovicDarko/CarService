<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateRepairOrder.aspx.cs" Inherits="CarServiceWebApplication1.UpdateRepairOrder" %>
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
<td style="width: 135px">&nbsp;</td>
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
    <asp:ListBox ID="ListBoxActiveCarInspections" runat="server" style="margin-left: 0; overflow-x:auto;" Height="396px" Width="450px"></asp:ListBox>
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
<td style="width: 135px">
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
<td style="width: 135px">
    <asp:TextBox ID="TextBoxID" runat="server" Height="26px" Width="125px"></asp:TextBox>
</td>
<td style="width: 13px">&nbsp;</td>
<td>
<asp:Button ID="ButtonUpdate" runat="server" Height="30px" Text="UPADATE INFO" Width="131px" OnClick="ButtonUpdate_Click1" />
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
<td style="width: 135px; height: 11px;"></td>
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
<asp:Button ID="ButtonCloseInspection" runat="server" Height="36px" style="margin-right: 0" Text="SET INSPECTION STATUS TO DONE" Width="331px" />
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
<td colspan="4">
    <asp:Button ID="ButtonClose" runat="server" Height="36px" Text="CLOSE" Width="330px" />
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
</table>

</asp:Content>
