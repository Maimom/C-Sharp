using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace MyTeamApp
{
    class MyExcel
    {
        public static string filePath = @"";
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
    

        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(filePath);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; 
           
        }
       
        public static void WriteToExcel(string value,int row, int col)
        {
            try
            {
                MySheet.Cells[row, col] = value;
                MyBook.Save();
            }
            catch (Exception ex)
            { }

        }

       
      
        public  static void staticCloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }
        
    }
    
}
