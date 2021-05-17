
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_Service));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelDatosService = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelCuil = new System.Windows.Forms.Label();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.datePickerIni = new System.Windows.Forms.DateTimePicker();
            this.datePickerFin = new System.Windows.Forms.DateTimePicker();
            this.datePickerUltimo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUltimoSer = new System.Windows.Forms.Label();
            this.labelFechaUlt = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.masktxtKm = new System.Windows.Forms.MaskedTextBox();
            this.labelIni = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.labelGrilla = new System.Windows.Forms.Label();
            this.masktxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.TipoServicio = new System.Windows.Forms.Label();
            this.comboBoxTipoService = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCliente = new System.Windows.Forms.Label();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_finalizacion_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patente_automovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelDatosService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.labelPrincipal);
            this.panelTitulo.Controls.Add(this.btnAtras);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(748, 49);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelDatosService
            // 
            this.panelDatosService.BackColor = System.Drawing.Color.Silver;
            this.panelDatosService.Controls.Add(this.btnSearch);
            this.panelDatosService.Controls.Add(this.labelCliente);
            this.panelDatosService.Controls.Add(this.labelFin);
            this.panelDatosService.Controls.Add(this.labelIni);
            this.panelDatosService.Controls.Add(this.datePickerFin);
            this.panelDatosService.Controls.Add(this.datePickerIni);
            this.panelDatosService.Controls.Add(this.maskTxtCuil);
            this.panelDatosService.Controls.Add(this.labelCuil);
            this.panelDatosService.Location = new System.Drawing.Point(12, 55);
            this.panelDatosService.Name = "panelDatosService";
            this.panelDatosService.Size = new System.Drawing.Size(736, 174);
            this.panelDatosService.TabIndex = 1;
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
            this.btnAtras.Size = new System.Drawing.Size(59, 49);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrincipal.Location = new System.Drawing.Point(314, 8);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(109, 27);
            this.labelPrincipal.TabIndex = 22;
            this.labelPrincipal.Text = "Services ";
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuil.Location = new System.Drawing.Point(22, 22);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(120, 18);
            this.labelCuil.TabIndex = 0;
            this.labelCuil.Text = "CUIL del Cliente";
            // 
            // maskTxtCuil
            // 
            this.maskTxtCuil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCuil.Location = new System.Drawing.Point(22, 43);
            this.maskTxtCuil.Mask = "99-99999999-9";
            this.maskTxtCuil.Name = "maskTxtCuil";
            this.maskTxtCuil.Size = new System.Drawing.Size(217, 29);
            this.maskTxtCuil.TabIndex = 1;
            this.maskTxtCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datePickerIni
            // 
            this.datePickerIni.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerIni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerIni.Location = new System.Drawing.Point(322, 46);
            this.datePickerIni.Name = "datePickerIni";
            this.datePickerIni.Size = new System.Drawing.Size(300, 26);
            this.datePickerIni.TabIndex = 11;
            this.datePickerIni.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // datePickerFin
            // 
            this.datePickerFin.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerFin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerFin.Location = new System.Drawing.Point(322, 116);
            this.datePickerFin.Name = "datePickerFin";
            this.datePickerFin.Size = new System.Drawing.Size(300, 26);
            this.datePickerFin.TabIndex = 12;
            this.datePickerFin.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // datePickerUltimo
            // 
            this.datePickerUltimo.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerUltimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerUltimo.Location = new System.Drawing.Point(13, 64);
            this.datePickerUltimo.Name = "datePickerUltimo";
            this.datePickerUltimo.Size = new System.Drawing.Size(304, 26);
            this.datePickerUltimo.TabIndex = 13;
            this.datePickerUltimo.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.masktxtKm);
            this.panel1.Controls.Add(this.labelKm);
            this.panel1.Controls.Add(this.labelFechaUlt);
            this.panel1.Controls.Add(this.labelUltimoSer);
            this.panel1.Controls.Add(this.datePickerUltimo);
            this.panel1.Location = new System.Drawing.Point(12, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 196);
            this.panel1.TabIndex = 13;
            // 
            // labelUltimoSer
            // 
            this.labelUltimoSer.AutoSize = true;
            this.labelUltimoSer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUltimoSer.Location = new System.Drawing.Point(94, 9);
            this.labelUltimoSer.Margin = new System.Windows.Forms.Padding(0);
            this.labelUltimoSer.Name = "labelUltimoSer";
            this.labelUltimoSer.Size = new System.Drawing.Size(145, 24);
            this.labelUltimoSer.TabIndex = 23;
            this.labelUltimoSer.Text = "Ultimo Service";
            // 
            // labelFechaUlt
            // 
            this.labelFechaUlt.AutoSize = true;
            this.labelFechaUlt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaUlt.Location = new System.Drawing.Point(13, 43);
            this.labelFechaUlt.Margin = new System.Windows.Forms.Padding(0);
            this.labelFechaUlt.Name = "labelFechaUlt";
            this.labelFechaUlt.Size = new System.Drawing.Size(52, 18);
            this.labelFechaUlt.TabIndex = 24;
            this.labelFechaUlt.Text = "Fecha";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKm.Location = new System.Drawing.Point(13, 108);
            this.labelKm.Margin = new System.Windows.Forms.Padding(0);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(249, 18);
            this.labelKm.TabIndex = 25;
            this.labelKm.Text = "Kilometros desde el ultimo Service";
            // 
            // masktxtKm
            // 
            this.masktxtKm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masktxtKm.Location = new System.Drawing.Point(107, 138);
            this.masktxtKm.Mask = "9999999";
            this.masktxtKm.Name = "masktxtKm";
            this.masktxtKm.Size = new System.Drawing.Size(78, 26);
            this.masktxtKm.TabIndex = 26;
            this.masktxtKm.ValidatingType = typeof(int);
            // 
            // labelIni
            // 
            this.labelIni.AutoSize = true;
            this.labelIni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIni.Location = new System.Drawing.Point(322, 22);
            this.labelIni.Name = "labelIni";
            this.labelIni.Size = new System.Drawing.Size(92, 18);
            this.labelIni.TabIndex = 13;
            this.labelIni.Text = "Fecha Inicio";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFin.Location = new System.Drawing.Point(322, 95);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(139, 18);
            this.labelFin.TabIndex = 14;
            this.labelFin.Text = "Fecha Finalizacion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.comboBoxTipoService);
            this.panel2.Controls.Add(this.TipoServicio);
            this.panel2.Controls.Add(this.txtPatente);
            this.panel2.Controls.Add(this.masktxtLegajo);
            this.panel2.Controls.Add(this.labelPatente);
            this.panel2.Controls.Add(this.labelLegajo);
            this.panel2.Controls.Add(this.labelDetalle);
            this.panel2.Location = new System.Drawing.Point(374, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 196);
            this.panel2.TabIndex = 27;
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPatente.Location = new System.Drawing.Point(266, 43);
            this.labelPatente.Margin = new System.Windows.Forms.Padding(0);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(62, 18);
            this.labelPatente.TabIndex = 25;
            this.labelPatente.Text = "Patente";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLegajo.Location = new System.Drawing.Point(13, 43);
            this.labelLegajo.Margin = new System.Windows.Forms.Padding(0);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(132, 18);
            this.labelLegajo.TabIndex = 24;
            this.labelLegajo.Text = "Legajo Empleado";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetalle.Location = new System.Drawing.Point(146, 9);
            this.labelDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(86, 24);
            this.labelDetalle.TabIndex = 23;
            this.labelDetalle.Text = "Detalles";
            // 
            // labelGrilla
            // 
            this.labelGrilla.AutoSize = true;
            this.labelGrilla.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrilla.Location = new System.Drawing.Point(264, 512);
            this.labelGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrilla.Name = "labelGrilla";
            this.labelGrilla.Size = new System.Drawing.Size(229, 27);
            this.labelGrilla.TabIndex = 23;
            this.labelGrilla.Text = "Historial de Services";
            // 
            // masktxtLegajo
            // 
            this.masktxtLegajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masktxtLegajo.Location = new System.Drawing.Point(33, 67);
            this.masktxtLegajo.Mask = "9999999";
            this.masktxtLegajo.Name = "masktxtLegajo";
            this.masktxtLegajo.Size = new System.Drawing.Size(86, 26);
            this.masktxtLegajo.TabIndex = 27;
            this.masktxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masktxtLegajo.ValidatingType = typeof(int);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatente.Location = new System.Drawing.Point(246, 64);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 26);
            this.txtPatente.TabIndex = 28;
            // 
            // TipoServicio
            // 
            this.TipoServicio.AutoSize = true;
            this.TipoServicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipoServicio.Location = new System.Drawing.Point(141, 122);
            this.TipoServicio.Margin = new System.Windows.Forms.Padding(0);
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.Size = new System.Drawing.Size(91, 18);
            this.TipoServicio.TabIndex = 29;
            this.TipoServicio.Text = "TipoService";
            // 
            // comboBoxTipoService
            // 
            this.comboBoxTipoService.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTipoService.FormattingEnabled = true;
            this.comboBoxTipoService.Location = new System.Drawing.Point(33, 143);
            this.comboBoxTipoService.Name = "comboBoxTipoService";
            this.comboBoxTipoService.Size = new System.Drawing.Size(319, 26);
            this.comboBoxTipoService.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdServicio,
            this.cuil_cliente,
            this.fecha_inicio_service,
            this.fecha_finalizacion_service,
            this.legajo,
            this.patente_automovil,
            this.tipo_servicio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 542);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(736, 235);
            this.dataGridView1.TabIndex = 31;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(62, 116);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(142, 22);
            this.labelCliente.TabIndex = 15;
            this.labelCliente.Text = "Nombre Cliente";
            // 
            // IdServicio
            // 
            this.IdServicio.HeaderText = "ID";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            this.IdServicio.Width = 50;
            // 
            // cuil_cliente
            // 
            this.cuil_cliente.HeaderText = "CUIL Cliente";
            this.cuil_cliente.Name = "cuil_cliente";
            this.cuil_cliente.ReadOnly = true;
            this.cuil_cliente.Width = 120;
            // 
            // fecha_inicio_service
            // 
            this.fecha_inicio_service.HeaderText = "Fecha de Inicio";
            this.fecha_inicio_service.Name = "fecha_inicio_service";
            this.fecha_inicio_service.ReadOnly = true;
            this.fecha_inicio_service.Width = 150;
            // 
            // fecha_finalizacion_service
            // 
            this.fecha_finalizacion_service.HeaderText = "Fecha de Finalizacion";
            this.fecha_finalizacion_service.Name = "fecha_finalizacion_service";
            this.fecha_finalizacion_service.ReadOnly = true;
            this.fecha_finalizacion_service.Width = 150;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo Empleado";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 80;
            // 
            // patente_automovil
            // 
            this.patente_automovil.HeaderText = "Patente";
            this.patente_automovil.Name = "patente_automovil";
            this.patente_automovil.ReadOnly = true;
            this.patente_automovil.Width = 80;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo de Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            this.tipo_servicio.Width = 60;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(12, 458);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 53);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(264, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(239, 53);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(520, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 55);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Snow;
            this.btnSearch.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(658, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 120);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // ABM_Frm_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(753, 775);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelGrilla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatosService);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_Service";
            this.Text = "Servicio Automotores";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDatosService.ResumeLayout(false);
            this.panelDatosService.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelDatosService;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelIni;
        private System.Windows.Forms.DateTimePicker datePickerFin;
        private System.Windows.Forms.DateTimePicker datePickerIni;
        private System.Windows.Forms.DateTimePicker datePickerUltimo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox masktxtKm;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelFechaUlt;
        private System.Windows.Forms.Label labelUltimoSer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.ComboBox comboBoxTipoService;
        private System.Windows.Forms.Label TipoServicio;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.MaskedTextBox masktxtLegajo;
        private System.Windows.Forms.Label labelGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_finalizacion_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente_automovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
    }
}