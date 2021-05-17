
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_Proveedores));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.pictureBoxProveedor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCuit = new System.Windows.Forms.Label();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.labelTipoIVA = new System.Windows.Forms.Label();
            this.txtTipoIVA = new System.Windows.Forms.TextBox();
            this.maskTxtCBU = new System.Windows.Forms.MaskedTextBox();
            this.labelCBU = new System.Windows.Forms.Label();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.maskTxtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.Label();
            this.maskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.boxCiudad = new System.Windows.Forms.ComboBox();
            this.Empresa = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSearchCUIT = new System.Windows.Forms.Button();
            this.btnSearchRazSoc = new System.Windows.Forms.Button();
            this.labelGrilla = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            this.panelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedor)).BeginInit();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(775, 47);
            this.panelPrincipal.TabIndex = 12;
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
            this.labelPrincipal.Location = new System.Drawing.Point(313, 8);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(131, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Proveedores";
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.BackColor = System.Drawing.Color.FloralWhite;
            this.panelEmpresa.Controls.Add(this.btnSearchRazSoc);
            this.panelEmpresa.Controls.Add(this.btnSearchCUIT);
            this.panelEmpresa.Controls.Add(this.Empresa);
            this.panelEmpresa.Controls.Add(this.labelCBU);
            this.panelEmpresa.Controls.Add(this.maskTxtCBU);
            this.panelEmpresa.Controls.Add(this.txtTipoIVA);
            this.panelEmpresa.Controls.Add(this.labelTipoIVA);
            this.panelEmpresa.Controls.Add(this.txtRazonSocial);
            this.panelEmpresa.Controls.Add(this.labelProveedor);
            this.panelEmpresa.Controls.Add(this.labelCuit);
            this.panelEmpresa.Controls.Add(this.maskTxtCuil);
            this.panelEmpresa.Controls.Add(this.pictureBoxProveedor);
            this.panelEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelEmpresa.Location = new System.Drawing.Point(12, 53);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(762, 158);
            this.panelEmpresa.TabIndex = 13;
            // 
            // pictureBoxProveedor
            // 
            this.pictureBoxProveedor.BackgroundImage = global::AAA.Properties.Resources.Logo_128px;
            this.pictureBoxProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxProveedor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProveedor.Name = "pictureBoxProveedor";
            this.pictureBoxProveedor.Size = new System.Drawing.Size(142, 141);
            this.pictureBoxProveedor.TabIndex = 0;
            this.pictureBoxProveedor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuit.Location = new System.Drawing.Point(166, 46);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(145, 18);
            this.labelCuit.TabIndex = 17;
            this.labelCuit.Text = "CUIT del Proveedor";
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
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProveedor.Location = new System.Drawing.Point(447, 46);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(100, 18);
            this.labelProveedor.TabIndex = 18;
            this.labelProveedor.Text = "Razon Social";
            this.labelProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazonSocial.Location = new System.Drawing.Point(447, 67);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(257, 26);
            this.txtRazonSocial.TabIndex = 31;
            // 
            // labelTipoIVA
            // 
            this.labelTipoIVA.AutoSize = true;
            this.labelTipoIVA.Location = new System.Drawing.Point(166, 108);
            this.labelTipoIVA.Name = "labelTipoIVA";
            this.labelTipoIVA.Size = new System.Drawing.Size(66, 18);
            this.labelTipoIVA.TabIndex = 32;
            this.labelTipoIVA.Text = "Tipo IVA";
            // 
            // txtTipoIVA
            // 
            this.txtTipoIVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoIVA.Location = new System.Drawing.Point(166, 129);
            this.txtTipoIVA.Name = "txtTipoIVA";
            this.txtTipoIVA.Size = new System.Drawing.Size(217, 26);
            this.txtTipoIVA.TabIndex = 33;
            // 
            // maskTxtCBU
            // 
            this.maskTxtCBU.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCBU.Location = new System.Drawing.Point(447, 126);
            this.maskTxtCBU.Mask = "9999999999999";
            this.maskTxtCBU.Name = "maskTxtCBU";
            this.maskTxtCBU.Size = new System.Drawing.Size(294, 29);
            this.maskTxtCBU.TabIndex = 34;
            this.maskTxtCBU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtCBU.ValidatingType = typeof(int);
            // 
            // labelCBU
            // 
            this.labelCBU.AutoSize = true;
            this.labelCBU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCBU.Location = new System.Drawing.Point(447, 105);
            this.labelCBU.Name = "labelCBU";
            this.labelCBU.Size = new System.Drawing.Size(42, 18);
            this.labelCBU.TabIndex = 35;
            this.labelCBU.Text = "CBU";
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPersonal.Controls.Add(this.boxCiudad);
            this.panelPersonal.Controls.Add(this.maskTelefono);
            this.panelPersonal.Controls.Add(this.labelNroCalle);
            this.panelPersonal.Controls.Add(this.maskTxtNroCalle);
            this.panelPersonal.Controls.Add(this.labelTelefono);
            this.panelPersonal.Controls.Add(this.txtCalle);
            this.panelPersonal.Controls.Add(this.labelCiudad);
            this.panelPersonal.Controls.Add(this.Calle);
            this.panelPersonal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPersonal.Location = new System.Drawing.Point(381, 217);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(394, 135);
            this.panelPersonal.TabIndex = 36;
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
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCiudad.Location = new System.Drawing.Point(203, 67);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(59, 18);
            this.labelCiudad.TabIndex = 18;
            this.labelCiudad.Text = "Ciudad";
            this.labelCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // maskTelefono
            // 
            this.maskTelefono.Location = new System.Drawing.Point(9, 88);
            this.maskTelefono.Mask = "000-000-0000";
            this.maskTelefono.Name = "maskTelefono";
            this.maskTelefono.Size = new System.Drawing.Size(125, 26);
            this.maskTelefono.TabIndex = 36;
            this.maskTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxCiudad
            // 
            this.boxCiudad.FormattingEnabled = true;
            this.boxCiudad.Location = new System.Drawing.Point(203, 88);
            this.boxCiudad.Name = "boxCiudad";
            this.boxCiudad.Size = new System.Drawing.Size(121, 26);
            this.boxCiudad.TabIndex = 37;
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empresa.Location = new System.Drawing.Point(326, 0);
            this.Empresa.Margin = new System.Windows.Forms.Padding(0);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(93, 24);
            this.Empresa.TabIndex = 22;
            this.Empresa.Text = "Empresa";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.BackgroundImage = global::AAA.Properties.Resources.TrashCan_24px;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(217, 284);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 50);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(12, 284);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 50);
            this.btnClean.TabIndex = 45;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(217, 217);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 50);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(12, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 50);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSearchCUIT
            // 
            this.btnSearchCUIT.BackColor = System.Drawing.Color.Snow;
            this.btnSearchCUIT.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchCUIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCUIT.Location = new System.Drawing.Point(388, 67);
            this.btnSearchCUIT.Name = "btnSearchCUIT";
            this.btnSearchCUIT.Size = new System.Drawing.Size(31, 26);
            this.btnSearchCUIT.TabIndex = 47;
            this.btnSearchCUIT.UseVisualStyleBackColor = false;
            // 
            // btnSearchRazSoc
            // 
            this.btnSearchRazSoc.BackColor = System.Drawing.Color.Snow;
            this.btnSearchRazSoc.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchRazSoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchRazSoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRazSoc.Location = new System.Drawing.Point(710, 66);
            this.btnSearchRazSoc.Name = "btnSearchRazSoc";
            this.btnSearchRazSoc.Size = new System.Drawing.Size(31, 26);
            this.btnSearchRazSoc.TabIndex = 48;
            this.btnSearchRazSoc.UseVisualStyleBackColor = false;
            // 
            // labelGrilla
            // 
            this.labelGrilla.AutoSize = true;
            this.labelGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrilla.Location = new System.Drawing.Point(12, 346);
            this.labelGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrilla.Name = "labelGrilla";
            this.labelGrilla.Size = new System.Drawing.Size(205, 24);
            this.labelGrilla.TabIndex = 49;
            this.labelGrilla.Text = "Proveedores Activos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.cuit_proveedor,
            this.razon_social,
            this.cbu,
            this.numero_telefono,
            this.id_ciudad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(762, 219);
            this.dataGridView1.TabIndex = 50;
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "ID";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Width = 50;
            // 
            // cuit_proveedor
            // 
            this.cuit_proveedor.HeaderText = "CUIT";
            this.cuit_proveedor.Name = "cuit_proveedor";
            this.cuit_proveedor.ReadOnly = true;
            this.cuit_proveedor.Width = 150;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 170;
            // 
            // cbu
            // 
            this.cbu.HeaderText = "CBU";
            this.cbu.Name = "cbu";
            this.cbu.ReadOnly = true;
            this.cbu.Width = 120;
            // 
            // numero_telefono
            // 
            this.numero_telefono.HeaderText = "Telefono";
            this.numero_telefono.Name = "numero_telefono";
            this.numero_telefono.ReadOnly = true;
            // 
            // id_ciudad
            // 
            this.id_ciudad.HeaderText = "Ciudad";
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            this.id_ciudad.Width = 120;
            // 
            // ABM_Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelGrilla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.panelEmpresa);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_Proveedores";
            this.Text = "Proveedores";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
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
        private System.Windows.Forms.Panel panelEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCuit;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelCBU;
        private System.Windows.Forms.MaskedTextBox maskTxtCBU;
        private System.Windows.Forms.TextBox txtTipoIVA;
        private System.Windows.Forms.Label labelTipoIVA;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label labelNroCalle;
        private System.Windows.Forms.MaskedTextBox maskTxtNroCalle;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label Calle;
        private System.Windows.Forms.MaskedTextBox maskTelefono;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.ComboBox boxCiudad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSearchRazSoc;
        private System.Windows.Forms.Button btnSearchCUIT;
        private System.Windows.Forms.Label labelGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
    }
}