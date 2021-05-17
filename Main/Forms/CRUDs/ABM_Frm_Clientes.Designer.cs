
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_Clientes));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnSearchCUIL = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCuil = new System.Windows.Forms.Label();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxProveedor = new System.Windows.Forms.PictureBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.boxBarrio = new System.Windows.Forms.ComboBox();
            this.maskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.maskTxtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelGrilla = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            this.panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedor)).BeginInit();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Wheat;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(768, 47);
            this.panelPrincipal.TabIndex = 13;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::AAA.Properties.Resources.FlechaAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(-1, -1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(65, 44);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrincipal.Location = new System.Drawing.Point(322, 8);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(86, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Clientes";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.panelCliente.Controls.Add(this.txtApellido);
            this.panelCliente.Controls.Add(this.labelApellido);
            this.panelCliente.Controls.Add(this.btnSearchCUIL);
            this.panelCliente.Controls.Add(this.labelCliente);
            this.panelCliente.Controls.Add(this.txtEmail);
            this.panelCliente.Controls.Add(this.labelEmail);
            this.panelCliente.Controls.Add(this.txtRazonSocial);
            this.panelCliente.Controls.Add(this.labelNombre);
            this.panelCliente.Controls.Add(this.labelCuil);
            this.panelCliente.Controls.Add(this.maskTxtCuil);
            this.panelCliente.Controls.Add(this.pictureBoxProveedor);
            this.panelCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelCliente.Location = new System.Drawing.Point(0, 50);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(768, 158);
            this.panelCliente.TabIndex = 14;
            // 
            // btnSearchCUIL
            // 
            this.btnSearchCUIL.BackColor = System.Drawing.Color.Snow;
            this.btnSearchCUIL.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchCUIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCUIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCUIL.Location = new System.Drawing.Point(388, 67);
            this.btnSearchCUIL.Name = "btnSearchCUIL";
            this.btnSearchCUIL.Size = new System.Drawing.Size(31, 26);
            this.btnSearchCUIL.TabIndex = 47;
            this.btnSearchCUIL.UseVisualStyleBackColor = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(360, 9);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(75, 24);
            this.labelCliente.TabIndex = 22;
            this.labelCliente.Text = "Cliente";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(166, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 33;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(166, 108);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "Email";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazonSocial.Location = new System.Drawing.Point(447, 67);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(257, 26);
            this.txtRazonSocial.TabIndex = 31;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(447, 46);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 18);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuil.Location = new System.Drawing.Point(166, 46);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(120, 18);
            this.labelCuil.TabIndex = 17;
            this.labelCuil.Text = "CUIL del Cliente";
            // 
            // maskTxtCuil
            // 
            this.maskTxtCuil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCuil.Location = new System.Drawing.Point(166, 67);
            this.maskTxtCuil.Mask = "99-99999999-9";
            this.maskTxtCuil.Name = "maskTxtCuil";
            this.maskTxtCuil.Size = new System.Drawing.Size(217, 29);
            this.maskTxtCuil.TabIndex = 16;
            this.maskTxtCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxProveedor
            // 
            this.pictureBoxProveedor.BackgroundImage = global::AAA.Properties.Resources.Compras_48px;
            this.pictureBoxProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxProveedor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProveedor.Name = "pictureBoxProveedor";
            this.pictureBoxProveedor.Size = new System.Drawing.Size(160, 155);
            this.pictureBoxProveedor.TabIndex = 0;
            this.pictureBoxProveedor.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(447, 129);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(257, 26);
            this.txtApellido.TabIndex = 49;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(447, 108);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 18);
            this.labelApellido.TabIndex = 48;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPersonal.Controls.Add(this.boxBarrio);
            this.panelPersonal.Controls.Add(this.maskTelefono);
            this.panelPersonal.Controls.Add(this.labelNroCalle);
            this.panelPersonal.Controls.Add(this.maskTxtNroCalle);
            this.panelPersonal.Controls.Add(this.labelTelefono);
            this.panelPersonal.Controls.Add(this.txtCalle);
            this.panelPersonal.Controls.Add(this.labelBarrio);
            this.panelPersonal.Controls.Add(this.Calle);
            this.panelPersonal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPersonal.Location = new System.Drawing.Point(391, 214);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(377, 146);
            this.panelPersonal.TabIndex = 50;
            // 
            // boxBarrio
            // 
            this.boxBarrio.FormattingEnabled = true;
            this.boxBarrio.Location = new System.Drawing.Point(203, 88);
            this.boxBarrio.Name = "boxBarrio";
            this.boxBarrio.Size = new System.Drawing.Size(121, 26);
            this.boxBarrio.TabIndex = 37;
            // 
            // maskTelefono
            // 
            this.maskTelefono.Location = new System.Drawing.Point(9, 88);
            this.maskTelefono.Mask = "000-000-0000";
            this.maskTelefono.Name = "maskTelefono";
            this.maskTelefono.Size = new System.Drawing.Size(125, 26);
            this.maskTelefono.TabIndex = 36;
            this.maskTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNroCalle
            // 
            this.labelNroCalle.AutoSize = true;
            this.labelNroCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNroCalle.Location = new System.Drawing.Point(261, 5);
            this.labelNroCalle.Name = "labelNroCalle";
            this.labelNroCalle.Size = new System.Drawing.Size(33, 18);
            this.labelNroCalle.TabIndex = 35;
            this.labelNroCalle.Text = "Nro";
            // 
            // maskTxtNroCalle
            // 
            this.maskTxtNroCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroCalle.Location = new System.Drawing.Point(261, 29);
            this.maskTxtNroCalle.Mask = "9999";
            this.maskTxtNroCalle.Name = "maskTxtNroCalle";
            this.maskTxtNroCalle.Size = new System.Drawing.Size(62, 26);
            this.maskTxtNroCalle.TabIndex = 34;
            this.maskTxtNroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtNroCalle.ValidatingType = typeof(int);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(15, 67);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(107, 18);
            this.labelTelefono.TabIndex = 32;
            this.labelTelefono.Text = "Nro Telefonico";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalle.Location = new System.Drawing.Point(9, 29);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(189, 26);
            this.txtCalle.TabIndex = 31;
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBarrio.Location = new System.Drawing.Point(203, 67);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(51, 18);
            this.labelBarrio.TabIndex = 18;
            this.labelBarrio.Text = "Barrio";
            this.labelBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calle
            // 
            this.Calle.AutoSize = true;
            this.Calle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calle.Location = new System.Drawing.Point(15, 5);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(44, 18);
            this.Calle.TabIndex = 17;
            this.Calle.Text = "Calle";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.BackgroundImage = global::AAA.Properties.Resources.TrashCan_24px;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(227, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 50);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(22, 286);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 50);
            this.btnClean.TabIndex = 49;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(227, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 50);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(22, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 50);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // labelGrilla
            // 
            this.labelGrilla.AutoSize = true;
            this.labelGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrilla.Location = new System.Drawing.Point(22, 339);
            this.labelGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrilla.Name = "labelGrilla";
            this.labelGrilla.Size = new System.Drawing.Size(160, 24);
            this.labelGrilla.TabIndex = 51;
            this.labelGrilla.Text = "Clientes Activos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.cuit_cliente,
            this.nombre,
            this.apellido,
            this.numero_telefono,
            this.id_barrio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(756, 219);
            this.dataGridView1.TabIndex = 52;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "ID";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Width = 50;
            // 
            // cuit_cliente
            // 
            this.cuit_cliente.HeaderText = "CUIL";
            this.cuit_cliente.Name = "cuit_cliente";
            this.cuit_cliente.ReadOnly = true;
            this.cuit_cliente.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 170;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 120;
            // 
            // numero_telefono
            // 
            this.numero_telefono.HeaderText = "Telefono";
            this.numero_telefono.Name = "numero_telefono";
            this.numero_telefono.ReadOnly = true;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "Barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Width = 120;
            // 
            // ABM_Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelGrilla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_Clientes";
            this.Text = "ABM_Frm_Clientes";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedor)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Button btnSearchCUIL;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.PictureBox pictureBoxProveedor;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.ComboBox boxBarrio;
        private System.Windows.Forms.MaskedTextBox maskTelefono;
        private System.Windows.Forms.Label labelNroCalle;
        private System.Windows.Forms.MaskedTextBox maskTxtNroCalle;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label Calle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
    }
}