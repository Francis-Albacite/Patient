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
        XElement _xml = XElement.Load("D:/patient.xml");
        IEnumerable<XElement> childElements =
            from element in _xml.Elements()
            select element;
        foreach (XElement el in childElements)
            Console.WriteLine("FirstName: " + el.Name);
        
    }
}