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
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnNhapHang = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dgvNhapHang = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(123, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(984, 468);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(350, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 32);
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
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(6, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(972, 401);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cập nhật hóa đơn hàng";
			// 
			// datNgayNhap
			// 
			this.datNgayNhap.CustomFormat = "dd / MM / yyyy";
			this.datNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datNgayNhap.Location = new System.Drawing.Point(621, 106);
			this.datNgayNhap.Name = "datNgayNhap";
			this.datNgayNhap.Size = new System.Drawing.Size(143, 22);
			this.datNgayNhap.TabIndex = 3;
			this.datNgayNhap.Value = new System.DateTime(2023, 1, 12, 0, 0, 0, 0);
			// 
			// ccbKho
			// 
			this.ccbKho.FormattingEnabled = true;
			this.ccbKho.Location = new System.Drawing.Point(621, 190);
			this.ccbKho.Name = "ccbKho";
			this.ccbKho.Size = new System.Drawing.Size(121, 24);
			this.ccbKho.TabIndex = 2;
			// 
			// ccbNhaCungCap
			// 
			this.ccbNhaCungCap.FormattingEnabled = true;
			this.ccbNhaCungCap.Location = new System.Drawing.Point(160, 187);
			this.ccbNhaCungCap.Name = "ccbNhaCungCap";
			this.ccbNhaCungCap.Size = new System.Drawing.Size(121, 24);
			this.ccbNhaCungCap.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(502, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ngày nhập:";
			// 
			// txtMaHoaDon
			// 
			this.txtMaHoaDon.Location = new System.Drawing.Point(160, 103);
			this.txtMaHoaDon.Name = "txtMaHoaDon";
			this.txtMaHoaDon.Size = new System.Drawing.Size(165, 22);
			this.txtMaHoaDon.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(502, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Kho:";
			// 
			// lbTongTien
			// 
			this.lbTongTien.AutoSize = true;
			this.lbTongTien.Location = new System.Drawing.Point(140, 286);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(22, 16);
			this.lbTongTien.TabIndex = 0;
			this.lbTongTien.Text = "0đ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(58, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tổng tiền:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(58, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nhà cung cấp:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã hóa đơn:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.btnNhapHang);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.groupBox3.Location = new System.Drawing.Point(1127, 31);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(204, 462);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức năng";
			// 
			// btnNhapHang
			// 
			this.btnNhapHang.Location = new System.Drawing.Point(26, 205);
			this.btnNhapHang.Name = "btnNhapHang";
			this.btnNhapHang.Size = new System.Drawing.Size(146, 39);
			this.btnNhapHang.TabIndex = 0;
			this.btnNhapHang.Text = "Nhập hàng";
			this.btnNhapHang.UseVisualStyleBackColor = true;
			this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(26, 147);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(146, 39);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(26, 94);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(146, 39);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(26, 41);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(146, 39);
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
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(26, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Lưu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(26, 324);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(146, 39);
			this.button2.TabIndex = 0;
			this.button2.Text = "Hủy";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(26, 381);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(146, 39);
			this.button3.TabIndex = 0;
			this.button3.Text = "Tìm kiếm";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// FormNhapKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 836);
			this.Controls.Add(this.dgvNhapHang);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormNhapKho";
			this.Text = "Nhập Kho";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhapKho_FormClosing);
			this.Load += new System.EventHandler(this.FormNhapKho_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

