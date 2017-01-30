using System;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OpenXML.WordProcessor
{
    public class OpenXmlParagraph
    {
        public Paragraph AddParagraph(string text)
        {
            var element = new Paragraph(
                new ParagraphProperties(
                    new Justification(){Val= JustificationValues.Left},
                    AddRun(text, Default.FontFamily, Default.FontSize,"Black", false, false, false)
                    ));
      
            return element;
        }

        public Paragraph StartParagraph()
        {
            var element = new Paragraph(
                new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Left }));
            
            Global.CurrentParagraph = element;
            return element;
        }

        public void EndParagraph()
        {
           
            Global.CurrentParagraph = new Paragraph();
        }


        public Run AddRun(string text, string fontType , UInt16 fontSize, string fontColor, Boolean isBold, Boolean isItalic, Boolean isUnderline)
        {           
            var element =
                new Run(
                    new FontSize() { Val = GetFontSize(fontSize) },
                    new RunFonts() { Ascii = fontType },
                    new Bold() { Val = isBold },
                    new Italic() { Val = isItalic },
                     new Color() { Val = "365F91", ThemeColor = ThemeColorValues.Accent1, ThemeShade = "BF" },
                    new Underline() { Val = GetUnderlineValue(isUnderline)},
                    new Text(text));
            
            return element;

        }

        private UnderlineValues GetUnderlineValue(Boolean IsUnderline)
        {
            UnderlineValues underlineValue = new UnderlineValues();
            underlineValue = UnderlineValues.None;
            if (IsUnderline)
            {
                underlineValue = UnderlineValues.Single;
            }
            return underlineValue;
        }

        private string GetFontSize(UInt16 fontSize) 
        {
            return (fontSize * 2).ToString();
        }

        private string GetColor(Color FontColor) 
        {
            return FontColor.ToString();
           
           
        }
  
    }
    public static class Default
    {
        public static string FontFamily { get { return "Arial"; } }
        public static UInt16 FontSize { get { return 10; } }
        public static string Justification { get { return "Left"; } }
    }


}
