using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenXML.Paragraps
{
    public partial class OpenXMLParagraph : Form
    {
        public OpenXMLParagraph()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @txtPath.Text.Trim();

            if(path.Length ==0)
            {
                btnPath_Click(sender, e);
               
                
            }

            else
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string fileName = @txtFileName.Text + ".docx";
                string CompleteFileName = path + @"\" + fileName;
                string paraText = txtParagraph.Text;

                using (var package = OXMLDocument.Create(@CompleteFileName))
                {
                    StandardOperation stdOperation = new StandardOperation();
                    stdOperation.AddMainDocumentPart(package);
                    stdOperation.AddParagraph(paraText);

                    DialogResult result = MessageBox.Show("Document Created, you want to open it ?", "Open XML Document", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(@CompleteFileName);
                    }

                }
            }
            
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            txtPath.Text = folderBrowser.SelectedPath;
        }

        private void OpenXMLParagraph_Load(object sender, EventArgs e)
        {
            //Load Font family

            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                FontList.Items.Add(font.Name);

            }


         

        }
    }
}
