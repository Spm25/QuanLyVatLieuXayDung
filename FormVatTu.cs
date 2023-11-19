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
    public partial class FormVatTu : Form
    {
		private readonly DatabaseConnector dbConnector;
		private DataTable dataTable;
		public FormVatTu()
        {
            InitializeComponent();
			dbConnector = new DatabaseConnector();
		}

		private void FormVatTu_Load(object sender, EventArgs e)
		{
			
		}
	}
}
