using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;


namespace OpenXML.WordProcessor
{
    public class WordProcessor : WordprocessingDocument
    {
        public static WordprocessingDocument Create(string fileName)
        {
            WordprocessingDocument package = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document, true);

            return package;
        }
    }
}
