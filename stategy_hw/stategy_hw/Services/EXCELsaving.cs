using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClosedXML.Excel;
using stategy_hw.Entities;
using stategy_hw.Models;

namespace stategy_hw.Services
{
    public class EXCELsaving : ISaveService
    {
        public void Guardar(string data)
        {
            string name = "ESTUDENTSEXCEL";
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + $"{name}.xlsx";

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Hoja 1");
            worksheet.Cell(1, 1).Value = data;
            workbook.SaveAs(pathfile);
        }
    }
}