<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <strong>Patient Directory</strong>
    </div>
    <div>
        <br />
        <br />
       
        <asp:HyperLink ID="Addlink" runat="server" NavigateUrl="AddPatient.aspx"  Width="200px">Add</asp:HyperLink>
        <asp:HyperLink ID="Viewlink" runat="server" NavigateUrl="ViewPatient.aspx"  Width="200px">View</asp:HyperLink>
    </div>
    </form>
</body>
</html>
