using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung
{
    public partial class FormBaoCao2 : Form
    {
		private readonly DatabaseConnector dbConnector;
		private DataTable dataTable;
		public FormBaoCao2()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormBaoCao2_Load(object sender, EventArgs e)
		{
			LoadComboBox();
		}

		private void LoadComboBox()
		{
			//Load combo box cho Kho
			string queryKho = "SELECT MaKho, TenKho FROM KhoHang";
			cbbKho.DataSource = dbConnector.ExecuteQuery(queryKho);
			cbbKho.DisplayMember = "TenKho";
			cbbKho.ValueMember = "MaKho";

			
		}

		private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Kiểm tra xem ký tự có phải là số không
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				// Nếu không phải là số, ngăn chặn sự kiện nhập
				e.Handled = true;
			}
		}


		private void btnBaoCao2_Click(object sender, EventArgs e)
		{
			string kho = cbbKho.SelectedValue.ToString() ;
			int soLuong;
			if (!int.TryParse(txtSoLuong.Text, out soLuong))
			{
				MessageBox.Show("Nhập số lượng hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string query = $"Select * from dbo.GetTopNHoaDonByKho('{kho}', '{soLuong}')";

			dataTable = dbConnector.ExecuteQuery(query);
			dgvBaoCao.DataSource = dataTable;
			if (dgvBaoCao.RowCount == 1)
			{
				MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dgvBaoCao.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xuất excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			string title = "";
			string kho = cbbKho.SelectedValue.ToString();
			int soLuong = int.Parse(txtSoLuong.Text);
			string[] columnNames = { "Mã vật tư", "Tên vật tư", "Số lần bán" };
			title = $"{soLuong} hóa đơn có tổng tiền lớn nhất trong kho {kho}";
			DataTable excel = dgvBaoCao.DataSource as DataTable;
			ExcelExportHelper.baoCaoTheoKho(excel, title, columnNames);
		}
	}
}
