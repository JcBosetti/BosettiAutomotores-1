using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer {
	public static class GeneralAdapter {
		public static DataTable Query(string ip, string query, Dictionary<string, string> parameters) {
			using var conn = new SqlConnection(ip);
			conn.Open();

			using var cmd = new SqlCommand(query, conn);
			foreach (var item in parameters) cmd.Parameters.AddWithValue(item.Key, item.Value);

			using var adapter = new SqlDataAdapter(cmd);

			var table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		public static void Execute(string ip, string query, Dictionary<string, string> parameters) {
			using var conn = new SqlConnection(ip);
			conn.Open();

			using var cmd = new SqlCommand(query, conn);
			foreach (var item in parameters) cmd.Parameters.AddWithValue(item.Key, item.Value);

			cmd.ExecuteNonQuery();
		}
	}
}
