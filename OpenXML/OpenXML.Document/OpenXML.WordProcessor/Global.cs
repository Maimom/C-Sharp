using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXML.WordProcessor
{
   public static class Global
    {
       public static Table CurrentTable { get; set; }
       
       public static Paragraph CurrentParagraph { get; set; }

    }
}
