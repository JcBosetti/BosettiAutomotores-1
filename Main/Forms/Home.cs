using Main.Entities;
using System.Windows.Forms;

namespace Main.Forms {
	public partial class Home : Form {
		private Form activeForm = null;

		public Home(Employee employee) => InitializeComponent();

		private void buttonInvoice_Click(object sender, System.EventArgs e) => openChildForm(new Invoices());

		private void buttonService_Click(object sender, System.EventArgs e) => openChildForm(new Services());

		private void buttonStock_Click(object sender, System.EventArgs e) => openChildForm(new Stock());

		private void buttonEmployees_Click(object sender, System.EventArgs e) => openChildForm(new Employees());

		private void buttonSuppliers_Click(object sender, System.EventArgs e) => openChildForm(new Suppliers());

		private void buttonStatistics_Click(object sender, System.EventArgs e) => openChildForm(new Statistics());

		private void Home_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

		private void openChildForm(Form childForm) {
			if (activeForm != null) activeForm.Close();

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.Dock = DockStyle.Fill;
			panelBackground.Controls.Add(childForm);
			panelBackground.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}
