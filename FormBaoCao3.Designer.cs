namespace QuanLyVatLieuXayDung
{
    partial class FormBaoCao3
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
			this.dgvBaoCao = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Location = new System.Drawing.Point(86, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1208, 172);
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
			this.groupBox4.Location = new System.Drawing.Point(6, 74);
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
			// dgvBaoCao
			// 
			this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCao.Location = new System.Drawing.Point(86, 278);
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
			this.groupBox5.Location = new System.Drawing.Point(86, 190);
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
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormBaoCao3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(1387, 824);
			this.Controls.Add(this.dgvBaoCao);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormBaoCao3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Kho";
			this.Load += new System.EventHandler(this.FormBaoCao3_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvBaoCao;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DateTimePicker datKetThuc2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker datBatDau2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbbKhachHang;
		private System.Windows.Forms.Button btnBaoCao3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

