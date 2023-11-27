using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung
{
	public partial class ReportVatTu : Form
	{
		DataTable dataTable;
		public ReportVatTu(DataTable db)
		{
			InitializeComponent();
			dataTable = db;
		}
		
		private void ReportVatTu_Load(object sender, EventArgs e)
		{
			// Gán dữ liệu cho báo cáo
			var reportDataSource = new ReportDataSource("VatTu", dataTable);
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

			// Refresh và hiển thị báo cáo
			this.reportViewer1.RefreshReport();
		}
    }
}
