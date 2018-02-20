<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DVProductDetails" runat="server" Height="170px" 
        Width="1048px" onpageindexchanging="DVProductDetails_PageIndexChanging" 
    AutoGenerateRows="False" EnableModelValidation="True">
        <Fields>
         <asp:ImageField DataImageUrlField="thumbnail" 
                DataImageUrlFormatString="~\images\{0}" ></asp:ImageField>           
         <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
         <asp:BoundField DataField="ProductName" HeaderText="Product Name" >
            <ItemStyle Font-Bold="True" />
            </asp:BoundField>
         <asp:BoundField DataField="ShortDesc" />
         <asp:BoundField DataField="DetailedDesc" HeaderText="Product Description" />
         <asp:BoundField DataField="UnitPrice" HeaderText="Price" 
                DataFormatString="{0:$#,###,###.00}">
            <ItemStyle Font-Bold="True" />
            </asp:BoundField>
        </Fields>
    </asp:DetailsView>
    <div style="text-align: center">
        <br />
        <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" 
            onclick="btnAddToCart_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnContinueShopping" runat="server" 
            onclick="btnContinueShopping_Click" Text="Continue Shopping" />
        <br />
        <br />
    </div>
</asp:Content>

