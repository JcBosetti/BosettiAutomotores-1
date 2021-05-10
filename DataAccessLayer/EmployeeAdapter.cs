using Main.Entities;
using System.Data.SqlClient;

namespace DataAccessLayer {
	class EmployeeAdapter {
		public static void Autenticate(string ip, string username, string pass) {
			using var conn = new SqlConnection(ip);
			using var cmd = new SqlCommand("SELECT legajo, nombre, password, nivel_acceso FROM Empleados WHERE legajo LIKE @legajo AND password LIKE @pass", conn);
			cmd.Parameters.AddWithValue("@legajo", username);
			cmd.Parameters.AddWithValue("@pass", pass);

			conn.Open();
			cmd.ExecuteNonQuery();
		}

		
	}
}
