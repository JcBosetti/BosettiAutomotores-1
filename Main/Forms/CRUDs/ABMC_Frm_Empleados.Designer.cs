
namespace AAA.Formularios_ABM
{
    partial class ABMC_Frm_Empleados
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
            this.GridEmpleado = new System.Windows.Forms.DataGridView();
            this.labelGrillaEmpleados = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.boxBarrio = new System.Windows.Forms.ComboBox();
            this.maskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.maskTxtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.btnSearchLegajo = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.maskLegajo = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxProveedor = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleado)).BeginInit();
            this.panelPersonal.SuspendLayout();
            this.panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedor)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridEmpleado
            // 
            this.GridEmpleado.AllowUserToAddRows = false;
            this.GridEmpleado.AllowUserToDeleteRows = false;
            this.GridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.id_tipo_documento,
            this.numero_documento,
            this.nombre,
            this.apellido,
            this.numero_telefono,
            this.id_barrio});
            this.GridEmpleado.Location = new System.Drawing.Point(2, 462);
            this.GridEmpleado.Name = "GridEmpleado";
            this.GridEmpleado.ReadOnly = true;
            this.GridEmpleado.RowHeadersWidth = 51;
            this.GridEmpleado.RowTemplate.Height = 25;
            this.GridEmpleado.Size = new System.Drawing.Size(768, 293);
            this.GridEmpleado.TabIndex = 61;
            // 
            // labelGrillaEmpleados
            // 
            this.labelGrillaEmpleados.AutoSize = true;
            this.labelGrillaEmpleados.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrillaEmpleados.Location = new System.Drawing.Point(12, 424);
            this.labelGrillaEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrillaEmpleados.Name = "labelGrillaEmpleados";
            this.labelGrillaEmpleados.Size = new System.Drawing.Size(244, 32);
            this.labelGrillaEmpleados.TabIndex = 60;
            this.labelGrillaEmpleados.Text = "Empleados Activos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.BackgroundImage = global::AAA.Properties.Resources.TrashCan_24px;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(217, 371);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 50);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.panelPersonal.Location = new System.Drawing.Point(381, 299);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(389, 146);
            this.panelPersonal.TabIndex = 59;
            // 
            // boxBarrio
            // 
            this.boxBarrio.FormattingEnabled = true;
            this.boxBarrio.Location = new System.Drawing.Point(203, 88);
            this.boxBarrio.Name = "boxBarrio";
            this.boxBarrio.Size = new System.Drawing.Size(121, 31);
            this.boxBarrio.TabIndex = 37;
            // 
            // maskTelefono
            // 
            this.maskTelefono.Location = new System.Drawing.Point(9, 88);
            this.maskTelefono.Mask = "000-000-0000";
            this.maskTelefono.Name = "maskTelefono";
            this.maskTelefono.Size = new System.Drawing.Size(125, 30);
            this.maskTelefono.TabIndex = 36;
            this.maskTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNroCalle
            // 
            this.labelNroCalle.AutoSize = true;
            this.labelNroCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNroCalle.Location = new System.Drawing.Point(261, 5);
            this.labelNroCalle.Name = "labelNroCalle";
            this.labelNroCalle.Size = new System.Drawing.Size(41, 23);
            this.labelNroCalle.TabIndex = 35;
            this.labelNroCalle.Text = "Nro";
            // 
            // maskTxtNroCalle
            // 
            this.maskTxtNroCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroCalle.Location = new System.Drawing.Point(261, 29);
            this.maskTxtNroCalle.Mask = "9999";
            this.maskTxtNroCalle.Name = "maskTxtNroCalle";
            this.maskTxtNroCalle.Size = new System.Drawing.Size(62, 30);
            this.maskTxtNroCalle.TabIndex = 34;
            this.maskTxtNroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtNroCalle.ValidatingType = typeof(int);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(15, 67);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(135, 23);
            this.labelTelefono.TabIndex = 32;
            this.labelTelefono.Text = "Nro Telefonico";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalle.Location = new System.Drawing.Point(9, 29);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(189, 30);
            this.txtCalle.TabIndex = 31;
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBarrio.Location = new System.Drawing.Point(203, 67);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(63, 23);
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
            this.Calle.Size = new System.Drawing.Size(54, 23);
            this.Calle.TabIndex = 17;
            this.Calle.Text = "Calle";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(12, 371);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 50);
            this.btnClean.TabIndex = 57;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.panelCliente.Controls.Add(this.txtNroDocumento);
            this.panelCliente.Controls.Add(this.label2);
            this.panelCliente.Controls.Add(this.comboBox1);
            this.panelCliente.Controls.Add(this.label1);
            this.panelCliente.Controls.Add(this.txtApellido);
            this.panelCliente.Controls.Add(this.labelApellido);
            this.panelCliente.Controls.Add(this.btnSearchLegajo);
            this.panelCliente.Controls.Add(this.labelCliente);
            this.panelCliente.Controls.Add(this.txtEmail);
            this.panelCliente.Controls.Add(this.labelEmail);
            this.panelCliente.Controls.Add(this.txtNombre);
            this.panelCliente.Controls.Add(this.labelNombre);
            this.panelCliente.Controls.Add(this.labelLegajo);
            this.panelCliente.Controls.Add(this.maskLegajo);
            this.panelCliente.Controls.Add(this.pictureBoxProveedor);
            this.panelCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelCliente.Location = new System.Drawing.Point(2, 54);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(768, 239);
            this.panelCliente.TabIndex = 54;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(447, 125);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(257, 30);
            this.txtApellido.TabIndex = 49;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(447, 100);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(79, 23);
            this.labelApellido.TabIndex = 48;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // btnSearchLegajo
            // 
            this.btnSearchLegajo.BackColor = System.Drawing.Color.Snow;
            this.btnSearchLegajo.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchLegajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchLegajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLegajo.Location = new System.Drawing.Point(388, 67);
            this.btnSearchLegajo.Name = "btnSearchLegajo";
            this.btnSearchLegajo.Size = new System.Drawing.Size(31, 26);
            this.btnSearchLegajo.TabIndex = 47;
            this.btnSearchLegajo.UseVisualStyleBackColor = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(360, 9);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(135, 32);
            this.labelCliente.TabIndex = 22;
            this.labelCliente.Text = "Empleado";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(166, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 30);
            this.txtEmail.TabIndex = 33;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(166, 108);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 23);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(447, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(257, 30);
            this.txtNombre.TabIndex = 31;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(447, 46);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(79, 23);
            this.labelNombre.TabIndex = 18;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLegajo.Location = new System.Drawing.Point(166, 46);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(69, 23);
            this.labelLegajo.TabIndex = 17;
            this.labelLegajo.Text = "Legajo";
            // 
            // maskLegajo
            // 
            this.maskLegajo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskLegajo.Location = new System.Drawing.Point(166, 67);
            this.maskLegajo.Mask = "999999";
            this.maskLegajo.Name = "maskLegajo";
            this.maskLegajo.Size = new System.Drawing.Size(217, 35);
            this.maskLegajo.TabIndex = 16;
            this.maskLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskLegajo.ValidatingType = typeof(int);
            // 
            // pictureBoxProveedor
            // 
            this.pictureBoxProveedor.BackgroundImage = global::AAA.Properties.Resources.Compras_48px;
            this.pictureBoxProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxProveedor.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxProveedor.Name = "pictureBoxProveedor";
            this.pictureBoxProveedor.Size = new System.Drawing.Size(160, 155);
            this.pictureBoxProveedor.TabIndex = 0;
            this.pictureBoxProveedor.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(217, 304);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 50);
            this.btnModificar.TabIndex = 56;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Wheat;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelEmpleado);
            this.panelPrincipal.Location = new System.Drawing.Point(2, 3);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(768, 47);
            this.panelPrincipal.TabIndex = 53;
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
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpleado.Location = new System.Drawing.Point(322, 8);
            this.labelEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(135, 32);
            this.labelEmpleado.TabIndex = 15;
            this.labelEmpleado.Text = "Empleado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(12, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 50);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 31);
            this.comboBox1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tipo de Documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNroDocumento.Location = new System.Drawing.Point(450, 196);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(257, 30);
            this.txtNroDocumento.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(450, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nro Docuemento ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 6;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 75;
            // 
            // id_tipo_documento
            // 
            this.id_tipo_documento.HeaderText = "Tipo Documento";
            this.id_tipo_documento.MinimumWidth = 6;
            this.id_tipo_documento.Name = "id_tipo_documento";
            this.id_tipo_documento.ReadOnly = true;
            this.id_tipo_documento.Width = 125;
            // 
            // numero_documento
            // 
            this.numero_documento.HeaderText = "Nro Documento";
            this.numero_documento.MinimumWidth = 6;
            this.numero_documento.Name = "numero_documento";
            this.numero_documento.ReadOnly = true;
            this.numero_documento.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 170;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 120;
            // 
            // numero_telefono
            // 
            this.numero_telefono.HeaderText = "Telefono";
            this.numero_telefono.MinimumWidth = 6;
            this.numero_telefono.Name = "numero_telefono";
            this.numero_telefono.ReadOnly = true;
            this.numero_telefono.Width = 125;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "Barrio";
            this.id_barrio.MinimumWidth = 6;
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Width = 120;
            // 
            // ABMC_Frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 767);
            this.Controls.Add(this.GridEmpleado);
            this.Controls.Add(this.labelGrillaEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnGuardar);
            this.Name = "ABMC_Frm_Empleados";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleado)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedor)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEmpleado;
        private System.Windows.Forms.Label labelGrillaEmpleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.ComboBox boxBarrio;
        private System.Windows.Forms.MaskedTextBox maskTelefono;
        private System.Windows.Forms.Label labelNroCalle;
        private System.Windows.Forms.MaskedTextBox maskTxtNroCalle;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label Calle;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnSearchLegajo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.MaskedTextBox maskLegajo;
        private System.Windows.Forms.PictureBox pictureBoxProveedor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
    }
}