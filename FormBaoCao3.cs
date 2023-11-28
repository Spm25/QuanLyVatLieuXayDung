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
    public partial class FormBaoCao3 : Form
    {
		private readonly DatabaseConnector dbConnector;
		private DataTable dataTable;
		public FormBaoCao3()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormBaoCao3_Load(object sender, EventArgs e)
		{
			LoadComboBox();
		}

		private void LoadComboBox()
		{
			//Load combo box cho Khách hàng
			string queryKhachHang = "Select TenKhachHang, MaKhachHang From KhachHang";
			cbbKhachHang.DataSource = dbConnector.ExecuteQuery(queryKhachHang);
			cbbKhachHang.DisplayMember = "TenKhachHang";
			cbbKhachHang.ValueMember = "MaKhachHang";
			cbbKhachHang.SelectedIndex = 0;
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

		private void datBatDau2_ValueChanged(object sender, EventArgs e)
		{
			// Kiểm tra xem datKetThuc có nhỏ hơn datBatDau không
			if (datKetThuc2.Value < datBatDau2.Value)
			{
				MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Đặt lại giá trị của datKetThuc thành giá trị trước đó
				datKetThuc2.Value = datBatDau2.Value;
			}
		}

		private void datKetThuc2_ValueChanged(object sender, EventArgs e)
		{
			// Kiểm tra xem datKetThuc có nhỏ hơn datBatDau không
			if (datBatDau2.Value > datKetThuc2.Value)
			{
				MessageBox.Show("Ngày bắt đầu nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Đặt lại giá trị của datKetThuc thành giá trị trước đó
				datBatDau2.Value = datKetThuc2.Value;
			}
		}

		private void btnBaoCao3_Click(object sender, EventArgs e)
		{
			string batDau = datBatDau2.Text;
			string ketThuc = datKetThuc2.Text;
			string maKH = cbbKhachHang.SelectedValue.ToString() ;
			string query = $"SELECT * FROM dbo.GetHoaDonAndTongTienByKhachHang('{maKH}', '{batDau}', '{ketThuc}')";

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
			string batDau = datBatDau2.Text;
			string ketThuc = datKetThuc2.Text;
			string maKH = cbbKhachHang.SelectedValue.ToString();

			string[] columnNames = { "Mã hóa đơn", "Ngày xuất", "Thuế VAT", "Trị giá", "Tổng tiền mua hàng" };
			title = $"Danh sách hoá đơn và tổng tiền mua hàng của một khách hàng theo quý chọn trước.";
			DataTable excel = dgvBaoCao.DataSource as DataTable;
			ExcelExportHelper.baoCaoTheoKho(excel, title, columnNames);
		}
	}
}
