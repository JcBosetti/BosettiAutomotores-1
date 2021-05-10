namespace Main.Entities {
	public class User {
		public string Username { get; set; }
		public string Password { get; set; }
		public int AccessLevel { get; set; }

		public User(string username, string password, int accessLevel) {
			Username = username;
			Password = password;
			AccessLevel = accessLevel;
		}

		public User() { }
	}
}
