using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class AddPatient : System.Web.UI.Page
{
    public object MessageBox { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public class Patient
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LasUpdatedDate { get; set; }
        public int IsDeleted { get; set; }
    }

    public void ClearForm()
    {
        txtemail.Value = "";
        txtfname.Value = "";
        txtlname.Value = "";
        txtnote.Value = "";
        txtphone.Value = "";
        txtgender.Value = "";
        
    }


    protected void btnAddPatient_Click(object sender, EventArgs e)
    {

        Patient[] _patientlist = new Patient[]
        {
           new Patient { Firstname = txtfname.Value,
            Lastname = txtlname.Value,
            Phone = txtphone.Value,
            Email = txtemail.Value,
            Gender = txtgender.Value,
            Notes = txtnote.Value,
            CreatedDate = DateTime.Now,
            IsDeleted = 0,
            LasUpdatedDate = DateTime.MinValue }
        };

        if (File.Exists("D:/patient.xml"))
        {
            XDocument xDocument = XDocument.Load("D:/patient.xml");
            XElement root = xDocument.Element("Patients");
            IEnumerable<XElement> rows = root.Descendants("Patient");
            XElement firstRow = rows.Last();
            firstRow.AddBeforeSelf(
               
               from Patient in _patientlist
               select new XElement("Patient",
               new XElement("FirstName", Patient.Firstname),
               new XElement("LastName", Patient.Lastname),
               new XElement("Phone", Patient.Phone),
               new XElement("Email", Patient.Email),
               new XElement("Gender", Patient.Gender),
               new XElement("Notes", Patient.Notes),
               new XElement("CreatedDate", Patient.CreatedDate),
               new XElement("LasUpdatedDate", Patient.LasUpdatedDate),
               new XElement("IsDeleted", Patient.IsDeleted)));
               xDocument.Save("D:/patient.xml");
        }
        else
        {
            XDocument document = new XDocument
            (
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("Patients",

            from Patient in _patientlist
            select new XElement("Patient",
            new XElement("FirstName", Patient.Firstname),
            new XElement("LastName", Patient.Lastname),
            new XElement("Phone", Patient.Phone),
            new XElement("Email", Patient.Email),
            new XElement("Gender", Patient.Gender),
            new XElement("Notes", Patient.Notes),
            new XElement("CreatedDate", Patient.CreatedDate),
            new XElement("LasUpdatedDate", Patient.LasUpdatedDate),
            new XElement("IsDeleted", Patient.IsDeleted)
                )

               )

            );

            document.Save("D:/patient.xml");
        }
        ClearForm();
        Response.Write(@"<script language='javascript'>alert('Patient saved successfully')</script>");

    }
}