<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="ProductMaintenance.aspx.cs" Inherits="ProductMaintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>    

        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
            EnableModelValidation="True" AutoGenerateColumns="False" 
            DataKeyNames="ProductID" Width="1048px" AllowPaging="True" 
             PageSize="2">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" 
                    SortExpression="ProductID" InsertVisible="False" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                    SortExpression="CategoryID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                    SortExpression="ProductName" />
                <asp:BoundField DataField="ShortDesc" HeaderText="ShortDesc" 
                    SortExpression="ShortDesc" />
                <asp:BoundField DataField="DetailedDesc" HeaderText="DetailedDesc" 
                    SortExpression="DetailedDesc" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                    SortExpression="UnitPrice" />
                <asp:BoundField DataField="Thumbnail" HeaderText="Thumbnail" 
                    SortExpression="Thumbnail" />
                <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
               
              
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" 
            
            SelectCommand="SELECT * FROM [Products]" 
            OldValuesParameterFormatString="original_{0}">
        </asp:SqlDataSource>
    

    </div>   
    <asp:Label ID="lblResult" runat="server" ForeColor="Red" Visible="False"></asp:Label>
    <br />
    <br />
    To enter new product inventory, enter the product information and click insert:

        <br />       
   
    
    <table style="width:100%;">
            <%--<tr>
                <td class="style1">
                    Product ID</td>
                <td>
                    <asp:TextBox ID="txtBoxProductID" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>--%>
          
            <tr>
                <td class="style1">
                    CategoryID<br />
                </td>
                <td>
                    <asp:DropDownList ID="DropDownCategoryID" runat="server" 
                        DataSourceID="SqlDataSource2" DataTextField="CategoryName" 
                        DataValueField="CategoryID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" 
                        SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
                    
            </tr>
              <tr>
                <td class="style1">Product Name
                    </td>
                <td>
                    <asp:TextBox ID="txtboxProductName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtboxProductName" ErrorMessage="Product Name Required"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
            <td>
                Short Description<br />
            </td>
            <td>
            <asp:TextBox ID="txtBoxShortDesc" runat="server"></asp:TextBox>
                <br />
            </td>
            </tr>
            <tr>
            <td>
                Long Description<br />
            </td>
            <td>
            <asp:TextBox ID="txtBoxLongDesc" runat="server"></asp:TextBox>
                <br />
            </td>
            </tr>
            <tr>
            <td>
            Unit Price
            </td>
            <td>
            <asp:TextBox ID="txtBoxUnitPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtBoxUnitPrice" ErrorMessage="Unit Price Required"></asp:RequiredFieldValidator>
                <br />
            </td>
            
            </tr>
            <tr>
            <td>
                Thumbnail ImageFile<br />
            </td>
            <td>
            <asp:TextBox ID="txtBoxThImageFile" runat="server"></asp:TextBox>
                <br />
            </td>
            </tr>
            <tr>
            <td>
                Large Image File<br />
            </td>
            <td>
            <asp:TextBox ID="txtBoxLargeImageFile" runat="server"></asp:TextBox>
                <br />
            </td>
            </tr>
            <tr>
            <td>
                ISBN<br />
            </td>
            <td>
            <asp:TextBox ID="txtBoxISBN" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtBoxISBN" ErrorMessage="ISBN required"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
            </tr>

        </table>


    
    <asp:Button ID="btnInsert" runat="server" Text="Insert" 
        onclick="btnInsert_Click" />
    <asp:Button ID="Cancel" runat="server" Text="Cancel" />
    <div>
    </div>
</asp:Content>

