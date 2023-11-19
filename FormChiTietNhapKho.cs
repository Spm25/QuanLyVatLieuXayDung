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
    public partial class FormChiTietNhapKho : Form
    {
		private readonly DatabaseConnector dbConnector;
		private string maNV;
		private DataTable dataTable;
		public FormChiTietNhapKho()
		{
			InitializeComponent();
			dbConnector = new DatabaseConnector();
		}
		public FormChiTietNhapKho(string maHoaDon, string ngayNhap, string tenNCC, string kho, string tongTien, string tenNV)
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();

			lbMaHoaDon.Text = maHoaDon;
			lbNgayNhap.Text = ngayNhap;
			lbTenNhaCungCap.Text = tenNCC;
			lbKho.Text = kho;
			lbTongTien.Text = tongTien;
			lbTen.Text = tenNV;
		}

		private void FormChiTietNhapKho_Load(object sender, EventArgs e)
		{
			// Load dữ liệu cho DataGridView
			LoadDataTable();
			//Load dữ liệu cho tài khoản
			Account currentAccount = AccountManager.Instance.CurrentAccount;
			if (currentAccount != null)
			{
				lbTen.Text = currentAccount.name;
				maNV = currentAccount.maNV;
			}
		}
		private void UpdateThanhTien()
		{
			if (int.TryParse(txtSoLuong.Text, out int soLuong) &&
				decimal.TryParse(txtDonGiaNhap.Text, out decimal donGiaNhap))
			{
				decimal thanhTien = soLuong * donGiaNhap;
				lbThanhTien.Text = thanhTien.ToString() + 'đ'; 
			}
			else
			{
				lbThanhTien.Text = "0đ";
			}
		}
		private bool KiemTraDuLieuNhap()
		{
			// Kiểm tra mã hóa đơn
			if (string.IsNullOrEmpty(txtMaVatTu.Text.Trim()))
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn");
				return false;
			}

			// Kiểm tra số lượng
			if (string.IsNullOrEmpty(txtSoLuong.Text.Trim()) || !int.TryParse(txtSoLuong.Text, out _))
			{
				MessageBox.Show("Vui lòng nhập số lượng hợp lệ");
				return false;
			}

			// Kiểm tra đơn giá nhập
			if (string.IsNullOrEmpty(txtDonGiaNhap.Text.Trim()) || !decimal.TryParse(txtDonGiaNhap.Text, out _))
			{
				MessageBox.Show("Vui lòng nhập đơn giá nhập hợp lệ");
				return false;
			}

			// Nếu tất cả kiểm tra đều thành công
			return true;
		}
		private void RefreshData()
		{
			// Làm mới DataGridView
			dgvNhapHang.DataSource = dataTable;

			// Làm mới các controls khác
			// ...

			// Xóa các dữ liệu đang hiển thị trong TextBox và các controls khác
			txtMaVatTu.Text = "";
			txtSoLuong.Text = "";
			txtDonGiaNhap.Text = "";
			lbThanhTien.Text = "0đ";
		}
		private void LoadDataTable()
		{
			string queryChiTietNhapKho = @"SELECT * FROM ChiTietNhapKho";
			dataTable = dbConnector.ExecuteQuery(queryChiTietNhapKho);
			dgvNhapHang.DataSource = dataTable;
		}
		
		private void FormChiTietNhapKho_FormClosing(object sender, FormClosingEventArgs e)
		{
			dbConnector.Dispose();
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!KiemTraDuLieuNhap())
			{
				return;
			}

			// Lấy dữ liệu từ các controls
			string maVatTu = txtMaVatTu.Text.Trim();
			string maHoaDon = lbMaHoaDon.Text.Trim();
			int soLuong = int.Parse(txtSoLuong.Text);
			decimal donGiaNhap = decimal.Parse(txtDonGiaNhap.Text);
			decimal thanhTien = soLuong * donGiaNhap; // Tính toán thành tiền

			DataRow[] existingRows = dataTable.Select($"MaVatTu = '{maVatTu}' AND MaHoaDon = '{maHoaDon}'");
			if (existingRows.Length > 0)
			{
				MessageBox.Show("Mã vật tư đã tồn tại. Vui lòng chọn một mã hóa đơn khác.");
				return;
			}

			// Thêm dữ liệu vào DataTable
			DataRow newRow = dataTable.NewRow();
			newRow["MaVatTu"] = maVatTu;
			newRow["MaHoaDon"] = maHoaDon;
			newRow["SoLuong"] = soLuong;
			newRow["DonGiaNhap"] = donGiaNhap;
			newRow["ThanhTien"] = thanhTien;
			

			// Thêm dòng mới vào DataTable
			dataTable.Rows.Add(newRow);

			// Làm mới các controls
			RefreshData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string maVatTu = txtMaVatTu.Text;

			if (!string.IsNullOrEmpty(maVatTu))
			{
				// Tìm dòng cần xóa trong DataTable
				DataRow rowToDelete = dataTable.Select($"MaVatTu = '{maVatTu}'").FirstOrDefault();

				if (rowToDelete != null)
				{
					// Đánh dấu dòng để xóa
					rowToDelete.Delete();

					// Làm mới các controls
					RefreshData();
				}
				else
				{
					MessageBox.Show("Không tìm thấy bản ghi để xóa trong DataTable.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã vật tư cần xóa.");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string maVatTu = txtMaVatTu.Text;
			string maHoaDon = lbMaHoaDon.Text;

			if (!string.IsNullOrEmpty(maVatTu))
			{
				// Tìm dòng cần sửa trong DataTable
				DataRow rowToUpdate = dataTable.Select($"MaVatTu = '{maVatTu}' AND MaHoaDon = '{maHoaDon}'").FirstOrDefault();

				if (rowToUpdate != null)
				{
					// Cập nhật dữ liệu trong DataRow
					rowToUpdate["SoLuong"] = int.Parse(txtSoLuong.Text);
					rowToUpdate["DonGiaNhap"] = decimal.Parse(txtDonGiaNhap.Text);
					rowToUpdate["ThanhTien"] = int.Parse(txtSoLuong.Text) * decimal.Parse(txtDonGiaNhap.Text);

					// Làm mới các controls
					RefreshData();
				}
				else
				{
					MessageBox.Show("Không tìm thấy bản ghi để cập nhật trong DataTable.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã vật tư cần cập nhật.");
			}
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{
				// Hiển thị kết quả tìm kiếm trên DataGridView hoặc các controls khác tùy vào thiết kế giao diện của bạn
		}

		private void dgvNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem có dòng nào được chọn hay không
			if (e.RowIndex >= 0)
			{
				// Lấy dữ liệu từ cell của dòng được chọn
				DataGridViewRow selectedRow = dgvNhapHang.Rows[e.RowIndex];

				// Đưa dữ liệu vào các TextBox và Label
				txtMaVatTu.Text = selectedRow.Cells["MaVatTu"].Value.ToString();

				// Lấy giá trị của cột SoLuong từ cell
				string soLuong = selectedRow.Cells["SoLuong"].Value.ToString();

				// Set giá trị của TextBox SoLuong
				txtSoLuong.Text = soLuong;

				// Lấy giá trị của cột DonGiaNhap từ cell
				string donGiaNhap = selectedRow.Cells["DonGiaNhap"].Value.ToString();

				// Set giá trị của TextBox DonGiaNhap
				txtDonGiaNhap.Text = donGiaNhap;

				// Tính giá trị của ThanhTien
				string thanhTien = selectedRow.Cells["ThanhTien"].Value.ToString();

				// Hiển thị giá trị ThanhTien trong Label
				lbThanhTien.Text = thanhTien + "đ";
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				dbConnector.UpdateDataTable(dataTable, "ChiTietNhapKho");
				MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			LoadDataTable();
		}

		private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
		{
			UpdateThanhTien();
		}

		private void txtSoLuong_TextChanged(object sender, EventArgs e)
		{
			UpdateThanhTien();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string tuKhoa = txtTimKiem.Text;
			string loaiTimKiem = "";

			if (rdbHoaDon.Checked)
			{
				loaiTimKiem = "HoaDon";
			}
			else if (rdbVatTu.Checked)
			{
				loaiTimKiem = "VatTu";
			}

			string query = "";
			switch (loaiTimKiem)
			{
				case "HoaDon":
					query = $"SELECT * FROM ChiTietNhapKho WHERE MaHoaDon LIKE '%{tuKhoa}%'";
					break;
				case "VatTu":
					query = $"SELECT * FROM ChiTietNhapKho WHERE MaVatTu LIKE '%{tuKhoa}%'";
					break;
			}

			dgvNhapHang.DataSource = dbConnector.ExecuteQuery(query);


		}
	}
}
