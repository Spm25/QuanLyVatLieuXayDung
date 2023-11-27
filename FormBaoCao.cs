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
    public partial class FormBaoCao : Form
    {
		private readonly DatabaseConnector dbConnector;
		private DataTable dataTable;
		public FormBaoCao()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormBaoCao_Load(object sender, EventArgs e)
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

			//Load combo box cho Khách hàng
			string queryKhachHang = "Select TenKhachHang, MaKhachHang From KhachHang";
			cbbKhachHang.DataSource = dbConnector.ExecuteQuery(queryKhachHang);
			cbbKhachHang.DisplayMember = "TenKhachHang";
			cbbKhachHang.ValueMember = "MaKhachHang";
			cbbKhachHang.SelectedIndex = 0;
			
			cbbLoai.SelectedIndex = 0;
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

		private void datKetThuc_ValueChanged(object sender, EventArgs e)
		{
			// Kiểm tra xem datKetThuc có nhỏ hơn datBatDau không
			if (datKetThuc.Value < datBatDau.Value)
			{
				MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Đặt lại giá trị của datKetThuc thành giá trị trước đó
				datKetThuc.Value = datBatDau.Value;
			}

		}

		private void datBatDau_ValueChanged(object sender, EventArgs e)
		{
			// Kiểm tra xem datKetThuc có nhỏ hơn datBatDau không
			if (datBatDau.Value > datKetThuc.Value)
			{
				MessageBox.Show("Ngày bắt đầu nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Đặt lại giá trị của datKetThuc thành giá trị trước đó
				datBatDau.Value = datKetThuc.Value;
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

		private void btnBaoCao1_Click(object sender, EventArgs e)
		{
			string batDau = datBatDau.Text;
			string ketThuc = datKetThuc.Text;
			string loai = cbbLoai.Text == "Đã bán" ? "SanPhamBanDuoc " : "SanPhamKhongBanDuoc";
			string query = $"SELECT * FROM {loai}('{batDau}', '{ketThuc}')";

			dataTable = dbConnector.ExecuteQuery(query) ;
			dgvBaoCao.DataSource = dataTable ;
			if (dgvBaoCao.RowCount == 1)
			{
				MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
	}
}
