<%@ Page Title="" Language="C#" MasterPageFile="~/SecondMaster.master" AutoEventWireup="true" CodeFile="Successpage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>                           
        </tr>
        <tr>
            <td>
                <h3>&nbsp;</h3>
                <h3>
                    <asp:Label ID="lblSuccessful" runat="server" Text="Label"></asp:Label>
                </h3>
                <p style="text-align: center">
                    <asp:Label ID="lblShowOrderID" runat="server"></asp:Label>
                </p>
            </td>
            
        </tr>
        <tr>
        
        
            <td style="text-align:center;">
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="btnSignupContinue" runat="server" Text="Continue Shopping" 
                    onclick="btnSignupContinue_Click" />
                &nbsp;
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td> 
                      
        </tr>
        
        
    </table>
</asp:Content>

