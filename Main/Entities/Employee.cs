namespace Main.Entities {
	public class Employee {
		public string Username { get; set; }
		public string Password { get; set; }
		public int AccessLevel { get; set; }

		public Employee(string username, string password) {
			Username = username;
			Password = password;
			//AccessLevel = accessLevel;
		}

		public Employee() { }
	}
}
