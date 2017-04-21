#region Using
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using Excel = ClosedXML.Excel;
using ClosedXML.Excel;
#endregion

namespace Utilities
{
    public class Ut_GeneraExcel
    {
        public string ruta;
        public string nombreExcel;

        public void ExcelExport(DataTable dt)
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using(XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Reportes");
                wb.SaveAs(ruta + "\\ReporteCuaderno.xlsx");
                
            }
        }

        public void ExcelExport_Fecha(DataTable dt)
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Reportes Fecha");
                wb.SaveAs(ruta + "\\ReporteCuaderno_Fechas.xlsx");
                
            }
        }
        public void ExcelExport_Productos(DataTable dt)
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Reportes");
                wb.SaveAs(ruta + "\\ReporteCuaderno_Productos.xlsx");

            }
        }

        



    }
}
