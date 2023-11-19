namespace QuanLyVatLieuXayDung
{
    partial class FormNhapKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.datNgayNhap = new System.Windows.Forms.DateTimePicker();
			this.ccbKho = new System.Windows.Forms.ComboBox();
			this.ccbNhaCungCap = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaHoaDon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbTen = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnNhapHang = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dgvNhapHang = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rdbMaKho = new System.Windows.Forms.RadioButton();
			this.rdbNgayNhap = new System.Windows.Forms.RadioButton();
			this.rdbMaHang = new System.Windows.Forms.RadioButton();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(123, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(984, 380);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(350, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thêm hóa đơn nhập";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.datNgayNhap);
			this.groupBox2.Controls.Add(this.ccbKho);
			this.groupBox2.Controls.Add(this.ccbNhaCungCap);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtMaHoaDon);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.lbTongTien);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lbTen);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(6, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(972, 313);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cập nhật hóa đơn hàng";
			// 
			// datNgayNhap
			// 
			this.datNgayNhap.CustomFormat = "dd / MM / yyyy";
			this.datNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datNgayNhap.Location = new System.Drawing.Point(681, 71);
			this.datNgayNhap.Name = "datNgayNhap";
			this.datNgayNhap.Size = new System.Drawing.Size(166, 27);
			this.datNgayNhap.TabIndex = 3;
			this.datNgayNhap.Value = new System.DateTime(2023, 1, 12, 0, 0, 0, 0);
			// 
			// ccbKho
			// 
			this.ccbKho.FormattingEnabled = true;
			this.ccbKho.Location = new System.Drawing.Point(681, 155);
			this.ccbKho.Name = "ccbKho";
			this.ccbKho.Size = new System.Drawing.Size(105, 28);
			this.ccbKho.TabIndex = 2;
			// 
			// ccbNhaCungCap
			// 
			this.ccbNhaCungCap.FormattingEnabled = true;
			this.ccbNhaCungCap.Location = new System.Drawing.Point(266, 152);
			this.ccbNhaCungCap.Name = "ccbNhaCungCap";
			this.ccbNhaCungCap.Size = new System.Drawing.Size(165, 28);
			this.ccbNhaCungCap.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(562, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ngày nhập:";
			// 
			// txtMaHoaDon
			// 
			this.txtMaHoaDon.Location = new System.Drawing.Point(266, 68);
			this.txtMaHoaDon.Name = "txtMaHoaDon";
			this.txtMaHoaDon.Size = new System.Drawing.Size(165, 27);
			this.txtMaHoaDon.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(562, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Kho:";
			// 
			// lbTongTien
			// 
			this.lbTongTien.AutoSize = true;
			this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTongTien.Location = new System.Drawing.Point(226, 234);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(18, 20);
			this.lbTongTien.TabIndex = 0;
			this.lbTongTien.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(118, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tổng tiền:";
			// 
			// lbTen
			// 
			this.lbTen.AutoSize = true;
			this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTen.Location = new System.Drawing.Point(678, 234);
			this.lbTen.Name = "lbTen";
			this.lbTen.Size = new System.Drawing.Size(37, 20);
			this.lbTen.TabIndex = 0;
			this.lbTen.Text = "Tên";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(562, 234);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Nhân viên:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(118, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nhà cung cấp:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(118, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã hóa đơn:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnNhapHang);
			this.groupBox3.Controls.Add(this.btnHuy);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnLuu);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.groupBox3.Location = new System.Drawing.Point(1127, 31);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(204, 380);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức năng";
			// 
			// btnNhapHang
			// 
			this.btnNhapHang.Font = new System.Drawing.Font("Roboto Slab", 12F);
			this.btnNhapHang.Location = new System.Drawing.Point(19, 196);
			this.btnNhapHang.Name = "btnNhapHang";
			this.btnNhapHang.Size = new System.Drawing.Size(158, 43);
			this.btnNhapHang.TabIndex = 0;
			this.btnNhapHang.Text = "Nhập hàng";
			this.btnNhapHang.UseVisualStyleBackColor = true;
			this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Roboto Slab", 12F);
			this.btnHuy.Image = global::QuanLyVatLieuXayDung.Properties.Resources.cancel;
			this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHuy.Location = new System.Drawing.Point(19, 315);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(158, 43);
			this.btnHuy.TabIndex = 0;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Roboto Slab", 12F);
			this.btnSua.Image = global::QuanLyVatLieuXayDung.Properties.Resources.edit;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(19, 138);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(158, 43);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Roboto Slab", 12F);
			this.btnLuu.Image = global::QuanLyVatLieuXayDung.Properties.Resources.check;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(19, 255);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(158, 43);
			this.btnLuu.TabIndex = 0;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Roboto Slab", 12F);
			this.btnXoa.Image = global::QuanLyVatLieuXayDung.Properties.Resources.delete;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(19, 85);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(158, 43);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::QuanLyVatLieuXayDung.Properties.Resources.add;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(19, 32);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(158, 43);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dgvNhapHang
			// 
			this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhapHang.Location = new System.Drawing.Point(123, 505);
			this.dgvNhapHang.Name = "dgvNhapHang";
			this.dgvNhapHang.RowHeadersWidth = 51;
			this.dgvNhapHang.RowTemplate.Height = 24;
			this.dgvNhapHang.Size = new System.Drawing.Size(1208, 319);
			this.dgvNhapHang.TabIndex = 2;
			this.dgvNhapHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellDoubleClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdbMaKho);
			this.groupBox4.Controls.Add(this.rdbNgayNhap);
			this.groupBox4.Controls.Add(this.rdbMaHang);
			this.groupBox4.Controls.Add(this.btnTimKiem);
			this.groupBox4.Controls.Add(this.txtTimKiem);
			this.groupBox4.Location = new System.Drawing.Point(123, 411);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1208, 88);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// rdbMaKho
			// 
			this.rdbMaKho.AutoSize = true;
			this.rdbMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbMaKho.Location = new System.Drawing.Point(1023, 37);
			this.rdbMaKho.Name = "rdbMaKho";
			this.rdbMaKho.Size = new System.Drawing.Size(87, 24);
			this.rdbMaKho.TabIndex = 2;
			this.rdbMaKho.TabStop = true;
			this.rdbMaKho.Text = "Mã Kho";
			this.rdbMaKho.UseVisualStyleBackColor = true;
			// 
			// rdbNgayNhap
			// 
			this.rdbNgayNhap.AutoSize = true;
			this.rdbNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbNgayNhap.Location = new System.Drawing.Point(878, 37);
			this.rdbNgayNhap.Name = "rdbNgayNhap";
			this.rdbNgayNhap.Size = new System.Drawing.Size(112, 24);
			this.rdbNgayNhap.TabIndex = 2;
			this.rdbNgayNhap.TabStop = true;
			this.rdbNgayNhap.Text = "Ngày Nhập";
			this.rdbNgayNhap.UseVisualStyleBackColor = true;
			// 
			// rdbMaHang
			// 
			this.rdbMaHang.AutoSize = true;
			this.rdbMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbMaHang.Location = new System.Drawing.Point(742, 37);
			this.rdbMaHang.Name = "rdbMaHang";
			this.rdbMaHang.Size = new System.Drawing.Size(98, 24);
			this.rdbMaHang.TabIndex = 2;
			this.rdbMaHang.TabStop = true;
			this.rdbMaHang.Text = "Mã Hàng";
			this.rdbMaHang.UseVisualStyleBackColor = true;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.Location = new System.Drawing.Point(55, 30);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(146, 39);
			this.btnTimKiem.TabIndex = 0;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(220, 30);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(438, 38);
			this.txtTimKiem.TabIndex = 1;
			// 
			// FormNhapKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(1387, 836);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.dgvNhapHang);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormNhapKho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Kho";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhapKho_FormClosing);
			this.Load += new System.EventHandler(this.FormNhapKho_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox ccbNhaCungCap;
		private System.Windows.Forms.TextBox txtMaHoaDon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker datNgayNhap;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ccbKho;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTongTien;
		private System.Windows.Forms.Button btnNhapHang;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dgvNhapHang;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.RadioButton rdbMaHang;
		private System.Windows.Forms.RadioButton rdbMaKho;
		private System.Windows.Forms.RadioButton rdbNgayNhap;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbTen;
	}
}

