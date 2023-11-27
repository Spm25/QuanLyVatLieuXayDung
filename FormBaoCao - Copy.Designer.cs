namespace QuanLyVatLieuXayDung
{
    partial class FormBaoCao
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.datKetThuc2 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.datBatDau2 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbbKhachHang = new System.Windows.Forms.ComboBox();
			this.btnBaoCao3 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbbKho = new System.Windows.Forms.ComboBox();
			this.btnBaoCao2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.datKetThuc = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.datBatDau = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbLoai = new System.Windows.Forms.ComboBox();
			this.btnBaoCao1 = new System.Windows.Forms.Button();
			this.dgvBaoCao = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(86, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1208, 337);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(562, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Báo cáo";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.datKetThuc2);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.datBatDau2);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.cbbKhachHang);
			this.groupBox4.Controls.Add(this.btnBaoCao3);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(6, 245);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1196, 86);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Các sản phẩm";
			// 
			// datKetThuc2
			// 
			this.datKetThuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datKetThuc2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datKetThuc2.Location = new System.Drawing.Point(861, 44);
			this.datKetThuc2.Name = "datKetThuc2";
			this.datKetThuc2.Size = new System.Drawing.Size(131, 27);
			this.datKetThuc2.TabIndex = 5;
			this.datKetThuc2.ValueChanged += new System.EventHandler(this.datKetThuc2_ValueChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(761, 49);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "Bắt đầu:";
			// 
			// datBatDau2
			// 
			this.datBatDau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datBatDau2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datBatDau2.Location = new System.Drawing.Point(586, 44);
			this.datBatDau2.Name = "datBatDau2";
			this.datBatDau2.Size = new System.Drawing.Size(131, 27);
			this.datBatDau2.TabIndex = 5;
			this.datBatDau2.ValueChanged += new System.EventHandler(this.datBatDau2_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(499, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 20);
			this.label9.TabIndex = 4;
			this.label9.Text = "Bắt đầu:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(166, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 20);
			this.label10.TabIndex = 4;
			this.label10.Text = "Khách hàng:";
			// 
			// cbbKhachHang
			// 
			this.cbbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbKhachHang.FormattingEnabled = true;
			this.cbbKhachHang.Location = new System.Drawing.Point(289, 43);
			this.cbbKhachHang.Name = "cbbKhachHang";
			this.cbbKhachHang.Size = new System.Drawing.Size(182, 28);
			this.cbbKhachHang.TabIndex = 3;
			// 
			// btnBaoCao3
			// 
			this.btnBaoCao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBaoCao3.Location = new System.Drawing.Point(17, 43);
			this.btnBaoCao3.Name = "btnBaoCao3";
			this.btnBaoCao3.Size = new System.Drawing.Size(125, 33);
			this.btnBaoCao3.TabIndex = 0;
			this.btnBaoCao3.Text = "Báo cáo";
			this.btnBaoCao3.UseVisualStyleBackColor = true;
			this.btnBaoCao3.Click += new System.EventHandler(this.btnBaoCao3_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSoLuong);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.cbbKho);
			this.groupBox3.Controls.Add(this.btnBaoCao2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 153);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1196, 86);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Hóa đơn tổng tiền nhập lớn nhất";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(486, 46);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(97, 27);
			this.txtSoLuong.TabIndex = 5;
			this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(399, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Số lượng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Kho:";
			// 
			// cbbKho
			// 
			this.cbbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbKho.FormattingEnabled = true;
			this.cbbKho.Location = new System.Drawing.Point(243, 43);
			this.cbbKho.Name = "cbbKho";
			this.cbbKho.Size = new System.Drawing.Size(135, 28);
			this.cbbKho.TabIndex = 3;
			// 
			// btnBaoCao2
			// 
			this.btnBaoCao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBaoCao2.Location = new System.Drawing.Point(17, 43);
			this.btnBaoCao2.Name = "btnBaoCao2";
			this.btnBaoCao2.Size = new System.Drawing.Size(125, 33);
			this.btnBaoCao2.TabIndex = 0;
			this.btnBaoCao2.Text = "Báo cáo";
			this.btnBaoCao2.UseVisualStyleBackColor = true;
			this.btnBaoCao2.Click += new System.EventHandler(this.btnBaoCao2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.datKetThuc);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.datBatDau);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cbbLoai);
			this.groupBox2.Controls.Add(this.btnBaoCao1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(6, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1196, 86);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Các sản phẩm";
			// 
			// datKetThuc
			// 
			this.datKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datKetThuc.Location = new System.Drawing.Point(761, 44);
			this.datKetThuc.Name = "datKetThuc";
			this.datKetThuc.Size = new System.Drawing.Size(131, 27);
			this.datKetThuc.TabIndex = 5;
			this.datKetThuc.ValueChanged += new System.EventHandler(this.datKetThuc_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(661, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Bắt đầu:";
			// 
			// datBatDau
			// 
			this.datBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datBatDau.Location = new System.Drawing.Point(486, 44);
			this.datBatDau.Name = "datBatDau";
			this.datBatDau.Size = new System.Drawing.Size(131, 27);
			this.datBatDau.TabIndex = 5;
			this.datBatDau.ValueChanged += new System.EventHandler(this.datBatDau_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(399, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Bắt đầu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(166, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Loại:";
			// 
			// cbbLoai
			// 
			this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbLoai.FormattingEnabled = true;
			this.cbbLoai.Items.AddRange(new object[] {
            "Đã bán",
            "Chưa bán"});
			this.cbbLoai.Location = new System.Drawing.Point(243, 43);
			this.cbbLoai.Name = "cbbLoai";
			this.cbbLoai.Size = new System.Drawing.Size(135, 28);
			this.cbbLoai.TabIndex = 3;
			// 
			// btnBaoCao1
			// 
			this.btnBaoCao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBaoCao1.Location = new System.Drawing.Point(17, 43);
			this.btnBaoCao1.Name = "btnBaoCao1";
			this.btnBaoCao1.Size = new System.Drawing.Size(125, 33);
			this.btnBaoCao1.TabIndex = 0;
			this.btnBaoCao1.Text = "Báo cáo";
			this.btnBaoCao1.UseVisualStyleBackColor = true;
			this.btnBaoCao1.Click += new System.EventHandler(this.btnBaoCao1_Click);
			// 
			// dgvBaoCao
			// 
			this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCao.Location = new System.Drawing.Point(86, 432);
			this.dgvBaoCao.Name = "dgvBaoCao";
			this.dgvBaoCao.RowHeadersWidth = 51;
			this.dgvBaoCao.RowTemplate.Height = 24;
			this.dgvBaoCao.Size = new System.Drawing.Size(1208, 373);
			this.dgvBaoCao.TabIndex = 2;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(86, 349);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(1208, 71);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(190, 26);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 33);
			this.button2.TabIndex = 0;
			this.button2.Text = "Report";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(23, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Excel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// FormBaoCao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(1387, 824);
			this.Controls.Add(this.dgvBaoCao);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormBaoCao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Kho";
			this.Load += new System.EventHandler(this.FormBaoCao_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvBaoCao;
		private System.Windows.Forms.Button btnBaoCao1;
		private System.Windows.Forms.DateTimePicker datBatDau;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbLoai;
		private System.Windows.Forms.DateTimePicker datKetThuc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DateTimePicker datKetThuc2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker datBatDau2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbbKhachHang;
		private System.Windows.Forms.Button btnBaoCao3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbKho;
		private System.Windows.Forms.Button btnBaoCao2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

