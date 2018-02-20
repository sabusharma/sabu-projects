<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="ordersummary.aspx.cs" Inherits="ordersummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
     <table style="width:100%;">
            <tr>
                <td style="width: 568px">
                    <b>Bill To:</b></td>
                <td style="width: 10px">
                    &nbsp;</td>
                <td>
                    <b>Ship To:</b></td>
            </tr>
            <tr style="border-bottom-style:none;">
                <td style="width: 568px">
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
                    </asp:Panel></td>
            </tr>
            <tr style="border-bottom-style:none;">
                <td colspan="3">
                    <asp:GridView ID="GVOrderSummary" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" 
                        onselectedindexchanged="GVOrderSummary_SelectedIndexChanged" Width="534px" HorizontalAlign="Left">
                        <HeaderStyle HorizontalAlign ="Left" />
                        <Columns>                       
                                <asp:BoundField  DataField="ProductName" HeaderText="Product Name" ReadOnly="True" /> 
                                <asp:BoundField  DataField="Price" HeaderText="Price" ReadOnly="True" DataFormatString="{0:$#,###,###.00}" />
                                <asp:BoundField  DataField="Quantity" HeaderText="Quantity" ReadOnly="True" />
                                <asp:BoundField  DataField="SubTotal" HeaderText="SubTotal" ReadOnly="True" DataFormatString="{0:$#,###,###.00}"/>                
                            </Columns> 
                    </asp:GridView>
                </td>
            </tr>
            
            
            <tr style="border-bottom-style:none;">
                <td style="width: 568px">
                    <asp:Panel ID="Panel2" runat="server">
                        <table>
                            <tr><td style="text-align: right; width: 372px">
                                    Total:</td>
                <td style="width: 20px">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblTotalCost" runat="server" style="text-align: center"></asp:Label></td>
            </tr>
            
            <tr style="border-bottom-style:none;">
                <td style="text-align: right; width: 372px">
                    Sales Tax:</td>
                <td style="width: 20px">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblSalesTax" runat="server"></asp:Label>
                </td>
            </tr>
            <tr style="border-bottom-style:none;">
                <td style="text-align: right; width: 372px">
                    Shipping Cost</td>
                <td style="width: 20px">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblShippingCost" runat="server"></asp:Label>
                </td>
            </tr>
            <tr style="border-bottom-style:none;">
                <td style="text-align: right; height: 23px; width: 372px">
                    Net Total:</td>
                <td style="height: 23px; width: 20px">
                    </td>
                <td style="height: 23px">
                    <asp:Label ID="lblNetTotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr style="border-bottom-style:none;">
                <td style="width: 372px">
                    &nbsp;</td>
                <td style="width: 20px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
            
            </asp:Panel>
            </td>
      </tr>
      <tr>
      <td style="width: 568px">
     
     <asp:Panel ID="Panel1" runat="server">
     <table>
     <tr>
         <td colspan="2" style="border-bottom-style:none;">
                    <b>Credit Card Details:</b></td>
            </tr>
            
            <tr>
                <td style="width: 99px;border-bottom-style:none;"">
                    Card Number:</td>
                
                <td style="border-bottom-style:none;">
                    <asp:TextBox ID="txtCardNum" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtCardNum"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 99px;border-bottom-style:none;"">
                    Name on Card:</td>
                
                <td style="border-bottom-style:none;">
                    <asp:TextBox ID="txtNameonCard" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtNameonCard"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr >
                <td style="width: 99px;border-bottom-style:none;">
                    Expiry Date:</td>
                
                <td style="border-bottom-style:none;">
                    <asp:TextBox ID="txtExpDate" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtExpDate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr >
                <td style="width: 99px;border-bottom-style:none;">
                    Security Code:</td>
                
                <td>
                    <asp:TextBox ID="txtSecCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtSecCode"></asp:RequiredFieldValidator>
                </td>
            </tr>
     </table>
     </asp:Panel>
     </td>
     </tr> 
      <tr><td style="text-align :center;">
     
          <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" onclick="btnPlaceOrder_Click" 
               />
     </td></tr> </table>
     <br />

</div>


<div>
</div>

</asp:Content>

