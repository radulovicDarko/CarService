<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRepairOrder.aspx.cs" Inherits="CarServiceWebApplication1.AddOwner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px; width: 340px"></td>
            <td style="height: 20px; width: 123px"></td>
            <td colspan="4" style="height: 20px">
                <asp:Label ID="Label1" runat="server" Font-Size="20pt" Text="Repair order"></asp:Label>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 26px"></td>
            <td class="modal-sm" style="width: 123px; height: 26px">
                <asp:Label ID="Label2" runat="server" Text="Owner"></asp:Label>
            </td>
            <td colspan="2" style="height: 26px">
                <asp:DropDownList ID="DropDownListOwners" runat="server" Height="22px" Width="221px">
                </asp:DropDownList>
            </td>
            <td style="width: 245px; height: 26px">
                <asp:Button ID="ButtonAddOwner" runat="server" style="margin-left: 0" Text="Add Owner" />
            </td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 245px">&nbsp;</td>
            <td style="width: 123px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Vehicle info"></asp:Label>
&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 7px"></td>
            <td class="modal-sm" style="width: 123px; height: 7px"></td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 7px"></td>
            <td style="height: 7px"></td>
            <td style="height: 7px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Chassis number</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxChassisNumber" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Brand</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxBrand" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Type</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxType" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Yea of manufacture</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxYearOfManufacture" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Licence plate</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxLicencePlate" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px; height: 34px"></td>
            <td class="modal-sm" style="height: 34px; width: 123px">Malfunction description</td>
            <td class="modal-sm" colspan="3" style="width: 245px; height: 34px">
                <asp:TextBox ID="TextBoxDescription" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td style="height: 34px"></td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">Repair price</td>
            <td class="modal-sm" colspan="3" style="width: 245px">
                <asp:TextBox ID="TextBoxRepairPrice" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td style="width: 170px">
                <asp:Button ID="Button1" runat="server" Text="Button" Width="145px" />
            </td>
            <td class="modal-sm" colspan="2" style="width: 245px">
                <asp:Button ID="Button2" runat="server" style="margin-left: 0px" Text="Button" Width="145px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 340px">&nbsp;</td>
            <td class="modal-sm" style="width: 123px">&nbsp;</td>
            <td class="modal-sm" colspan="3" style="width: 245px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
