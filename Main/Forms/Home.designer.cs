
namespace Main.Forms {
	partial class Home {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.flowLayoutPanelSidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonEmployee = new System.Windows.Forms.Button();
			this.buttonInvoice = new System.Windows.Forms.Button();
			this.buttonService = new System.Windows.Forms.Button();
			this.buttonStock = new System.Windows.Forms.Button();
			this.buttonEmployees = new System.Windows.Forms.Button();
			this.buttonSuppliers = new System.Windows.Forms.Button();
			this.buttonStatistics = new System.Windows.Forms.Button();
			this.panelBackground = new System.Windows.Forms.Panel();
			this.flowLayoutPanelSidebar.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanelSidebar
			// 
			this.flowLayoutPanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonEmployee);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonInvoice);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonService);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonStock);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonEmployees);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonSuppliers);
			this.flowLayoutPanelSidebar.Controls.Add(this.buttonStatistics);
			this.flowLayoutPanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanelSidebar.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelSidebar.Name = "flowLayoutPanelSidebar";
			this.flowLayoutPanelSidebar.Size = new System.Drawing.Size(101, 710);
			this.flowLayoutPanelSidebar.TabIndex = 0;
			// 
			// buttonEmployee
			// 
			this.buttonEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEmployee.ForeColor = System.Drawing.Color.Transparent;
			this.buttonEmployee.Image = global::Main.Properties.Resources.Usuarios_64px;
			this.buttonEmployee.Location = new System.Drawing.Point(3, 3);
			this.buttonEmployee.Name = "buttonEmployee";
			this.buttonEmployee.Size = new System.Drawing.Size(95, 95);
			this.buttonEmployee.TabIndex = 7;
			this.buttonEmployee.UseVisualStyleBackColor = false;
			// 
			// buttonInvoice
			// 
			this.buttonInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInvoice.ForeColor = System.Drawing.Color.White;
			this.buttonInvoice.Image = global::Main.Properties.Resources.VentasTp1;
			this.buttonInvoice.Location = new System.Drawing.Point(3, 104);
			this.buttonInvoice.Name = "buttonInvoice";
			this.buttonInvoice.Size = new System.Drawing.Size(95, 95);
			this.buttonInvoice.TabIndex = 11;
			this.buttonInvoice.Text = "Facturación";
			this.buttonInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonInvoice.UseVisualStyleBackColor = false;
			this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
			// 
			// buttonService
			// 
			this.buttonService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonService.ForeColor = System.Drawing.Color.White;
			this.buttonService.Image = global::Main.Properties.Resources.ServiceTp;
			this.buttonService.Location = new System.Drawing.Point(3, 205);
			this.buttonService.Name = "buttonService";
			this.buttonService.Size = new System.Drawing.Size(95, 95);
			this.buttonService.TabIndex = 8;
			this.buttonService.Text = "Service";
			this.buttonService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonService.UseVisualStyleBackColor = false;
			this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
			// 
			// buttonStock
			// 
			this.buttonStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStock.ForeColor = System.Drawing.Color.White;
			this.buttonStock.Image = global::Main.Properties.Resources.inventarioTp;
			this.buttonStock.Location = new System.Drawing.Point(3, 306);
			this.buttonStock.Name = "buttonStock";
			this.buttonStock.Size = new System.Drawing.Size(95, 95);
			this.buttonStock.TabIndex = 7;
			this.buttonStock.Text = "Inventario";
			this.buttonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonStock.UseVisualStyleBackColor = false;
			this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
			// 
			// buttonEmployees
			// 
			this.buttonEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEmployees.ForeColor = System.Drawing.Color.White;
			this.buttonEmployees.Image = global::Main.Properties.Resources.EmpleadoTp1;
			this.buttonEmployees.Location = new System.Drawing.Point(3, 407);
			this.buttonEmployees.Name = "buttonEmployees";
			this.buttonEmployees.Size = new System.Drawing.Size(95, 95);
			this.buttonEmployees.TabIndex = 9;
			this.buttonEmployees.Text = "Personal";
			this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonEmployees.UseVisualStyleBackColor = false;
			this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
			// 
			// buttonSuppliers
			// 
			this.buttonSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSuppliers.ForeColor = System.Drawing.Color.White;
			this.buttonSuppliers.Image = global::Main.Properties.Resources.ProveedoresTp;
			this.buttonSuppliers.Location = new System.Drawing.Point(3, 508);
			this.buttonSuppliers.Name = "buttonSuppliers";
			this.buttonSuppliers.Size = new System.Drawing.Size(95, 95);
			this.buttonSuppliers.TabIndex = 8;
			this.buttonSuppliers.Text = "Proveedores";
			this.buttonSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonSuppliers.UseVisualStyleBackColor = false;
			this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
			// 
			// buttonStatistics
			// 
			this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
			this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStatistics.ForeColor = System.Drawing.Color.White;
			this.buttonStatistics.Image = global::Main.Properties.Resources.GraficasTp;
			this.buttonStatistics.Location = new System.Drawing.Point(3, 609);
			this.buttonStatistics.Name = "buttonStatistics";
			this.buttonStatistics.Size = new System.Drawing.Size(95, 95);
			this.buttonStatistics.TabIndex = 10;
			this.buttonStatistics.Text = "Estadisticas";
			this.buttonStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonStatistics.UseVisualStyleBackColor = false;
			this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
			// 
			// panelBackground
			// 
			this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBackground.Location = new System.Drawing.Point(101, 0);
			this.panelBackground.Name = "panelBackground";
			this.panelBackground.Size = new System.Drawing.Size(1020, 710);
			this.panelBackground.TabIndex = 1;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1121, 710);
			this.Controls.Add(this.panelBackground);
			this.Controls.Add(this.flowLayoutPanelSidebar);
			this.MaximizeBox = false;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
			this.flowLayoutPanelSidebar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSidebar;
		private System.Windows.Forms.Button buttonStatistics;
		private System.Windows.Forms.Button buttonSuppliers;
		private System.Windows.Forms.Button buttonEmployees;
		private System.Windows.Forms.Button buttonStock;
		private System.Windows.Forms.Button buttonEmployee;
		private System.Windows.Forms.Button buttonInvoice;
		private System.Windows.Forms.Button buttonService;
		private System.Windows.Forms.Panel panelBackground;
	}
}