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
    public partial class FormNhapKho : Form
    {
		private readonly DatabaseConnector dbConnector;
		private string maNV;
		private DataTable dataTable;
		public FormNhapKho()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormNhapKho_Load(object sender, EventArgs e)
		{
			// Load dữ liệu cho DataGridView
			LoadDataTable();
			// Load dữ liệu cho Combo Box
			LoadComboBoxData();
			//// Load màu cho Button
			//LoadButtonColor();
			//Load dữ liệu cho tài khoản
			Account currentAccount = AccountManager.Instance.CurrentAccount;
			if (currentAccount != null)
			{
				lbTen.Text = currentAccount.name;
				maNV = currentAccount.maNV;
			}
		}

		private void LoadButtonColor() {
			btnXoa.BackColor = Color.Gray;
			btnSua.BackColor = Color.Gray;
		}

		private bool KiemTraDuLieuNhap()
		{
			// Kiểm tra mã hóa đơn
			if (string.IsNullOrEmpty(txtMaHoaDon.Text.Trim()))
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn");
				return false;
			}

			// Kiểm tra ComboBox Kho
			if (cbbKho.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn kho");
				return false;
			}

			// Kiểm tra ComboBox Nhà cung cấp
			if (cbbNhaCungCap.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn nhà cung cấp");
				return false;
			}

			// Kiểm tra ngày nhập
			if (datNgayNhap.Value > DateTime.Now)
			{
				MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại");
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
			txtMaHoaDon.Text = "";
			cbbKho.SelectedIndex = -1;
			cbbNhaCungCap.SelectedIndex = -1;
			lbTongTien.Text = "0";
		}
		private void LoadDataTable()
		{
			string queryChiTietNhapKho = @"SELECT * FROM NhapKho";
			dataTable = dbConnector.ExecuteQuery(queryChiTietNhapKho);
			dgvNhapHang.DataSource = dataTable;
		}
		private void LoadComboBoxData()
		{
			// Load dữ liệu cho ComboBox Kho
			string queryKho = "SELECT MaKho, TenKho FROM KhoHang";
			cbbKho.DataSource = dbConnector.ExecuteQuery(queryKho);
			cbbKho.DisplayMember = "TenKho";
			cbbKho.ValueMember = "MaKho";

			// Load dữ liệu cho ComboBox Nhà cung cấp
			string queryNhaCungCap = "SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap";
			cbbNhaCungCap.DataSource = dbConnector.ExecuteQuery(queryNhaCungCap);
			cbbNhaCungCap.DisplayMember = "TenNhaCungCap";
			cbbNhaCungCap.ValueMember = "MaNhaCungCap";

			cbbKho.Text = "";
			cbbNhaCungCap.Text = "";

			rdbMaHang.Checked = true;
		}
		private void FormNhapKho_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Thực hiện các bước lưu dữ liệu (gọi btnLuu.PerformClick() để kích hoạt sự kiện btnLuu)
				dbConnector.UpdateDataTable(dataTable, "NhapKho");
			}
			else if (result == DialogResult.Cancel)
			{
				// Hủy sự kiện đóng form nếu người dùng chọn Cancel
				e.Cancel = true;
			}

			// Dispose dbConnector khi form đóng
			dbConnector.Dispose();
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!KiemTraDuLieuNhap())
			{
				return;
			}

			// Lấy dữ liệu từ các controls
			string maHoaDon = txtMaHoaDon.Text.Trim();
			DateTime ngayNhap = datNgayNhap.Value;
			string maKho = cbbKho.SelectedValue.ToString();
			string maNCC = cbbNhaCungCap.SelectedValue.ToString();
			int.TryParse(lbTongTien.Text, out int tongTien); 

			DataRow[] existingRows = dataTable.Select($"MaHoaDon = '{maHoaDon}'");
			if (existingRows.Length > 0)
			{
				MessageBox.Show($"Mã hóa đơn {maHoaDon} đã tồn tại. Vui lòng chọn một mã hóa đơn khác.");
				return;
			}

			// Thêm dữ liệu vào DataTable
			DataRow newRow = dataTable.NewRow();
			newRow["MaHoaDon"] = maHoaDon;
			newRow["NgayNhap"] = ngayNhap;
			newRow["MaKho"] = maKho;
			newRow["MaNhaCungCap"] = maNCC;
			newRow["MaNhanVien"] = maNV;
			newRow["TongTien"] = tongTien; // Cập nhật giá trị này theo logic của bạn

			MessageBox.Show($"Đã thêm Hóa đơn {maHoaDon} vào bảng tạm. Hãy kiểm tra lại và lưu vào database khi chắc chắn.");

			// Thêm dòng mới vào DataTable
			dataTable.Rows.Add(newRow);

			// Làm mới các controls
			RefreshData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			//bool isAdmin = AccountManager.Instance.CurrentAccount.isAdmin;
			//if(isAdmin == false) {
			//	MessageBox.Show("Không tìm thấy bản ghi để xóa trong DataTable.");
			//	return; 
			//}

			string maHoaDon = txtMaHoaDon.Text;

			if (!string.IsNullOrEmpty(maHoaDon))
			{
				// Tìm dòng cần xóa trong DataTable
				DataRow rowToDelete = dataTable.Select($"MaHoaDon = '{maHoaDon}'").FirstOrDefault();

				if (rowToDelete != null)
				{
					// Hiển thị hộp thoại xác nhận trước khi xóa
					DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa Hóa đơn {maHoaDon} không?",
														  "Xác nhận xóa",
														  MessageBoxButtons.YesNo,
														  MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						// Đánh dấu dòng để xóa
						rowToDelete.Delete();

						MessageBox.Show($"Đã xóa Hóa đơn {maHoaDon} ở bảng tạm. Hãy kiểm tra lại và lưu vào database khi chắc chắn.");

						// Làm mới các controls
						RefreshData();
					}
				}
				else
				{
					MessageBox.Show("Không tìm thấy bản ghi để xóa trong DataTable.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa.");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			//bool isAdmin = AccountManager.Instance.CurrentAccount.isAdmin;
			//if (isAdmin == false)
			//{
			//	MessageBox.Show("Không tìm thấy bản ghi để xóa trong DataTable.");
			//	return;
			//}

			string maHoaDon = txtMaHoaDon.Text;

			if (!string.IsNullOrEmpty(maHoaDon))
			{
				// Tìm dòng cần sửa trong DataTable
				DataRow rowToUpdate = dataTable.Select($"MaHoaDon = '{maHoaDon}'").FirstOrDefault();

				if (rowToUpdate != null)
				{
					// Hiển thị hộp thoại xác nhận trước khi xóa
					DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa Hóa đơn {maHoaDon} không?",
														  "Xác nhận sửa",
														  MessageBoxButtons.YesNo,
														  MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						// Cập nhật dữ liệu trong DataRow
						rowToUpdate["NgayNhap"] = datNgayNhap.Value;
						rowToUpdate["MaKho"] = cbbKho.SelectedValue.ToString();
						rowToUpdate["MaNhaCungCap"] = cbbNhaCungCap.SelectedValue.ToString();

						MessageBox.Show($"Đã sửa mã hóa đơn {maHoaDon} ở bảng tạm. Hãy kiểm tra lại và lưu vào database khi chắc chắn.");

						// Làm mới các controls
						RefreshData();
					}
					
				}
				else
				{
					MessageBox.Show("Không tìm thấy bản ghi để cập nhật trong DataTable.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn cần cập nhật.");
			}
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{
			if (!KiemTraDuLieuNhap())
			{
				return;
			}

			FormChiTietNhapKho formChiTietNhapKho = new FormChiTietNhapKho(txtMaHoaDon.Text,
																			datNgayNhap.Text,
																			cbbNhaCungCap.Text,
																			cbbKho.Text, 
																			lbTongTien.Text, 
																			lbTen.Text);
			formChiTietNhapKho.ShowDialog();
		}

		private void dgvNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem có dòng nào được chọn hay không
			if (e.RowIndex >= 0)
			{
				// Lấy dữ liệu từ cell của dòng được chọn
				DataGridViewRow selectedRow = dgvNhapHang.Rows[e.RowIndex];

				// Đưa dữ liệu vào các TextBox và ComboBox
				txtMaHoaDon.Text = selectedRow.Cells["MaHoaDon"].Value.ToString();

				// Lấy giá trị của cột MaKho từ cell
				string maKho = selectedRow.Cells["MaKho"].Value.ToString();

				// Set giá trị của ComboBox Kho
				cbbKho.SelectedValue = maKho;

				// Lấy giá trị của cột MaNhaCungCap từ cell
				string maNhaCungCap = selectedRow.Cells["MaNhaCungCap"].Value.ToString();

				// Set giá trị của ComboBox Nhà cung cấp
				cbbNhaCungCap.SelectedValue = maNhaCungCap;

				string ngayNhapString = selectedRow.Cells["NgayNhap"].Value.ToString();

				lbTongTien.Text = selectedRow.Cells["TongTien"].Value.ToString();

				DateTime ngayNhap;

				if (DateTime.TryParse(ngayNhapString, out ngayNhap))
				{
					// Chuyển đổi thành công, đặt giá trị vào datNgayNhap
					datNgayNhap.Value = ngayNhap;
				}
				else
				{
					// Xử lý trường hợp không chuyển đổi được giá trị sang kiểu DateTime
					MessageBox.Show("Không thể chuyển đổi giá trị NgayNhap sang kiểu DateTime.");
				}
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				dbConnector.UpdateDataTable(dataTable, "NhapKho");
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
			RefreshData();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string tuKhoa = txtTimKiem.Text;
			if(tuKhoa.Trim() == string.Empty)
			{
				dgvNhapHang.DataSource = dataTable;
				return;
			}
			string loaiTimKiem = "";

			if (rdbMaHang.Checked)
			{
				loaiTimKiem = "MaHang";
			}
			else if (rdbNgayNhap.Checked)
			{
				loaiTimKiem = "NgayNhap";
			}
			else if (rdbMaKho.Checked)
			{
				loaiTimKiem = "MaKho";
			}

			string query = "";
			switch (loaiTimKiem)
			{
				case "MaHang":
					query = $"MaHoaDon LIKE '%{tuKhoa}%'";
					break;
				case "NgayNhap":
					DateTime mt;
					if (DateTime.TryParse(tuKhoa, out mt) == false) { 
						MessageBox.Show("Định dạng ngày không đúng. Hãy sửa theo định dạng (dd/mm/yyyy).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					query = $"NgayNhap = '{tuKhoa}'";
					break;
				case "MaKho":
					query = $"MaKho LIKE '%{tuKhoa}%'";
					break;
					// Thêm các trường hợp khác tùy theo nhu cầu
			}

			DataRow[] rows = dataTable.Select(query);
			dgvNhapHang.DataSource = rows.Any() ? rows.CopyToDataTable() : dataTable.Clone();
			if (dgvNhapHang.RowCount == 1)
			{
				MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
		{
			lbTongTien.Text = "0";
		}
	}
}
