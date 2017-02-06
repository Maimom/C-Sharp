using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLClass
{
    public class NewXML
    {
        public void UpdateConfigFile(string val1, string val2)
        {

            if (!Directory.Exists(@"A:\temp\"))
            {
                Directory.CreateDirectory(@"A:\temp\");
            }
               

            FileStream writer = new FileStream(@"A:\temp\xmlcontent.xml", FileMode.Create);

            using (XmlWriter xmlWriter = XmlWriter.Create(writer))
            {
                xmlWriter.WriteStartElement("ContentManager");
                xmlWriter.WriteStartElement("Config");
                xmlWriter.WriteElementString("Location",val1 );
                xmlWriter.WriteElementString("Url", val2);

                xmlWriter.WriteEndDocument();

                writer.Flush();
            }

            
        } 
    }
}
