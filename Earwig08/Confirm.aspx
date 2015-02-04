<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chapter 8: Earwig</title>
    <link href="Styles/Main.css" rel="stylesheet" />
    <link href="Styles/Confirm.css" rel="stylesheet" />
</head>
<body>
    <header>
        <asp:Image ID="imgMotel" runat="server" ImageUrl="~/Images/The_Happy_Earwig_Motel.png" BorderColor="White" BorderWidth="10px" ImageAlign="Left" />
        <h1>The Happy Earwig Motel</h1>
        <h2>Our crawl-space now body-free!</h2>
        <p><br/><br/></p>
    </header>
    <section>
        <form id="form1" runat="server">
            <h1>Request Confirmation</h1>
            <h2>Please confirm your reservation request</h2>
            <label>First name</label>
            <asp:Label ID="lblFirstName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Last name</label>
            <asp:Label ID="lblLastName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Email</label>
            <asp:Label ID="lblEmail" runat="server" CssClass="entry"></asp:Label><br />
            <label>Phone</label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label><br />
            <label>Preferred method</label>
            <asp:Label ID="lblPreferredMethod" runat="server"></asp:Label><br />
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" CssClass="button" OnClick="btnConfirm_Click" />
            <asp:Button ID="btnModify" runat="server" Text="Modify" CssClass="button" PostBackUrl="~/Contact.aspx" /><br />
            <p id="message">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </form>    
    </section>
    <footer>
        <p>&copy; 2015, Happy Earwig Motel</p>
    </footer>
</body>
</html>