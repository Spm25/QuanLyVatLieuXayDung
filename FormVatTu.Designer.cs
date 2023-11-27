namespace QuanLyVatLieuXayDung
{
    partial class FormVatTu
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
			this.gbTimKiem = new System.Windows.Forms.GroupBox();
			this.gbDoLon = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTimKiemTheoGiaTri = new System.Windows.Forms.Button();
			this.txtGiaTri2 = new System.Windows.Forms.TextBox();
			this.txtGiaTri1 = new System.Windows.Forms.TextBox();
			this.cbbKhoangGiaTri = new System.Windows.Forms.ComboBox();
			this.rdbGiaNhap = new System.Windows.Forms.RadioButton();
			this.rdbSoLuong = new System.Windows.Forms.RadioButton();
			this.gbLoai = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.cbbNCC = new System.Windows.Forms.ComboBox();
			this.rdbTenVatTu = new System.Windows.Forms.RadioButton();
			this.rdbTenNCC = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.gnHienThi = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cbbKho = new System.Windows.Forms.ComboBox();
			this.btnKho = new System.Windows.Forms.Button();
			this.dgvVatTu = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.gbTimKiem.SuspendLayout();
			this.gbDoLon.SuspendLayout();
			this.gbLoai.SuspendLayout();
			this.gnHienThi.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gbTimKiem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.gnHienThi);
			this.groupBox1.Location = new System.Drawing.Point(86, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1208, 380);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// gbTimKiem
			// 
			this.gbTimKiem.Controls.Add(this.gbDoLon);
			this.gbTimKiem.Controls.Add(this.gbLoai);
			this.gbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTimKiem.Location = new System.Drawing.Point(6, 174);
			this.gbTimKiem.Name = "gbTimKiem";
			this.gbTimKiem.Size = new System.Drawing.Size(1196, 200);
			this.gbTimKiem.TabIndex = 3;
			this.gbTimKiem.TabStop = false;
			this.gbTimKiem.Text = "Tìm Kiếm Theo";
			// 
			// gbDoLon
			// 
			this.gbDoLon.Controls.Add(this.label2);
			this.gbDoLon.Controls.Add(this.btnTimKiemTheoGiaTri);
			this.gbDoLon.Controls.Add(this.txtGiaTri2);
			this.gbDoLon.Controls.Add(this.txtGiaTri1);
			this.gbDoLon.Controls.Add(this.cbbKhoangGiaTri);
			this.gbDoLon.Controls.Add(this.rdbGiaNhap);
			this.gbDoLon.Controls.Add(this.rdbSoLuong);
			this.gbDoLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDoLon.Location = new System.Drawing.Point(6, 92);
			this.gbDoLon.Name = "gbDoLon";
			this.gbDoLon.Size = new System.Drawing.Size(631, 102);
			this.gbDoLon.TabIndex = 4;
			this.gbDoLon.TabStop = false;
			this.gbDoLon.Text = "Độ lớn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Khoảng giá trị:";
			// 
			// btnTimKiemTheoGiaTri
			// 
			this.btnTimKiemTheoGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiemTheoGiaTri.Location = new System.Drawing.Point(44, 23);
			this.btnTimKiemTheoGiaTri.Name = "btnTimKiemTheoGiaTri";
			this.btnTimKiemTheoGiaTri.Size = new System.Drawing.Size(124, 30);
			this.btnTimKiemTheoGiaTri.TabIndex = 0;
			this.btnTimKiemTheoGiaTri.Text = "Tìm Kiếm";
			this.btnTimKiemTheoGiaTri.UseVisualStyleBackColor = true;
			this.btnTimKiemTheoGiaTri.Click += new System.EventHandler(this.btnTimKiemTheoGiaTri_Click);
			// 
			// txtGiaTri2
			// 
			this.txtGiaTri2.Location = new System.Drawing.Point(491, 72);
			this.txtGiaTri2.Name = "txtGiaTri2";
			this.txtGiaTri2.Size = new System.Drawing.Size(100, 24);
			this.txtGiaTri2.TabIndex = 6;
			// 
			// txtGiaTri1
			// 
			this.txtGiaTri1.Location = new System.Drawing.Point(363, 72);
			this.txtGiaTri1.Name = "txtGiaTri1";
			this.txtGiaTri1.Size = new System.Drawing.Size(100, 24);
			this.txtGiaTri1.TabIndex = 6;
			// 
			// cbbKhoangGiaTri
			// 
			this.cbbKhoangGiaTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbKhoangGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbKhoangGiaTri.FormattingEnabled = true;
			this.cbbKhoangGiaTri.Items.AddRange(new object[] {
            "Lớn hơn",
            "Nhỏ hơn",
            "Trong Khoảng",
            "Bằng"});
			this.cbbKhoangGiaTri.Location = new System.Drawing.Point(186, 70);
			this.cbbKhoangGiaTri.Name = "cbbKhoangGiaTri";
			this.cbbKhoangGiaTri.Size = new System.Drawing.Size(135, 26);
			this.cbbKhoangGiaTri.TabIndex = 3;
			this.cbbKhoangGiaTri.SelectedIndexChanged += new System.EventHandler(this.cbbKhoangGiaTri_SelectedIndexChanged);
			// 
			// rdbGiaNhap
			// 
			this.rdbGiaNhap.AutoSize = true;
			this.rdbGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbGiaNhap.Location = new System.Drawing.Point(327, 23);
			this.rdbGiaNhap.Name = "rdbGiaNhap";
			this.rdbGiaNhap.Size = new System.Drawing.Size(97, 24);
			this.rdbGiaNhap.TabIndex = 4;
			this.rdbGiaNhap.TabStop = true;
			this.rdbGiaNhap.Text = "Giá nhập";
			this.rdbGiaNhap.UseVisualStyleBackColor = true;
			// 
			// rdbSoLuong
			// 
			this.rdbSoLuong.AutoSize = true;
			this.rdbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbSoLuong.Location = new System.Drawing.Point(191, 23);
			this.rdbSoLuong.Name = "rdbSoLuong";
			this.rdbSoLuong.Size = new System.Drawing.Size(95, 24);
			this.rdbSoLuong.TabIndex = 5;
			this.rdbSoLuong.TabStop = true;
			this.rdbSoLuong.Text = "Số lượng";
			this.rdbSoLuong.UseVisualStyleBackColor = true;
			// 
			// gbLoai
			// 
			this.gbLoai.Controls.Add(this.txtTimKiem);
			this.gbLoai.Controls.Add(this.btnTimKiem);
			this.gbLoai.Controls.Add(this.cbbNCC);
			this.gbLoai.Controls.Add(this.rdbTenVatTu);
			this.gbLoai.Controls.Add(this.rdbTenNCC);
			this.gbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbLoai.Location = new System.Drawing.Point(6, 17);
			this.gbLoai.Name = "gbLoai";
			this.gbLoai.Size = new System.Drawing.Size(1032, 69);
			this.gbLoai.TabIndex = 3;
			this.gbLoai.TabStop = false;
			this.gbLoai.Text = "Loại";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(183, 22);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(345, 30);
			this.txtTimKiem.TabIndex = 1;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.Location = new System.Drawing.Point(42, 22);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(124, 30);
			this.btnTimKiem.TabIndex = 0;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// cbbNCC
			// 
			this.cbbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbNCC.FormattingEnabled = true;
			this.cbbNCC.Location = new System.Drawing.Point(877, 26);
			this.cbbNCC.Name = "cbbNCC";
			this.cbbNCC.Size = new System.Drawing.Size(135, 26);
			this.cbbNCC.TabIndex = 3;
			this.cbbNCC.Visible = false;
			// 
			// rdbTenVatTu
			// 
			this.rdbTenVatTu.AutoSize = true;
			this.rdbTenVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbTenVatTu.Location = new System.Drawing.Point(614, 28);
			this.rdbTenVatTu.Name = "rdbTenVatTu";
			this.rdbTenVatTu.Size = new System.Drawing.Size(112, 24);
			this.rdbTenVatTu.TabIndex = 2;
			this.rdbTenVatTu.TabStop = true;
			this.rdbTenVatTu.Text = "Tên Vật Tư";
			this.rdbTenVatTu.UseVisualStyleBackColor = true;
			// 
			// rdbTenNCC
			// 
			this.rdbTenNCC.AutoSize = true;
			this.rdbTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbTenNCC.Location = new System.Drawing.Point(758, 28);
			this.rdbTenNCC.Name = "rdbTenNCC";
			this.rdbTenNCC.Size = new System.Drawing.Size(99, 24);
			this.rdbTenNCC.TabIndex = 2;
			this.rdbTenNCC.TabStop = true;
			this.rdbTenNCC.Text = "Tên NCC";
			this.rdbTenNCC.UseVisualStyleBackColor = true;
			this.rdbTenNCC.CheckedChanged += new System.EventHandler(this.rdbTenNhanVien_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(562, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vật Tư";
			// 
			// gnHienThi
			// 
			this.gnHienThi.Controls.Add(this.button2);
			this.gnHienThi.Controls.Add(this.button1);
			this.gnHienThi.Controls.Add(this.groupBox5);
			this.gnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gnHienThi.Location = new System.Drawing.Point(6, 61);
			this.gnHienThi.Name = "gnHienThi";
			this.gnHienThi.Size = new System.Drawing.Size(1196, 96);
			this.gnHienThi.TabIndex = 0;
			this.gnHienThi.TabStop = false;
			this.gnHienThi.Text = "Hiển thị";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(865, 31);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 42);
			this.button2.TabIndex = 3;
			this.button2.Text = "Report";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(670, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 42);
			this.button1.TabIndex = 4;
			this.button1.Text = "Excel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cbbKho);
			this.groupBox5.Controls.Add(this.btnKho);
			this.groupBox5.Location = new System.Drawing.Point(6, 17);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(378, 61);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			// 
			// cbbKho
			// 
			this.cbbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbKho.FormattingEnabled = true;
			this.cbbKho.Items.AddRange(new object[] {
            "Toàn bộ"});
			this.cbbKho.Location = new System.Drawing.Point(222, 18);
			this.cbbKho.Name = "cbbKho";
			this.cbbKho.Size = new System.Drawing.Size(135, 37);
			this.cbbKho.TabIndex = 3;
			// 
			// btnKho
			// 
			this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKho.Location = new System.Drawing.Point(26, 16);
			this.btnKho.Name = "btnKho";
			this.btnKho.Size = new System.Drawing.Size(146, 39);
			this.btnKho.TabIndex = 0;
			this.btnKho.Text = "Hiển thị theo: ";
			this.btnKho.UseVisualStyleBackColor = true;
			this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
			// 
			// dgvVatTu
			// 
			this.dgvVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVatTu.Location = new System.Drawing.Point(86, 398);
			this.dgvVatTu.Name = "dgvVatTu";
			this.dgvVatTu.RowHeadersWidth = 51;
			this.dgvVatTu.RowTemplate.Height = 24;
			this.dgvVatTu.Size = new System.Drawing.Size(1208, 407);
			this.dgvVatTu.TabIndex = 2;
			// 
			// FormVatTu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(1387, 824);
			this.Controls.Add(this.dgvVatTu);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormVatTu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Kho";
			this.Load += new System.EventHandler(this.FormVatTu_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbTimKiem.ResumeLayout(false);
			this.gbDoLon.ResumeLayout(false);
			this.gbDoLon.PerformLayout();
			this.gbLoai.ResumeLayout(false);
			this.gbLoai.PerformLayout();
			this.gnHienThi.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gnHienThi;
		private System.Windows.Forms.DataGridView dgvVatTu;
		private System.Windows.Forms.GroupBox gbTimKiem;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.RadioButton rdbTenVatTu;
		private System.Windows.Forms.RadioButton rdbTenNCC;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnKho;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.GroupBox gbLoai;
		private System.Windows.Forms.ComboBox cbbKho;
		private System.Windows.Forms.GroupBox gbDoLon;
		private System.Windows.Forms.RadioButton rdbGiaNhap;
		private System.Windows.Forms.RadioButton rdbSoLuong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGiaTri2;
		private System.Windows.Forms.TextBox txtGiaTri1;
		private System.Windows.Forms.ComboBox cbbKhoangGiaTri;
		private System.Windows.Forms.ComboBox cbbNCC;
		private System.Windows.Forms.Button btnTimKiemTheoGiaTri;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

