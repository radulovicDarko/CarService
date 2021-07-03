<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarInspections.aspx.cs" Inherits="CarServiceWebApplication1.CarInspections" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
    <tr>
        <td class="modal-lg" style="height: 20px; width: 342px">
            &nbsp;</td>
        <td style="height: 20px; width: 164px">&nbsp;</td>
        <td style="height: 20px; width: 111px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="height: 20px; width: 342px">
            &nbsp;</td>
        <td style="height: 20px; width: 164px">&nbsp;</td>
        <td style="height: 20px; width: 111px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
        </td>
        <td colspan="2" style="height: 20px; font-size: 20pt;">
            Active repair orders</td>
        <td style="height: 20px; width: 435px;"></td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td colspan="2" style="height: 20px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td colspan="3" style="height: 20px">
            <asp:ListBox ID="ListBoxActiveCarInspections" runat="server" Height="320px" style="margin-left: 20pt; overflow-x:auto;" Width="400px" SelectionMode="Multiple"></asp:ListBox>
        </td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td colspan="2" style="height: 20px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td style="height: 20px; width: 164px">&nbsp;</td>
        <td style="height: 20px; width: 111px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
        </td>
        <td style="height: 20px; width: 164px">
            <asp:Button ID="ButtonNewRepairOrder" runat="server" style="margin-left: 0px" Text="New repair order" Width="157px" Height="27px" />
        </td>
        <td colspan="2" style="height: 20px">
            <asp:Button ID="ButtonUpdateRepairOrder" runat="server" Height="27px" style="margin-left: 0" Text="Update repair order" Width="155px" />
        </td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 17px">
        </td>
        <td style="height: 17px; width: 164px"></td>
        <td style="height: 17px"></td>
        <td style="height: 17px; width: 435px;"></td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td style="height: 20px; width: 164px">
            <asp:Button ID="ButtonDeleteRepairOrder" runat="server" Text="Delete repair order" Width="157px" Height="27px" />
        </td>
        <td colspan="2" style="height: 20px">
            <asp:Button ID="ButtonCarInspectionHistory" runat="server" Text="Car inspection history" Width="157px" Height="27px" />
        </td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            </td>
        <td colspan="2" style="height: 20px"></td>
        <td style="height: 20px; width: 435px;"></td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td colspan="2" style="height: 20px">
            &nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    <tr>
        <td class="modal-lg" style="width: 342px; height: 20px">
            &nbsp;</td>
        <td colspan="2" style="height: 20px">&nbsp;</td>
        <td style="height: 20px; width: 435px;">&nbsp;</td>
    </tr>
    </table>
</asp:Content>
