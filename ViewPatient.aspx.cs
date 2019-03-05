﻿using System;
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
        XmlDocument xml = new XmlDocument();
        xml.LoadXml("D:/patient.xml"); 

        XmlNodeList xnList = xml.SelectNodes("/Patients/Patient");
        foreach (XmlNode xn in xnList)
        {
            string firstName = xn["FirstName"].InnerText;
            string lastName = xn["LastName"].InnerText;
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }



    }
}