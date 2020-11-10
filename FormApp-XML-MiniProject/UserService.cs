using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames; 

namespace FormApp_XML_MiniProject
{
    public partial class UserService
    {
        public string filePath { get; set; }

        public XDocument UpdateUser(string name, string surname, string birthDate, string adress, string job, string id)
        {
            XDocument xDoc = XDocument.Load(filePath);
            XElement node = xDoc.Element("AllUsers").Elements("User").FirstOrDefault(a => a.Element("ID").Value.Trim() == id);
            if (node != null)
            {
                node.SetElementValue("Name", name);
                node.SetElementValue("Surname", surname);
                node.SetElementValue("Birthdate", birthDate);
                node.SetElementValue("Adress", adress);
                node.SetElementValue("Job", job);
            }
            return xDoc;
        }
        public XDocument DeleteUser(string id)
        {
            XDocument xDoc = XDocument.Load(filePath);
            xDoc.Root.Elements().Where(a => a.Element("ID").Value == id).Remove();
            return xDoc;
        }
        public XDocument CreateUser(string name, string surname, string birthday, string adress, string job)
        {

            XDocument xDoc = new XDocument(
             new XDeclaration("1.0", null, "yes"),
             new XElement("AllUsers",
             new XElement("User",
             new XElement("ID", 1),
             new XElement("Name", name),
             new XElement("Surname", surname),
             new XElement("Birthdate", birthday),
               new XElement("Adress", adress),
             new XElement("Job", job)))
              );
            return xDoc;
        }
        public XDocument AddUser(string name, string surname, string birthday, string adress, string job)
        {
            XDocument xDocLoad = XDocument.Load(filePath);
            int maxID = 1;
            var count = xDocLoad.Descendants("ID");
            if (xDocLoad != null && count.Count() > 0)
            {
                maxID = xDocLoad.Descendants("ID").Max(u => (int)u);
                maxID++;
            }
            xDocLoad.Element("AllUsers").Add(
                  new XElement("User",
                  new XElement("ID", maxID),
                  new XElement("Name", name),
                  new XElement("Surname", surname),
                  new XElement("Birthdate", birthday),
                  new XElement("Adress", adress),
                  new XElement("Job", job))
                );
            return xDocLoad;
        }
    }
}