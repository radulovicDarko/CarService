<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="CarServiceWebApplication1.AddClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <table class="nav-justified">
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">&nbsp;</td>
<td style="width: 129px" colspan="2">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td colspan="3">
<asp:Label ID="LabelAddClientsInfo" runat="server" Text="Add client's info" Font-Size="20pt"></asp:Label>
    </td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 9px;"></td>
<td style="width: 120px; height: 9px;"></td>
<td style="width: 129px; height: 9px;" colspan="2"></td>
<td style="height: 9px"></td>
<td style="height: 9px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">&nbsp;</td>
<td style="width: 36px">&nbsp;</td>
<td style="width: 129px">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelChassisNumber" runat="server" Text="Name" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:TextBox ID="TextBoxName" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 120px; height: 6px;"></td>
<td style="width: 36px; height: 6px;"></td>
<td style="width: 129px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelBrand" runat="server" Text="Surname" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:TextBox ID="TextBoxSurname" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 120px; height: 6px;"></td>
<td style="width: 36px; height: 6px;"></td>
<td style="width: 129px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelType" runat="server" Text="Gender" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:DropDownList ID="DropDownListGender" runat="server" Height="25px">
<asp:ListItem>Male</asp:ListItem>
<asp:ListItem>Female</asp:ListItem>
</asp:DropDownList>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 120px; height: 6px;"></td>
<td style="width: 36px; height: 6px;"></td>
<td style="width: 129px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelYearOfManufacture" runat="server" Text="Address" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:TextBox ID="TextBoxAddress" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 120px; height: 6px;"></td>
<td style="width: 36px; height: 6px;"></td>
<td style="width: 129px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelLicencePlate" runat="server" Text="Phone number" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:TextBox ID="TextBoxPhoneNumber" runat="server" Width="183px" Height="26px"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px; height: 6px;"></td>
<td style="width: 120px; height: 6px;"></td>
<td style="width: 36px; height: 6px;"></td>
<td style="width: 129px; height: 6px;"></td>
<td style="height: 6px"></td>
<td style="height: 6px"></td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">
<asp:Label ID="LabelMalfunctionDescription" runat="server" Text="E-mail" Font-Size="12pt"></asp:Label>
</td>
<td style="width: 36px">
    &nbsp;</td>
<td style="width: 129px">
<asp:TextBox ID="TextBoxEmail" runat="server" Width="183px" Height="26px" style="margin-top: 0"></asp:TextBox>
</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">&nbsp;</td>
<td style="width: 36px">&nbsp;</td>
<td style="width: 129px">
    <asp:Label ID="LabelEmailRegex" runat="server" BackColor="White" ForeColor="#FF3300"></asp:Label>
    </td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td rowspan="2" style="width: 120px">
<asp:Button ID="ButtonClose" runat="server" Height="36px" style="margin-top: 0" Text="Close" Width="127px" />
</td>
<td style="width: 36px">&nbsp;</td>
<td style="width: 129px" rowspan="2">
<asp:Button ID="ButtonAddClient" runat="server" Height="36px" Text="Add client" Width="127px" />
    </td>
<td rowspan="2">
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 36px">&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td style="width: 387px">&nbsp;</td>
<td style="width: 120px">&nbsp;</td>
<td style="width: 129px" colspan="2">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</table>
</asp:Content>
