<%@ Page Title="" Language="C#" MasterPageFile="~/SecondMaster.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 style="margin-left: 360px">Customer Registration Form</h2>
       
        <table style="width:auto; margin-left:auto; margin-right:auto">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblRegistrationMsg" runat="server"></asp:Label>
                </td>
                
            </tr>
            
            <tr>
                <td style="width: 153px">
                    Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" 
                        ErrorMessage="Email is required" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Invalid Email" 
                        ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
     
                </td>
                
            </tr>
            
             <tr>
                <td style="width: 153px">
                    Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" 
                        ErrorMessage="Password is required" ControlToValidate ="txtPassword">*</asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
            <td style="width: 153px">
                Confirm Password</td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" 
                    Width="234px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPass" runat="server" 
                    ControlToValidate="txtConfirmPassword" 
                    ErrorMessage="Confirm Password is required.">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
                    Display="Dynamic" ErrorMessage="Password does not match.">*</asp:CompareValidator>
            </td>
        </tr>
            
            <tr>
                <td style="width: 153px">
                 Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" 
                        ErrorMessage="Last name is required" ControlToValidate="txtLastName">*</asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" 
                        ErrorMessage="First Name is required" ControlToValidate ="txtFirstName">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Width="247px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" 
                        ErrorMessage="Address is required" ControlToValidate="txtFirstName">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" 
                        ErrorMessage="City is required." ControlToValidate="txtCity">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    State</td>
                <td>
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorState" runat="server" 
                        ErrorMessage="State is required" ControlToValidate="txtState">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    Zip Code</td>
                <td>
                    <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorZip" runat="server" 
                        ErrorMessage="Zip is required." ControlToValidate="txtZip">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    Phone</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" 
                        ErrorMessage="Phone is required" ControlToValidate="txtPhone">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            
            <tr>
                <td style="width: 153px">
                   Secret Question</td>
                <td>
                    <asp:TextBox ID="txtSecretQn" runat="server" Width="369px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorQuestion" runat="server" 
                        ErrorMessage="Secret question is required." ControlToValidate="txtSecretQn">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            <tr>
                <td style="width: 153px">
                    Secret Answer</td>
                <td>
                    <asp:TextBox ID="txtAns" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAnswer" runat="server" 
                        ErrorMessage="Secret Answer is required." ControlToValidate="txtAns">*</asp:RequiredFieldValidator>
               </td>
                
            </tr>
            
            <tr>
                
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click"
                         />
                    </td>
           <td>
           <asp:Button ID="btnCance" runat="server" Text="Cancel" onclick="btnCancel_Click" style="height: 26px"
                         />
                    </td>
                
            </tr>
            <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
            
        </table>


</asp:Content>

