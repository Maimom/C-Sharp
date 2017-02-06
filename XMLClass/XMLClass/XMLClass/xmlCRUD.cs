using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLClass
{
    public partial class xmlCRUD : Form
    {
        public xmlCRUD()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var newxml = new NewXML();
            newxml.UpdateConfigFile(txtLocation.Text, txtUrl.Text);
           
        }

        private void xmlCRUD_Load(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load(@"A:\temp\xmlcontent.xml");
            var files = (from x in xmlDoc.Root.Elements("Location")
                         select
                         new FileToWatch
                         {
                             Location = (string)x.Element("Location").Value ?? string.Empty,
                             URL = (string)x.Element("Url").Value ?? string.Empty,

                         }).ToList();

         }
    }
}
