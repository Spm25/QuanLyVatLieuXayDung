namespace QuanLyVatLieuXayDung
{
    partial class FormBaoCao2
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbbKho = new System.Windows.Forms.ComboBox();
			this.btnBaoCao2 = new System.Windows.Forms.Button();
			this.dgvBaoCao = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(86, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1208, 154);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSoLuong);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.cbbKho);
			this.groupBox3.Controls.Add(this.btnBaoCao2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 61);
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
			this.btnBaoCao2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnBaoCao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBaoCao2.Location = new System.Drawing.Point(17, 43);
			this.btnBaoCao2.Name = "btnBaoCao2";
			this.btnBaoCao2.Size = new System.Drawing.Size(125, 33);
			this.btnBaoCao2.TabIndex = 0;
			this.btnBaoCao2.Text = "Báo cáo";
			this.btnBaoCao2.UseVisualStyleBackColor = false;
			this.btnBaoCao2.Click += new System.EventHandler(this.btnBaoCao2_Click);
			// 
			// dgvBaoCao
			// 
			this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCao.Location = new System.Drawing.Point(86, 258);
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
			this.groupBox5.Location = new System.Drawing.Point(86, 172);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(1208, 71);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(190, 26);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 33);
			this.button2.TabIndex = 0;
			this.button2.Text = "Report";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(23, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Excel";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormBaoCao2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(1387, 824);
			this.Controls.Add(this.dgvBaoCao);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormBaoCao2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Kho";
			this.Load += new System.EventHandler(this.FormBaoCao2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvBaoCao;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbKho;
		private System.Windows.Forms.Button btnBaoCao2;
	}
}

