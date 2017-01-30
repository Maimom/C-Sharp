using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXML.Paragraps
{
    public class OXMLDocument : WordprocessingDocument
    {
       
            public static WordprocessingDocument Create(string fileName)
            {
                WordprocessingDocument package = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document, true);
                return package;
            }


    }
}
