<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <table style="width:100%;">
            <tr>
                <td>
                    Pro Asp.Net 2.0 Website Programming</td>
                <td>
                    Datawarehouse E-commerce
                    </td>
    
                <td>
                    An Introduction to Object Oriented Programming with Java</td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="ImgBtnASP" runat="server" Height="251px" 
                        ImageUrl="~/Images/ASP/1590595467.jpg" onclick="ImgBtnASP_Click" 
                        Width="190px" />
                </td>
                <td>
                    <asp:ImageButton ID="ImgBtnDBMS" runat="server" Height="248px" 
                        ImageUrl="~/Images/DBMS/0130911542.jpg" onclick="ImgBtnDBMS_Click" 
                        Width="209px" />
                </td>
                <td>
                    <asp:ImageButton ID="ImgBtnProgramming" runat="server" Height="238px" 
                        ImageUrl="~/Images/Programming/0072921951.jpg" onclick="ImgBtnProgramming_Click" 
                        Width="215px" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:LinkButton ID="LinkBtnMoreASP" runat="server" onclick="LinkBtnMoreASP_Click">Browse more ASP.NET books</asp:LinkButton>
                </td>
                <td class="style1">
                    <asp:LinkButton ID="LinkBtnMoreDBMS" runat="server" onclick="LinkBtnMoreDBMS_Click">Browse more database books</asp:LinkButton>
                </td>
                <td class="style1">
                    <asp:LinkButton ID="LinkBtnMoreProgramming" runat="server" 
                        onclick="LinkBtnMoreProgramming_Click">Browse more Programming books</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    <asp:LinkButton ID="LinkBtnViewAll" runat="server" onclick="LinkBtnViewAll_Click">View Entire Book Collection</asp:LinkButton>
                </td>
                <td class="style1">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    
 
</asp:Content>

