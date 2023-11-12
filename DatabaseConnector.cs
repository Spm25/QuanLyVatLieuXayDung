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
			this.connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VatLieuXayDung;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
			this.connection = new SqlConnection(connectionString);
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
		private void Dispose()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Close();
			}
		}
	}
}
