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
			datNgayNhap.Text = "";
		}
		private void FormNhapKho_FormClosing(object sender, FormClosingEventArgs e)
		{
			dbConnector.Dispose();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnSua_Click(object sender, EventArgs e)
		{

		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{

		}
	}
}
