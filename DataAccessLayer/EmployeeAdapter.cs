using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer {
	public static class EmployeeAdapter {
		private static DataTable Query(string ip, string query, Dictionary<string, string> parameters) {
			using var conn = new SqlConnection(ip);
			conn.Open();

			using var cmd = new SqlCommand(query, conn);
			parameters.Select(item => cmd.Parameters.AddWithValue(item.Key, item.Value));

			using var adapter = new SqlDataAdapter(cmd);

			var table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		private static void Execute(string ip, string query, Dictionary<string, string> parameters) {
			using var conn = new SqlConnection(ip);
			conn.Open();

			using var cmd = new SqlCommand(query, conn);
			parameters.Select(item => cmd.Parameters.AddWithValue(item.Key, item.Value));

			cmd.ExecuteNonQuery();
		}

		public static DataTable Autenticate(string ip, string id, string password) => Query(ip, "SELECT legajo, nombre, password, nivel_acceso FROM Empleados WHERE legajo LIKE @legajo AND password LIKE @pass", new Dictionary<string, string>() { { "@legajo", id }, { "@pass", password } });

		public static DataTable LoadGrid(string ip) => Query(ip, "SELECT * FROM Empleados", new Dictionary<string, string>());

		public static DataTable SearchId(string ip, string id) => Query(ip, "SELECT * FROM Empleados WHERE legajo LIKE @legajo", new Dictionary<string, string>() { { "@legajo", id } });

		public static DataTable Load(string ip, string id, string username, string password) {
			var table = SearchId(id, ip);

			if (table.Rows.Count == 0) Execute(ip, "user_load", new Dictionary<string, string>() { { "@user", username }, { "@pass", password } });

			return table;
		}

		public static DataTable SearchName(string ip, string firstName, string lastName) => Query(ip, "SELECT * FROM Empleados WHERE nombre LIKE @nombre AND apellido LIKE @apellido", new Dictionary<string, string>() { { "@nombre", firstName }, { "@apellido", lastName } });

		public static DataTable Modify(string ip, string id, string username, string password) {
			var table = Query(ip, "SELECT * FROM Empleados WHERE legajo NOT LIKE @legajo", new Dictionary<string, string>() { { "@legajo", id } });

			if (table.Rows.Count == 0) Execute(ip, "user_modify", new Dictionary<string, string>() { { "@user", username }, { "@pass", password } });

			return table;
		}

		public static DataTable Eliminate(string ip, string id, string password) {
			var table = Query(ip, "SELECT * FROM Empleados WHERE legajo LIKE @legajo AND contraseña LIKE @pass", new Dictionary<string, string>() { { "@legajo", id }, { "@pass", password } });

			if (table.Rows.Count == 1) Execute(ip, "user_delete", new Dictionary<string, string>());

			return table;
		}
	}
}
