<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chapter 8: Earwig</title>
    <link href="Styles/Main.css" rel="stylesheet"/>
    <link href="Styles/Request.css" rel="stylesheet" />
</head>
<body>
    <header>
        <asp:Image ID="imgMotel" runat="server" ImageUrl="~/Images/The_Happy_Earwig_Motel.png" BorderColor="White" BorderWidth="10px" ImageAlign="Left" />
        <h1>The Happy Earwig Motel</h1>
        <h2>Our crawl-space now body-free!</h2>
        <p><br/><br/></p>
    </header>
    <section>
        <form id="form1" runat="server" defaultbutton="btnSubmit" defaultfocus="txtArrivalDate">
            <h1>Contact Information<br/><br/></h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="* means that the field is required" CssClass="validator" />

            <label class="label">First name</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="entry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                    ControlToValidate="txtFirstName" text="*" CssClass="validator" Display="Dynamic">
                </asp:RequiredFieldValidator><br />
            <label class="label">Last name</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="entry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                    ControlToValidate="txtLastName" text="*" CssClass="validator" Display="Dynamic">
                </asp:RequiredFieldValidator><br />
            <label class="label">Email address</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="entry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                    ControlToValidate="txtEmail" text="*" CssClass="validator" Display="Dynamic">
                </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" Text="Must be valid email address" 
                ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validator" ></asp:RegularExpressionValidator><br />
            <label class="label">Telephone number</label>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="entry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                    ControlToValidate="txtPhone" text="*" CssClass="validator" Display="Dynamic">
                </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revPhone" runat="server" Display="Dynamic" Text="Use this format: 999-999-9999"
                 ControlToValidate="txtPhone" CssClass="validator" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>    
            <br />
            <label class="label">Preferred method</label>
            <asp:DropDownList ID="ddlPreferredMethod" runat="server">
                <asp:ListItem>Email</asp:ListItem>
                <asp:ListItem>Telephone</asp:ListItem>
            </asp:DropDownList><br />

            <label class="label">&nbsp;</label>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" />&nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button" CausesValidation="False" OnClick="btnClear_Click" /><br />
            <p ID="message">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
    </form>
    </section>
    <footer>
        <p>&copy; 2015, Happy Earwig Motel</p>
    </footer>
</body>
</html>
