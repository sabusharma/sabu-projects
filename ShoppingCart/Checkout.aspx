<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="text-align: right">
        <table style="width:100%;">
            <tr>
                <td>
                    <b>Billing Address</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td>
                    <b>Shipping Address</b></td>
            </tr>
            <tr>
                <td style="border-bottom-style:none;">
                    <asp:Panel ID="panelBillAddress" runat="server">
                        <br />
                        <asp:Label ID="lblBillName" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblBillAddress" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblBillCityStateZip" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblBillPhone" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:LinkButton ID="linkbtnEditBillAddress" runat="server" 
                            onclick="linkbtnEditBillAddress_Click">Edit Billing Address</asp:LinkButton>
                    </asp:Panel>
                </td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td>
                    <asp:Panel ID="panelShipAddress" runat="server">
                        <br />
                        <asp:Label ID="lblShipName" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblShipAddress" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblShipCityStateZip" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lblShipPhone" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:LinkButton ID="linkbtnEditShipAddress" runat="server" 
                            onclick="linkbtnEditShipAddress_Click">Edit</asp:LinkButton>
                    </asp:Panel></td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="checkboxSameShipAddress" runat="server" AutoPostBack="True" 
                        oncheckedchanged="checkboxSameShipAddress_CheckedChanged" 
                        Text="My Billing Address and Shiping Address are different" />
                </td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
           
            <tr>
                <td>
                    <asp:Panel ID="panelUpdateBillingAddress" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td style="width: 96px">
                                    Address</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtUpdateBillAddress" runat="server" Width="206px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    City</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtUpdateBillCity" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    State</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtUpdateBillState" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    Zip</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtUpdateBillZip" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    Phone</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtUpdateBillPhone" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnUpdateBillingAddress" runat="server" Text="Update" 
                                        onclick="btnUpdateBillingAddress_Click" />
                                    &nbsp;
                                    <asp:Button ID="btnBillingAddressUpdateCancel" runat="server" Text="Cancel" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td>
                    <asp:Panel ID="panelNewShippingAddress" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td style="width: 96px">
                                    Last Name</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipLastName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    First Name</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipFirstName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    Address</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipAddress" runat="server" Width="206px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    City</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipCity" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    State</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipState" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    Zip</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipZip" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    Phone</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtNewShipPhone" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96px">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="btnNewShippingAddress" runat="server" Text="Update" 
                                        onclick="btnNewShippingAddress_Click" />
                                    &nbsp;
                                    <asp:Button ID="btnShippingAddressUpdateCancel" runat="server" Text="Cancel" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
           
        </table>
        <asp:Button ID="btnContinueCheckout" runat="server" 
            onclick="btnContinueCheckout_Click" Text="Continue" />
        <br />
    </div>
</asp:Content>

