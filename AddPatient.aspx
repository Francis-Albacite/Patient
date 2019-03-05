<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddPatient.aspx.cs" Inherits="AddPatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>               --- Add Patient ----              </strong>
        <br />
        <br />
        <label>Firstname:</label>
        <input type="text" id="txtfname" runat="server" /> 
        <br />
        <label>Lastname:</label>
        <input type="text" id="txtlname" runat="server" />
         <br />
        <label>Phone:</label>
        <input type="text" id="txtphone" runat="server" />
         <br />
        <label>Email:</label>
        <input type="text" id="txtemail" runat="server" />
         <br />
        <label>Gender:</label>
        <input type="text" id="txtgender" runat="server" />
         <br />
        <label>Notes:</label>
        <input type="text" id="txtnote" runat="server" />
        <br />
        <br />
       
        <asp:Button runat="server" id="btnAdd" Text="Register Patient" OnClick="btnAddPatient_Click" />
    </div>
    </form>
</body>
</html>
