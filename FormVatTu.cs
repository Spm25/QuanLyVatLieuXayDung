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
    public partial class FormVatTu : Form
    {
		private readonly DatabaseConnector dbConnector;
		private DataTable dataTable;
		public FormVatTu()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormVatTu_Load(object sender, EventArgs e)
		{
			LoadComboBox();
		}

		private void LoadComboBox()
		{
			//Load combo box cho Kho
			string queryKho = "SELECT N'Toàn bộ' AS TenKho UNION SELECT TenKho FROM KhoHang";
			cbbKho.DataSource = dbConnector.ExecuteQuery(queryKho);
			cbbKho.DisplayMember = "TenKho";
			cbbKho.SelectedIndex = 0;

			//Load combo box cho NCC
			string queryNCC = "Select TenNhaCungCap From NhaCungCap";
			cbbNCC.DataSource = dbConnector.ExecuteQuery(queryNCC);
			cbbNCC.DisplayMember = "TenNhaCungCap";
			cbbNCC.SelectedIndex = 0;

			cbbKhoangGiaTri.SelectedIndex = 0;
			txtGiaTri2.ReadOnly = true;
			rdbTenVatTu.Checked = true;
			rdbSoLuong.Checked = true;
		}

		private void btnToanBo_Click(object sender, EventArgs e)
		{
			// Truy vấn dữ liệu từ bảng VatTu với các thông tin cần lấy
			

			// Thực hiện truy vấn và nhận DataTable
			//dataTable = dbConnector.ExecuteQuery(query);

			// Hiển thị dữ liệu trên DataGridView
			dgvVatTu.DataSource = dataTable;
		}

		private void btnKho_Click(object sender, EventArgs e)
		{
			string kho = cbbKho.Text;
			string query;
			if (kho == "Toàn bộ")
			{
				query = "SELECT vt.TenVatTu, dv.TenDonViTinh, vt.GiaNhap, ncc.TenNhaCungCap, SUM(ISNULL(ctkh.SoLuong, 0)) AS TongSoLuong " +
						   "FROM VatTu vt " +
						   "JOIN DonViTinh dv ON vt.MaDonViTinh = dv.MaDonViTinh " +
						   "JOIN NhaCungCap ncc ON vt.MaNhaCungCap = ncc.MaNhaCungCap " +
						   "LEFT JOIN ChiTietKhoHang ctkh ON vt.MaVatTu = ctkh.MaVatTu " +
						   "GROUP BY vt.TenVatTu, dv.TenDonViTinh, vt.GiaNhap, ncc.TenNhaCungCap;";
			}
			else
			{
				// Truy vấn dữ liệu từ bảng VatTu với các thông tin cần lấy
				query = "SELECT vt.TenVatTu, dv.TenDonViTinh, vt.GiaNhap, ncc.TenNhaCungCap, ctkh.SoLuong, kh.TenKho " +
							   "FROM VatTu vt " +
							   "JOIN DonViTinh dv ON vt.MaDonViTinh = dv.MaDonViTinh " +
							   "JOIN NhaCungCap ncc ON vt.MaNhaCungCap = ncc.MaNhaCungCap " +
							   "LEFT JOIN ChiTietKhoHang ctkh ON vt.MaVatTu = ctkh.MaVatTu " +
							   "JOIN KhoHang kh ON kh.MaKho = ctkh.MaKho " +
							   $"WHERE TenKho = '{kho}'"; // Sử dụng chuỗi tương tác để chèn giá trị biến kho
			}

			// Thực hiện truy vấn và nhận DataTable
			dataTable = dbConnector.ExecuteQuery(query);

			// Hiển thị dữ liệu trên DataGridView
			dgvVatTu.DataSource = dataTable;
		}

		private void cbbKhoangGiaTri_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Chỉ cho phép nhập số và một số ký tự đặc biệt như Backspace và Delete
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Chặn ký tự không hợp lệ
			}
		}

		private void rdbTenNhanVien_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbTenNCC.Checked == true) { 
				cbbNCC.Visible = true; 
				txtTimKiem.ReadOnly = true;
			}
			else { 
				cbbNCC.Visible = false;
				txtTimKiem.ReadOnly = false;
			}
			
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string tuKhoa = txtTimKiem.Text;
			string loaiTimKiem = "";
			string khoHang = "";

			if (rdbTenVatTu.Checked)
			{
				loaiTimKiem = "VatTu";
			}
			else if (rdbTenNCC.Checked)
			{
				loaiTimKiem = "TenNCC";
				khoHang = cbbNCC.Text; 
				txtTimKiem.Text = khoHang;
			}

			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				string query = "";
				switch (loaiTimKiem)
				{
					case "VatTu":
						query = $"TenVatTu LIKE '%{tuKhoa}%'";
						break;
					case "TenNCC":
						query = $"TenNhaCungCap = '{khoHang}'";
						break;
						// Thêm các trường hợp khác tùy theo nhu cầu
				}

				// Lọc và hiển thị kết quả trên DataGridView
				DataRow[] rows = dataTable.Select(query);
				dgvVatTu.DataSource = rows.Any() ? rows.CopyToDataTable() : dataTable.Clone();
				if (dgvVatTu.RowCount == 1)
				{
					MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				// Xử lý trường hợp dataTable là null hoặc không có dữ liệu
				MessageBox.Show("Không có dữ liệu để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void cbbKhoangGiaTri_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbbKhoangGiaTri.SelectedIndex == 2) { 
				txtGiaTri2.ReadOnly = false;
			}
			else { txtGiaTri2.ReadOnly = true;}
		}

		private void btnTimKiemTheoGiaTri_Click(object sender, EventArgs e)
		{
			if (dgvVatTu.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string selectedRadioButton = rdbSoLuong.Checked ? "SoLuong" : "GiaNhap";
			string selectedComboBoxItem = cbbKhoangGiaTri.SelectedItem.ToString();
			string value1 = txtGiaTri1.Text;
			string value2 = txtGiaTri2.Text;

			DataTable dataTable = (DataTable)dgvVatTu.DataSource;

			string filterExpression = "";

			switch (selectedComboBoxItem)
			{
				case "Lớn hơn":
					filterExpression = $"{selectedRadioButton} > {value1}";
					break;
				case "Nhỏ hơn":
					filterExpression = $"{selectedRadioButton} < {value1}";
					break;
				case "Trong khoảng":
					filterExpression = $"{selectedRadioButton} BETWEEN '{value1}' AND '{value2}'";
					break;
				case "Bằng":
					filterExpression = $"{selectedRadioButton} = {value1}";
					break;
				default:
					// Handle other cases or show an error message
					break;
			}

			dataTable.DefaultView.RowFilter = filterExpression;
		}
	}
}
