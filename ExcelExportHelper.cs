using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyVatLieuXayDung
{
	internal class ExcelExportHelper
	{
		public static void baoCaoTheoKho(System.Data.DataTable dataTable, string title, string[] columnNames)
		{
			// Tạo các đối tượng Excel
			Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel.Workbooks oBooks;
			Microsoft.Office.Interop.Excel.Sheets oSheets;
			Microsoft.Office.Interop.Excel.Workbook oBook;
			Microsoft.Office.Interop.Excel.Worksheet oSheet;

			// Tạo mới một Excel WorkBook 
			oExcel.Visible = true;
			oExcel.DisplayAlerts = false;
			oExcel.Application.SheetsInNewWorkbook = 1;
			oBooks = oExcel.Workbooks;
			oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
			oSheets = oBook.Worksheets;
			oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

			// Đặt tiêu đề cho sheet
			oSheet.Name = "BaoCao";

			// Tạo phần Tiêu đề
			Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", GetExcelColumnName(columnNames.Length) + "1");
			head.MergeCells = true;
			head.Value2 = title;
			head.Font.Bold = true;
			head.Font.Name = "Times New Roman";
			head.Font.Size = "20";
			head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

			// Tạo tiêu đề cột 
			for (int i = 0; i < columnNames.Length; i++)
			{
				Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(GetExcelColumnName(i + 1) + "3", GetExcelColumnName(i + 1) + "3");
				cl.Value2 = columnNames[i];
				cl.ColumnWidth = 15.0; // Điều chỉnh độ rộng của cột
			}

			Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", GetExcelColumnName(columnNames.Length) + "3");
			rowHead.Font.Bold = true;
			rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
			rowHead.Interior.ColorIndex = 6;
			rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

			// Tạo mảng theo datatable
			object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

			// Chuyển dữ liệu từ DataTable vào mảng đối tượng
			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				DataRow dataRow = dataTable.Rows[row];

				for (int col = 0; col < dataTable.Columns.Count; col++)
				{
					arr[row, col] = dataRow[col];
				}
			}

			// Thiết lập vùng điền dữ liệu
			int rowStart = 4;
			int columnStart = 1;
			int rowEnd = rowStart + dataTable.Rows.Count - 1;
			int columnEnd = dataTable.Columns.Count;

			// Ô bắt đầu điền dữ liệu
			Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

			// Ô kết thúc điền dữ liệu
			Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

			// Lấy về vùng điền dữ liệu
			Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

			// Điền dữ liệu vào vùng đã thiết lập
			range.Value2 = arr;

			// Kẻ viền
			range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

			// Căn giữa cả bảng 
			oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
		}

		// Hàm chuyển đổi số thành chữ cái tương ứng trong Excel (ví dụ: 1 -> A, 2 -> B, ..., 27 -> AA, ...)
		private static string GetExcelColumnName(int columnNumber)
		{
			int dividend = columnNumber;
			string columnName = String.Empty;
			int modulo;

			while (dividend > 0)
			{
				modulo = (dividend - 1) % 26;
				columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
				dividend = (dividend - modulo) / 26;
			}

			return columnName;
		}

	}
}
