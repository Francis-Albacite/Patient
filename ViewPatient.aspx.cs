using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class ViewPatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load("D:/patient.xml"); 

        XmlNodeList xnList = xmldoc.SelectNodes("/Patients/Patient");

        divpatient.InnerHtml = "<table style=\"width: 100%\"> <tr><th> Firstname </th><th> Lastname </th><th> Email </th></tr>";

        foreach (XmlNode xn in xnList)
        {
            string firstName = xn["FirstName"].InnerText;
            string lastName = xn["LastName"].InnerText;
            string email = xn["Email"].InnerText;

            // divpatient.InnerHtml = divpatient.InnerHtml + "<tr><th>" +  firstName + "</th><th>" + lastName + "</th><th>" + email +"</th></tr>";
            divpatient.InnerHtml = divpatient.InnerHtml + "<tr><th>" + firstName + "</th><th>" + lastName + "</th> <th>" + email + "</th>"
                + "<th><button type = \"button\">Edit</button></th>" 
                + "<th><button type = \"button\">Delete</button></th></tr>";


        }

        divpatient.InnerHtml = divpatient.InnerHtml + "</table>";

    }
}