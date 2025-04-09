using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace massive_sheet_splitter
{
    public class ExcelSheetData
    {
        public string SheetName { get; set; }
        public List<List<string>> Rows { get; set; } = new List<List<string>>();
    }

    public class ExcelHelper
    {
        public ExcelHelper()
        {
            ExcelPackage.License.SetNonCommercialPersonal("rcht");
        }

        public List<ExcelSheetData> read_excel(string file_path)
        {
            var workbookData = new List<ExcelSheetData>();

            using (var package = new ExcelPackage(new FileInfo(file_path)))
            {
                foreach (var sheet in package.Workbook.Worksheets)
                {
                    var sheetData = new ExcelSheetData { SheetName = sheet.Name };

                    int rowCount = sheet.Dimension.Rows;
                    int colCount = sheet.Dimension.Columns;

                    for (int row = 1; row <= rowCount; row++)
                    {
                        var rowData = new List<string>();
                        for (int col = 1; col <= colCount; col++)
                        {
                            rowData.Add(sheet.Cells[row, col].Text);
                        }
                        sheetData.Rows.Add(rowData);
                    }

                    workbookData.Add(sheetData);
                }
            }

            return workbookData;
        }

        public void write_excel(string dest_path, List<ExcelSheetData> sheets, int start_row, int end_row, int last_header_row)
        {
            using (var package = new ExcelPackage())
            {
                foreach (var sheetData in sheets)
                {
                    var ws = package.Workbook.Worksheets.Add(sheetData.SheetName);

                    int currentRow = 1;
                    for (int i = 0; i < last_header_row; i++)
                    {
                        for (int col = 0; col < sheetData.Rows[i].Count; col++)
                        {
                            ws.Cells[currentRow, col + 1].Value = sheetData.Rows[i][col];
                        }
                        currentRow++;
                    }

                    for (int i = start_row - 1; i < end_row && i < sheetData.Rows.Count; i++)
                    {
                        for (int col = 0; col < sheetData.Rows[i].Count; col++)
                        {
                            ws.Cells[currentRow, col + 1].Value = sheetData.Rows[i][col];
                        }
                        currentRow++;
                    }
                }

                package.SaveAs(new FileInfo(dest_path));
            }
        }

        public (string SheetName, int RowCount) GetSheetWithMostRows(List<ExcelSheetData> data)
        {
            string maxSheetName = "";
            int maxRowCount = 0;

            foreach (var sheet in data)
            {
                int rowCount = sheet.Rows.Count;
                if (rowCount > maxRowCount)
                {
                    maxRowCount = rowCount;
                    maxSheetName = sheet.SheetName;
                }
            }
            return (maxSheetName, maxRowCount);
        }
    }
}
