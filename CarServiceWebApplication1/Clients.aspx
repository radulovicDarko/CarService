<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs" Inherits="CarServiceWebApplication.Clients" %>
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
        <td colspan="2" style="height: 20px">
            <asp:Label ID="Label3" runat="server" Font-Size="20pt" Text="Existing clients"></asp:Label>
        </td>
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
            <asp:ListBox ID="ListBoxClients" runat="server" Height="320px" style="margin-left: 20pt; overflow-x:auto;" Width="400px" SelectionMode="Multiple"></asp:ListBox>
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
            &nbsp;</td>
        <td style="height: 20px; width: 164px">
            <asp:Button ID="ButtonNewClient" runat="server" style="margin-left: 0px" Text="New client" Width="157px" Height="27px" />
        </td>
        <td colspan="2" style="height: 20px">
            <asp:Button ID="ButtonUpdateClientsInfo" runat="server" Height="27px" style="margin-left: 0" Text="Update client's info" Width="155px" />
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
            <asp:Button ID="ButtonDeleteClient" runat="server" Text="Delete client" Width="157px" Height="27px" />
        </td>
        <td colspan="2" style="height: 20px">
            <asp:Button ID="ButtonClientsVehicles" runat="server" Text="Show clients vehicles" Width="157px" Height="27px" />
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
    </table>
</asp:Content>
