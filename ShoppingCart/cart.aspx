<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GVCart" runat="server" AutoGenerateColumns="False" 
         onrowdeleting="GVCart_RowDeleting" 
         >   
        
        <Columns>        
               <asp:BoundField  DataField="ProductID" HeaderText="Product ID" ReadOnly="True" />
                <asp:BoundField  DataField="ProductName" HeaderText="Product Name" ReadOnly="True" /> 
                <asp:BoundField  DataField="Price" HeaderText="Price" ReadOnly="True" DataFormatString="{0:$#,###,###.00}" />
                <asp:BoundField  DataField="Quantity" HeaderText="Quantity" ReadOnly="True" />
               <asp:CommandField DeleteText="Remove Item" ShowDeleteButton="True" />
               
        </Columns>   
    </asp:GridView>
    
    <div style="text-align:center">
        <br />
        <asp:Label ID="lblEmptyCartMsg" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
    <asp:Button ID="btnContinueShopping" runat="server" Text="Continue Shopping" 
            onclick="btnContinueShopping_Click" />
    &nbsp;
    <asp:Button ID="btnCheckout" runat="server" Text="Proceed To Checkout" 
            Width="189px" onclick="btnCheckout_Click" />
    </div>
&nbsp;
</asp:Content>

