using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeServicio;

namespace OperacionesDeServicio
{
    public class CargarInformacionExcel
    {
        public object CargarObjeto()
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;


            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\programador1\Downloads\empleados.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets["Hoja1"];


            var SubjectVal = xlWorkSheet.Columns.Find("Subject").Cells.Column;
            string Subject = xlWorkSheet.Cells[2, SubjectVal].Text.ToString();

            var FromVal = xlWorkSheet.Columns.Find("From").Cells.Column;
            string From = xlWorkSheet.Cells[2, FromVal].Text.ToString();

            var ReplyToVal = xlWorkSheet.Columns.Find("ReplyTo").Cells.Column;
            string ReplyTo = xlWorkSheet.Cells[2, ReplyToVal].Text.ToString();

            var TemplateVal1 = xlWorkSheet.Columns.Find("Template/Type").Cells.Column;
            string Template1 = xlWorkSheet.Cells[2, TemplateVal1].Text.ToString();

            var TemplateVal2 = xlWorkSheet.Columns.Find("Template/Value").Cells.Column;
            string Template2 = xlWorkSheet.Cells[2, TemplateVal2].Text.ToString();

            var RecipientsVal = xlWorkSheet.Columns.Find("Recipients/0").Cells.Column;
            string Recipients = xlWorkSheet.Cells[2, RecipientsVal].Text.ToString();

            var RecipientsVal1 = xlWorkSheet.Columns.Find("Recipients/1").Cells.Column;
            string Recipients1 = xlWorkSheet.Cells[2, RecipientsVal1].Text.ToString();

            var RecipientsVal2 = xlWorkSheet.Columns.Find("Recipients/2").Cells.Column;
            string Recipients2 = xlWorkSheet.Cells[2, RecipientsVal2].Text.ToString();



            CorreoSimple objJson = new CorreoSimple();
            objJson.Subject = Subject;
            objJson.From = From;
            objJson.Template = new Template() { Type = Template1, Value = Template2 };
            objJson.ReplyTo = ReplyTo;
            objJson.Recipients = new List<Recipients> { new Recipients() { To = Recipients }, new Recipients() { To = Recipients1 }, new Recipients() { To = Recipients2 } };


            return objJson;
        }
    }
}
