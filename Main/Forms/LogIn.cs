using System;
using System.Windows.Forms;
using DataAccessLayer;
using Main.Entities;
using Main.Forms;
using Utilities;

namespace Main.Forms {
	public partial class LogIn : Form {
		public LogIn() => InitializeComponent();

		private void buttonEnter_Click(object sender, EventArgs e) {
			if (EmployeeAdapter.Autenticate(System.Configuration.ConfigurationManager.AppSettings["Connection"], textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim()).Rows.Count != 1) {
				Generics.CleanFields(this);
				Generics.WrongInput("Usuario inexistente.", this);

				return;
			}

			var employee = new Employee(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
			new Home(employee).Show();

			Hide();
		}
	}
}
