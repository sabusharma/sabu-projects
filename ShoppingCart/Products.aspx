<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table style="width:100%;">
        <tr>
            <td>
                Select Categories:<asp:DropDownList ID="DDListCategory" runat="server" 
                    DataSourceID="CategoryDataSource" DataTextField="CategoryName" 
                    DataValueField="CategoryID" AutoPostBack="True" 
                    onselectedindexchanged="DDListCategory_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="CategoryDataSource" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" 
                    SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridViewProductListing" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ProductID" DataSourceID="ProductDS" 
                    EnableModelValidation="True" style="margin-top: 0px" 
                    onselectedindexchanged="GridViewProductListing_SelectedIndexChanged">
                    <Columns>
                        <asp:ImageField DataAlternateTextField="Thumbnail" 
                            DataImageUrlField="Thumbnail" DataImageUrlFormatString="~\Images\{0}" 
                            HeaderText="Image">
                        </asp:ImageField>
                        <asp:BoundField DataField="ProductName" HeaderText="Product Name" 
                            SortExpression="ProductName" />
                        <asp:BoundField DataField="ShortDesc" HeaderText="Short Description" 
                            SortExpression="ShortDesc" />
                        <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" 
                            SortExpression="UnitPrice" />
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                        <asp:CommandField SelectText="View Details" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="ProductDS" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" 
                    SelectCommand="SELECT * FROM [Products] WHERE ([CategoryID] = @CategoryID) ORDER BY [ProductID]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDListCategory" DefaultValue="" 
                            Name="CategoryID" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>

</asp:Content>

