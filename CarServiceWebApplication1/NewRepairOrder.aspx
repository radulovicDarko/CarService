<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewRepairOrder.aspx.cs" Inherits="CarServiceWebApplication1.NewRepairOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelRepairOrder" runat="server" Text="RepairOrder" Font-Size="20pt"></asp:Label>
    </td>
<td style="width: 211px">
    &nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 19px;"></td>
<td style="width: 166px; height: 19px;"></td>
<td style="width: 211px; height: 19px;"></td>
<td style="height: 19px"></td>
<td style="height: 19px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelOwner" runat="server" Text="Owner" Font-Size="15pt"></asp:Label>
    </td>
<td style="width: 211px">
<asp:DropDownList ID="DropDownListOwner" runat="server" Height="31px" style="margin-top: 0" Width="195px">
</asp:DropDownList>
</td>
<td>
<asp:Button ID="ButtonAddOwner" runat="server" Height="34px" Text="Add owner" />
</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 38px;"></td>
<td style="width: 166px; height: 38px;">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Vehicle info"></asp:Label>
    </td>
<td style="width: 211px; height: 38px;"></td>
<td style="height: 38px"></td>
<td style="height: 38px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelChassisNumber" runat="server" Text="ChassisNumber"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxChassisNumber" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>
    <asp:Label ID="LabelChassisNumberRegex" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 166px; height: 6px;"></td>
<td style="width: 211px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelBrand" runat="server" Text="Brand"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxBrand" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 166px; height: 6px;"></td>
<td style="width: 211px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelType" runat="server" Text="Type"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxType" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 166px; height: 6px;"></td>
<td style="width: 211px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelYearOfManufacture" runat="server" Text="Year of manufacture"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxYearOfManufacture" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 166px; height: 6px;"></td>
<td style="width: 211px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelLicencePlate" runat="server" Text="Licence plate"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxLicencePlate" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>
    <asp:Label ID="LabelLicencePlateRegex" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelMalfunctionDescription" runat="server" Text="Malfunction description"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxMalfunctionDescription" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 166px; height: 6px;"></td>
<td style="width: 211px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">
<asp:Label ID="LabelRepairPrice" runat="server" Text="Repair price"></asp:Label>
</td>
<td style="width: 211px">
<asp:TextBox ID="TextBoxRepairPrice" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td rowspan="2" style="width: 166px">
<asp:Button ID="ButtonClose" runat="server" Height="36px" style="margin-top: 0" Text="Close" Width="127px" />
</td>
<td style="width: 211px" rowspan="2">
<asp:Button ID="ButtonCreateNewRepairOrder" runat="server" Height="36px" Text="Create new repair order" Width="179px" />
    </td>
<td rowspan="2">
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 36px;">&nbsp;</td>
<td style="height: 36px">&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 166px">&nbsp;</td>
<td style="width: 211px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</table>
</asp:Content>
