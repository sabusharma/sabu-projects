<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="CategoryMaintenance.aspx.cs" Inherits="CategoryMaintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>    

        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
            EnableModelValidation="True" AutoGenerateColumns="False" 
            DataKeyNames="CategoryID" Width="405px" AllowPaging="True" 
             PageSize="5">
            <Columns>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" ReadOnly="True" 
                    SortExpression="CategoryID" InsertVisible="False" />
                <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" 
                    SortExpression="CategoryName" />
                <asp:BoundField DataField="Description" HeaderText="Description" 
                    SortExpression="Description" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" 
            
            SelectCommand="SELECT * FROM [Category]" 
            OldValuesParameterFormatString="original_{0}">
        </asp:SqlDataSource>
    

    </div>   
    <asp:Label ID="lblResult" runat="server" ForeColor="Red" Visible="False"></asp:Label>
    <br />
    <br />
    To create a new category, enter the category information and click insert:

        <br />       
   
    
    <table style="width:100%;">
           
            <tr>
                <td class="style1">
                    Name</td>
                <td>
                    <asp:TextBox ID="txtBoxCategoryName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    Category Description<br />
                </td>
                
            <td>
            <asp:TextBox ID="txtBoxCategoryDescription" runat="server"></asp:TextBox>
                <br />
            </td>
            </tr>
            

        </table>


    
    <asp:Button ID="btnInsert" runat="server" Text="Insert" 
        onclick="btnInsertCategory_Click" />
    <asp:Button ID="Cancel" runat="server" Text="Cancel" />
    <div>
    </div>
</asp:Content>

