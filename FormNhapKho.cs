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

		}
	}
}
