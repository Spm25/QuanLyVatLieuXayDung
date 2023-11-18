using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatLieuXayDung
{
	internal class DatabaseConnector
	{
		private readonly string connectionString;
		private SqlConnection connection;

		public DatabaseConnector()
		{
			this.connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VatLieuXayDung;Integrated Security=True";
			this.connection = new SqlConnection(this.connectionString);
		}

		private void OpenConnection()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		private void CloseConnection()
		{
			if (connection.State == ConnectionState.Open)
			{
				connection.Close();
			}
		}

		public DataTable ExecuteQuery(string query)
		{
			OpenConnection();
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				DataTable dataTable = new DataTable();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					dataTable.Load(reader);
					return dataTable;
				}
			}
		}

		public int ExecuteNonQuery(string query)
		{
			OpenConnection();
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				return command.ExecuteNonQuery();
			}
		}
		public void Dispose()
		{
			connection.Dispose();
		}
		public Account CheckLogin(string userName, string password)
		{
			string query = $"SELECT * " +
				$"FROM TaiKhoan tk join NhanVien nv on tk.MaNhanVien = nv.MaNhanVien " +
				$"WHERE UserName = '{userName}' AND Password = '{password}'";
			DataTable dataTable = ExecuteQuery(query);

			if (dataTable.Rows.Count > 0)
			{
				DataRow row = dataTable.Rows[0];
				Account account = new Account
				{
					userName = row["UserName"].ToString(),
					password = row["Password"].ToString(),
					phone = row["DienThoai"].ToString(),
					name = row["TenNhanVien"].ToString(),
					maNV = row["MaNhanVien"].ToString(),
					isAdmin = Convert.ToBoolean(row["IsAdmin"])
				};
				return account;
			}

			return null; // Tài khoản không hợp lệ
		}

	}
}
