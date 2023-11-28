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
	public partial class FormManHinhChinh : Form
	{
		public FormManHinhChinh()
		{
			InitializeComponent();
			customizeDesing();
		}
		private void customizeDesing()
		{
			panelDanhMucSubMenu.Visible = false;
			panelBaoCaoSubMenu.Visible = false;
		}

		private void hideSubMenu()
		{
			if (panelDanhMucSubMenu.Visible == true)
			{
				panelDanhMucSubMenu.Visible = false;
			} 
			if(panelBaoCaoSubMenu.Visible == true)
			{
				panelBaoCaoSubMenu.Visible = false;
			}
		}
		private void showSubMenu(Panel subMenu)
		{
			if(subMenu.Visible == false) {
				hideSubMenu();
				subMenu.Visible = true;
			}
			else subMenu.Visible = false;
		}
		#region DanhMuc
		private void btnDanhMuc_Click(object sender, EventArgs e)
		{
			showSubMenu(panelDanhMucSubMenu);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new FormNhapKho());
			hideSubMenu();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
		#endregion
		#region BaoCao
		private void btnBaoCao_Click(object sender, EventArgs e)
		{
			showSubMenu(panelBaoCaoSubMenu);
		}
		private void button11_Click(object sender, EventArgs e)
		{
			openChildForm(new FormVatTu());
			hideSubMenu();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			openChildForm(new FormBaoCao());
			hideSubMenu();
		}
		#endregion

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if(activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			openChildForm(new FormBaoCao2());
			hideSubMenu();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			openChildForm(new FormBaoCao3());
			hideSubMenu();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
