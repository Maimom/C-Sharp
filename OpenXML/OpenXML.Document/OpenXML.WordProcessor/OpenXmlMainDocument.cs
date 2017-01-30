using DocumentFormat.OpenXml.Packaging;
using OpenXML.WordProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXML.WordProcessor
{
    public class OpenXmlMainDocument
    {
      
        public WordprocessingDocument wordPackage;
         OpenXmlParagraph paragraph = new OpenXmlParagraph();

        public void AddParagraph(string text)
        {
            paragraph.AddParagraph(text);

        }

        
        
     
       
    }
}
