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
		public FormNhapKho()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormNhapKho_Load(object sender, EventArgs e)
		{
			// Load dữ liệu cho DataGridView
			string queryChiTietNhapKho = @"
											SELECT NhapKho.MaHoaDon, NhapKho.NgayNhap, NhapKho.TongTien,
												   KhoHang.TenKho, NhaCungCap.TenNhaCungCap, NhanVien.TenNhanVien
											FROM NhapKho
											JOIN KhoHang ON NhapKho.MaKho = KhoHang.MaKho
											JOIN NhaCungCap ON NhapKho.MaNhaCungCap = NhaCungCap.MaNhaCungCap
											JOIN NhanVien ON NhapKho.MaNhanVien = NhanVien.MaNhanVien";
			dgvNhapHang.DataSource = dbConnector.ExecuteQuery(queryChiTietNhapKho);
			LoadComboBoxData();
			//Load dữ liệu cho tài khoản
			Account currentAccount = AccountManager.Instance.CurrentAccount;
			if (currentAccount != null)
			{
				lbTen.Text = currentAccount.name;
				maNV = currentAccount.maNV;
			}
		}
		private void LoadComboBoxData()
		{
			// Load dữ liệu cho ComboBox Kho
			string queryKho = "SELECT MaKho, TenKho FROM KhoHang";
			ccbKho.DataSource = dbConnector.ExecuteQuery(queryKho);
			ccbKho.DisplayMember = "TenKho";
			ccbKho.ValueMember = "MaKho";

			// Load dữ liệu cho ComboBox Nhà cung cấp
			string queryNhaCungCap = "SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap";
			ccbNhaCungCap.DataSource = dbConnector.ExecuteQuery(queryNhaCungCap);
			ccbNhaCungCap.DisplayMember = "TenNhaCungCap";
			ccbNhaCungCap.ValueMember = "MaNhaCungCap";

			ccbKho.Text = "";
			ccbNhaCungCap.Text = "";
		}
		private void FormNhapKho_FormClosing(object sender, FormClosingEventArgs e)
		{
			dbConnector.Dispose();
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
			if (ccbKho.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn kho");
				return false;
			}

			// Kiểm tra ComboBox Nhà cung cấp
			if (ccbNhaCungCap.SelectedIndex == -1)
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
		//private void RefreshData()
		//{
		//	// Làm mới DataGridView
		//	LoadDataGridView();

		//	// Làm mới các controls khác
		//	// ...

		//	// Xóa các dữ liệu đang hiển thị trong TextBox và các controls khác
		//	txtMaHoaDon.Text = "";
		//	// ...
		//}
		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kiểm tra dữ liệu nhập
			if (!KiemTraDuLieuNhap())
			{
				return;
			}
			// Lấy mã kho và mã nhà cung cấp từ ComboBox
			string maKho = ccbKho.SelectedValue.ToString();
			string maNCC = ccbNhaCungCap.SelectedValue.ToString();
			
			// Lấy mã hóa đơn từ TextBox
			string maHoaDon = txtMaHoaDon.Text.Trim();

			// Lấy ngày nhập từ DateTimePicker
			DateTime ngayNhap = datNgayNhap.Value;

			// Kiểm tra các giá trị cần thiết trước khi thêm vào database
			if (string.IsNullOrEmpty(maHoaDon))
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn");
				return;
			}

			// Thực hiện thêm dữ liệu vào database
			string queryThem = $@"
					INSERT INTO NhapKho (MaHoaDon, NgayNhap, MaNhaCungCap, MaKho, MaNhanVien)
					VALUES ('{maHoaDon}', '{ngayNhap.ToString("yyyy-MM-dd")}', '{maNCC}', '{maKho}', '{maNV}')";

			// Thực hiện thêm dữ liệu bằng DatabaseConnector
			int rowsAffected = dbConnector.ExecuteNonQuery(queryThem);

			// Kiểm tra xem dữ liệu có được thêm thành công không
			if (rowsAffected > 0)
			{
				// Thông báo thành công hoặc thực hiện các hành động cần thiết
				MessageBox.Show("Thêm dữ liệu thành công");
			}
			else
			{
				// Thông báo lỗi hoặc thực hiện các hành động cần thiết
				MessageBox.Show("Không thể thêm dữ liệu");
			}

			// Cập nhật DataGridView hoặc thực hiện các hành động cần thiết khác
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Lấy mã hóa đơn từ TextBox
			string maHoaDon = txtMaHoaDon.Text;

			// Kiểm tra xem mã hóa đơn có giá trị không
			if (!string.IsNullOrEmpty(maHoaDon))
			{
				// Xác nhận xóa với người dùng trước khi thực hiện
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					// Nếu người dùng đồng ý, thực hiện truy vấn DELETE
					string queryXoa = $"DELETE FROM NhapKho WHERE MaHoaDon = '{maHoaDon}'";

					// Thực hiện truy vấn DELETE
					int rowsAffected = dbConnector.ExecuteNonQuery(queryXoa);

					// Kiểm tra xem có bản ghi nào được xóa không
					if (rowsAffected > 0)
					{
						MessageBox.Show("Xóa thành công.");

						// Sau khi xóa, làm mới DataGridView và các controls khác
						//RefreshData();
					}
					else
					{
						MessageBox.Show("Không tìm thấy bản ghi để xóa.");
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa.");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Lấy thông tin từ các controls
			string maHoaDon = txtMaHoaDon.Text;
			DateTime ngayNhap = datNgayNhap.Value;
			string maKho = ccbKho.SelectedValue.ToString();
			string maNhaCungCap = ccbNhaCungCap.SelectedValue.ToString();

			// Kiểm tra xem các giá trị có hợp lệ không
			if (!string.IsNullOrEmpty(maHoaDon) && ngayNhap != DateTime.MinValue && !string.IsNullOrEmpty(maKho) && !string.IsNullOrEmpty(maNhaCungCap))
			{
				// Xác nhận với người dùng trước khi thực hiện
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					// Nếu người dùng đồng ý, thực hiện truy vấn UPDATE
					string querySua = $"UPDATE NhapKho SET NgayNhap = '{ngayNhap:yyyy-MM-dd}', MaKho = '{maKho}', MaNhaCungCap = '{maNhaCungCap}', MaNhanVien = '{maNV}' WHERE MaHoaDon = '{maHoaDon}'";

					// Thực hiện truy vấn UPDATE
					int rowsAffected = dbConnector.ExecuteNonQuery(querySua);

					// Kiểm tra xem có bản ghi nào được cập nhật không
					if (rowsAffected > 0)
					{
						MessageBox.Show("Cập nhật thành công.");

						// Sau khi cập nhật, làm mới DataGridView và các controls khác
						//RefreshData();
					}
					else
					{
						MessageBox.Show("Không tìm thấy bản ghi để cập nhật.");
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần cập nhật.");
			}
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{

		}

		private void dgvNhapHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem có dòng nào được chọn hay không
			if (e.RowIndex >= 0)
			{
				// Lấy dữ liệu từ cell của dòng được chọn
				DataGridViewRow selectedRow = dgvNhapHang.Rows[e.RowIndex];

				// Đưa dữ liệu vào các TextBox và ComboBox
				txtMaHoaDon.Text = selectedRow.Cells["MaHoaDon"].Value.ToString();

				// Lấy giá trị của cột MaKho từ cell
				string tenKho = selectedRow.Cells["TenKho"].Value.ToString();

				// Set giá trị của ComboBox Kho
				ccbKho.SelectedValue = tenKho;

				// Lấy giá trị của cột MaNhaCungCap từ cell
				string tenNhaCungCap = selectedRow.Cells["TenNhaCungCap"].Value.ToString();

				// Set giá trị của ComboBox Nhà cung cấp
				ccbNhaCungCap.SelectedValue = tenNhaCungCap;

				string ngayNhapString = selectedRow.Cells["NgayNhap"].Value.ToString();
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

	}
}
