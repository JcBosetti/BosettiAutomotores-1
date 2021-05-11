using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer {
	public static class OtherAdapters {
		public static DataTable LoadGrid(string ip) {
			using var conn = new SqlConnection(ip);
			using var cmd = new SqlCommand("SELECT * FROM Empleados", conn);

			conn.Open();

			using var dataAdapter = new SqlDataAdapter(cmd);

			var dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		public static void Search(string ip, ) {

		}
	}
}
