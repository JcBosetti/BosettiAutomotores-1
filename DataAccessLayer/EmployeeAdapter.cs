using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer {
	public static class EmployeeAdapter {
		public static DataTable Autenticate(string ip, string id, string password) => GeneralAdapter.Query(ip, "SELECT numero_documento, nombre, password, nivel_acceso FROM Empleados WHERE numero_documento LIKE @legajo AND password LIKE @pass", new Dictionary<string, string>() { { "@legajo", id }, { "@pass", password } });

		public static DataTable LoadGrid(string ip) => GeneralAdapter.Query(ip, "SELECT * FROM Empleados", new Dictionary<string, string>());

		public static DataTable SearchId(string ip, string id) => GeneralAdapter.Query(ip, "SELECT * FROM Empleados WHERE numero_documento LIKE @legajo", new Dictionary<string, string>() { { "@legajo", id } });

		public static DataTable Load(string ip, string id, string username, string password) {
			var table = SearchId(id, ip);

			if (table.Rows.Count == 0) GeneralAdapter.Execute(ip, "user_load", new Dictionary<string, string>() { { "@user", username }, { "@pass", password } });

			return table;
		}

		public static DataTable SearchName(string ip, string firstName, string lastName) => GeneralAdapter.Query(ip, "SELECT * FROM Empleados WHERE nombre LIKE @nombre AND apellido LIKE @apellido", new Dictionary<string, string>() { { "@nombre", firstName }, { "@apellido", lastName } });

		public static DataTable Modify(string ip, string id, string username, string password) {
			var table = GeneralAdapter.Query(ip, "SELECT * FROM Empleados WHERE numero_documento NOT LIKE @legajo", new Dictionary<string, string>() { { "@legajo", id } });

			if (table.Rows.Count == 0) GeneralAdapter.Execute(ip, "user_modify", new Dictionary<string, string>() { { "@user", username }, { "@pass", password } });

			return table;
		}

		public static DataTable Eliminate(string ip, string id, string password) {
			var table = GeneralAdapter.Query(ip, "SELECT * FROM Empleados WHERE numero_legajo LIKE @legajo AND contraseña LIKE @pass", new Dictionary<string, string>() { { "@legajo", id }, { "@pass", password } });

			if (table.Rows.Count == 1) GeneralAdapter.Execute(ip, "user_delete", new Dictionary<string, string>());

			return table;
		}
	}
}
