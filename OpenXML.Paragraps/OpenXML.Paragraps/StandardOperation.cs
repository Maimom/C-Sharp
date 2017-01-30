using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXML.Paragraps
{
    public class StandardOperation
    {
        public WordprocessingDocument wordPackage;

        public void AddMainDocumentPart(WordprocessingDocument package)
        {
            MainDocumentPart mainDocumentPart = package.AddMainDocumentPart();
            Document document = new Document();
            Body body = new Body();
            document.Append(body);
            package.MainDocumentPart.Document = document;
            wordPackage = package;
        }
        
        public Paragraph AddParagraph(string text, string fontType="Arial", string fontSize="20", Boolean isBold=false, Boolean isItalic=false)
        {
            var element =
                     new Paragraph(
                         new RunFonts() { Ascii = fontType },
                         new FontSize() { Val = fontSize },
                         new Bold() { Val = isBold },
                         new Italic() { Val = isItalic },
                         new Run(
                         new Text(text)));
            wordPackage.MainDocumentPart.Document.Append(element);
            return element;
        }
    }
}
