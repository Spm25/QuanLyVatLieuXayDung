﻿using System;
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
	public partial class FormDangNhap : Form
	{
		public FormDangNhap()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string password = txtPassword.Text;

			DatabaseConnector dbConnector = new DatabaseConnector();
			Account account = dbConnector.CheckLogin(userName, password);

			if (account != null)
			{
				// Lưu thông tin tài khoản vào AccountManager
				AccountManager.Instance.CurrentAccount = account;

				// Tài khoản hợp lệ, chuyển sang FormNhapHang và truyền thông tin tài khoản
				FormManHinhChinh formManHinh = new FormManHinhChinh();
				this.Hide();
				formManHinh.ShowDialog();
				this.Close();
			}
			else
			{
				txtPassword.Text = string.Empty;
				txtUserName.Text = string.Empty;
				MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
