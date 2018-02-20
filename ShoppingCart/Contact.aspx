<%@ Page Title="" Language="C#" MasterPageFile="~/SecondMaster.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 style="text-align:center">
            Contact Us </h1>        
        <table style="margin-left:auto; margin-right:auto">    
                 <tr><td> <asp:label ID="lblRevisitedUser" runat="server" ></asp:label></td></tr>                        
               
            <tr>            
                <td>
            
                 <table style="width:100%;">
                    <tr>
                        <td>
                            First Name</td>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="txtFirstNameRequiredFieldValidator" runat="server" 
                                Text="*" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                       </td>
            
                    </tr>
                    <tr>
                        <td>
                            Last Name</td>
                        <td>
                            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                              controlToValidate="txtLastName"  Text="*"></asp:RequiredFieldValidator>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                           Email
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                            &nbsp;
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                controlTOValidate="txtEmail" Text="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtEmail" ErrorMessage="Invalid Email" 
                                ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
     
                      </td>
                    </tr>
                    <tr>
                        <td> Subject
                        </td>
                        <td>      
                            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                            
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                Text="*" ControlToValidate="txtSubject"></asp:RequiredFieldValidator>
                         </td>
                   </tr>  
                   <tr>
                        <td> 
                           Message
                           
                        </td>
                        <td>
                            <asp:TextBox ID="txtMessage" runat="server" Height="125px" TextMode="MultiLine" 
                                Width="457px"></asp:TextBox>
                            
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                Text="*" ControlToValidate ="txtMessage"></asp:RequiredFieldValidator>                
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnContactSubmit" runat="server" Text="Submit" 
                                onclick="btnContactSubmit_Click" />
                        </td>
                    </tr>
            </table>
        </td>
       
    </tr>
    
   </table>
</asp:Content>

