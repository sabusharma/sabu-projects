<%@ Page Title="" Language="C#" MasterPageFile="~/SecondMaster.master" AutoEventWireup="true" CodeFile="loginpage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   <div>
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <table style="width:100%;">
           <tr>
               <td style="text-align: right; width: 378px;">
                   Email:</td>
               <td>
                   &nbsp;</td>
               <td>
                   <asp:TextBox ID="tbSignInEmail" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                       ErrorMessage="*" ControlToValidate ="tbSignInEmail"></asp:RequiredFieldValidator>
               </td>
           </tr>
           <tr>
               <td style="text-align: right; width: 378px;">
                   Password:</td>
               <td>
                   &nbsp;</td>
               <td>
                   <asp:TextBox ID="tbSignInPassword" runat="server" TextMode="Password" 
                       width="128px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                       ErrorMessage="*" ControlToValidate="tbSignInPassword"></asp:RequiredFieldValidator>
               </td>
           </tr>
           <tr>
               <td style="text-align: right; width: 378px;">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                   <br />
                   <asp:Button ID="btnSignIn" runat="server" onclick="btnSignIn_Click" 
                       Text="Sign In" />
&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="lblInvalidLogin" runat="server"></asp:Label>
               </td>
           </tr>
           <tr>
               <td style="text-align: right; width: 378px;">
                   New User?</td>
               <td>
                   &nbsp;</td>
               <td>
                   <asp:HyperLink ID="hyperlinkSignUp" runat="server" 
                       NavigateUrl="~/registration.aspx">Sign Up</asp:HyperLink>
               </td>
           </tr>
       </table>       
   
   </div>
   <div>
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
    </div>
    
</asp:Content>