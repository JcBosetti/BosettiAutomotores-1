
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_FacturasRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_FacturasRepuestos));
            this.panelFactura = new System.Windows.Forms.Panel();
            this.labelFactura = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.maskTxtNroFactura = new System.Windows.Forms.MaskedTextBox();
            this.labelCuil = new System.Windows.Forms.Label();
            this.maskTxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelDetalleFactura = new System.Windows.Forms.Panel();
            this.btnSearchFecha = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.maskTxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.boxRepuestos = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelRepuestos = new System.Windows.Forms.Label();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.rBtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rBtnEfectivo = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.maskTxtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.labelPreUni = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFactura.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelDetalleFactura.SuspendLayout();
            this.panelFormasPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFactura
            // 
            this.panelFactura.BackColor = System.Drawing.Color.GhostWhite;
            this.panelFactura.Controls.Add(this.labelFactura);
            this.panelFactura.Controls.Add(this.labelClientes);
            this.panelFactura.Controls.Add(this.button2);
            this.panelFactura.Controls.Add(this.labelNombreApellido);
            this.panelFactura.Controls.Add(this.labelNumeroFactura);
            this.panelFactura.Controls.Add(this.labelEmpleado);
            this.panelFactura.Controls.Add(this.maskTxtNroFactura);
            this.panelFactura.Controls.Add(this.labelCuil);
            this.panelFactura.Controls.Add(this.maskTxtLegajo);
            this.panelFactura.Controls.Add(this.maskTxtCuil);
            this.panelFactura.Location = new System.Drawing.Point(8, 53);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(601, 193);
            this.panelFactura.TabIndex = 1;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFactura.Location = new System.Drawing.Point(244, 0);
            this.labelFactura.Margin = new System.Windows.Forms.Padding(0);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(94, 27);
            this.labelFactura.TabIndex = 22;
            this.labelFactura.Text = "Factura";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClientes.Location = new System.Drawing.Point(394, 123);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(137, 18);
            this.labelClientes.TabIndex = 15;
            this.labelClientes.Text = "NombreDelCliente";
            this.labelClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(26, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(140, 138);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(114, 16);
            this.labelNombreApellido.TabIndex = 9;
            this.labelNombreApellido.Text = "Apellido, Nombre";
            this.labelNombreApellido.Visible = false;
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Location = new System.Drawing.Point(27, 44);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(105, 16);
            this.labelNumeroFactura.TabIndex = 8;
            this.labelNumeroFactura.Text = "NumeroFactura";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new System.Drawing.Point(15, 116);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(117, 16);
            this.labelEmpleado.TabIndex = 7;
            this.labelEmpleado.Text = "Legajo Empleado";
            // 
            // maskTxtNroFactura
            // 
            this.maskTxtNroFactura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroFactura.Location = new System.Drawing.Point(59, 65);
            this.maskTxtNroFactura.Mask = "99-99999999";
            this.maskTxtNroFactura.Name = "maskTxtNroFactura";
            this.maskTxtNroFactura.Size = new System.Drawing.Size(126, 29);
            this.maskTxtNroFactura.TabIndex = 6;
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuil.Location = new System.Drawing.Point(402, 53);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(120, 18);
            this.labelCuil.TabIndex = 4;
            this.labelCuil.Text = "CUIL del Cliente";
            // 
            // maskTxtLegajo
            // 
            this.maskTxtLegajo.Location = new System.Drawing.Point(27, 135);
            this.maskTxtLegajo.Mask = "99999";
            this.maskTxtLegajo.Name = "maskTxtLegajo";
            this.maskTxtLegajo.Size = new System.Drawing.Size(90, 23);
            this.maskTxtLegajo.TabIndex = 2;
            this.maskTxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtLegajo.ValidatingType = typeof(int);
            // 
            // maskTxtCuil
            // 
            this.maskTxtCuil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCuil.Location = new System.Drawing.Point(358, 74);
            this.maskTxtCuil.Mask = "99-99999999-9";
            this.maskTxtCuil.Name = "maskTxtCuil";
            this.maskTxtCuil.Size = new System.Drawing.Size(217, 29);
            this.maskTxtCuil.TabIndex = 0;
            this.maskTxtCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(617, 47);
            this.panelPrincipal.TabIndex = 23;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::AAA.Properties.Resources.FlechaAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(-1, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(65, 44);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrincipal.Location = new System.Drawing.Point(208, 8);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(200, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Facturas Repuestos";
            // 
            // panelDetalleFactura
            // 
            this.panelDetalleFactura.BackColor = System.Drawing.Color.LightGray;
            this.panelDetalleFactura.Controls.Add(this.btnGuardar);
            this.panelDetalleFactura.Controls.Add(this.maskedTextBox3);
            this.panelDetalleFactura.Controls.Add(this.labelPreUni);
            this.panelDetalleFactura.Controls.Add(this.maskTxtCantidad);
            this.panelDetalleFactura.Controls.Add(this.labelCantidad);
            this.panelDetalleFactura.Controls.Add(this.maskedTextBox2);
            this.panelDetalleFactura.Controls.Add(this.labelIVA);
            this.panelDetalleFactura.Controls.Add(this.maskedTextBox1);
            this.panelDetalleFactura.Controls.Add(this.labelSubTotal);
            this.panelDetalleFactura.Controls.Add(this.btnSearchFecha);
            this.panelDetalleFactura.Controls.Add(this.btnClean);
            this.panelDetalleFactura.Controls.Add(this.maskTxtMonto);
            this.panelDetalleFactura.Controls.Add(this.labelMonto);
            this.panelDetalleFactura.Controls.Add(this.boxRepuestos);
            this.panelDetalleFactura.Controls.Add(this.labelFecha);
            this.panelDetalleFactura.Controls.Add(this.datePicker);
            this.panelDetalleFactura.Controls.Add(this.labelRepuestos);
            this.panelDetalleFactura.Controls.Add(this.labelFormaPago);
            this.panelDetalleFactura.Controls.Add(this.panelFormasPago);
            this.panelDetalleFactura.Location = new System.Drawing.Point(8, 252);
            this.panelDetalleFactura.Name = "panelDetalleFactura";
            this.panelDetalleFactura.Size = new System.Drawing.Size(601, 248);
            this.panelDetalleFactura.TabIndex = 24;
            // 
            // btnSearchFecha
            // 
            this.btnSearchFecha.BackColor = System.Drawing.Color.Snow;
            this.btnSearchFecha.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFecha.Location = new System.Drawing.Point(267, 43);
            this.btnSearchFecha.Name = "btnSearchFecha";
            this.btnSearchFecha.Size = new System.Drawing.Size(31, 26);
            this.btnSearchFecha.TabIndex = 16;
            this.btnSearchFecha.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(449, 105);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(144, 59);
            this.btnClean.TabIndex = 4;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // maskTxtMonto
            // 
            this.maskTxtMonto.Location = new System.Drawing.Point(269, 201);
            this.maskTxtMonto.Mask = "99999999,99";
            this.maskTxtMonto.Name = "maskTxtMonto";
            this.maskTxtMonto.Size = new System.Drawing.Size(146, 23);
            this.maskTxtMonto.TabIndex = 11;
            this.maskTxtMonto.ValidatingType = typeof(int);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonto.Location = new System.Drawing.Point(267, 180);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(87, 18);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto Total";
            // 
            // boxRepuestos
            // 
            this.boxRepuestos.FormattingEnabled = true;
            this.boxRepuestos.Location = new System.Drawing.Point(25, 45);
            this.boxRepuestos.Name = "boxRepuestos";
            this.boxRepuestos.Size = new System.Drawing.Size(218, 24);
            this.boxRepuestos.TabIndex = 12;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.Location = new System.Drawing.Point(267, 22);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(56, 18);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha ";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Location = new System.Drawing.Point(304, 43);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(289, 26);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // labelRepuestos
            // 
            this.labelRepuestos.AutoSize = true;
            this.labelRepuestos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRepuestos.Location = new System.Drawing.Point(25, 24);
            this.labelRepuestos.Name = "labelRepuestos";
            this.labelRepuestos.Size = new System.Drawing.Size(83, 18);
            this.labelRepuestos.TabIndex = 11;
            this.labelRepuestos.Text = "Repuestos";
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormaPago.Location = new System.Drawing.Point(27, 160);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(126, 18);
            this.labelFormaPago.TabIndex = 10;
            this.labelFormaPago.Text = "Formas de Pago";
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.rBtnTarjeta);
            this.panelFormasPago.Controls.Add(this.rBtnEfectivo);
            this.panelFormasPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelFormasPago.Location = new System.Drawing.Point(27, 170);
            this.panelFormasPago.Name = "panelFormasPago";
            this.panelFormasPago.Size = new System.Drawing.Size(164, 41);
            this.panelFormasPago.TabIndex = 0;
            // 
            // rBtnTarjeta
            // 
            this.rBtnTarjeta.AutoSize = true;
            this.rBtnTarjeta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtnTarjeta.Location = new System.Drawing.Point(84, 12);
            this.rBtnTarjeta.Name = "rBtnTarjeta";
            this.rBtnTarjeta.Size = new System.Drawing.Size(68, 20);
            this.rBtnTarjeta.TabIndex = 1;
            this.rBtnTarjeta.TabStop = true;
            this.rBtnTarjeta.Text = "Tarjeta";
            this.rBtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rBtnEfectivo
            // 
            this.rBtnEfectivo.AutoSize = true;
            this.rBtnEfectivo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtnEfectivo.Location = new System.Drawing.Point(6, 12);
            this.rBtnEfectivo.Name = "rBtnEfectivo";
            this.rBtnEfectivo.Size = new System.Drawing.Size(75, 20);
            this.rBtnEfectivo.TabIndex = 0;
            this.rBtnEfectivo.TabStop = true;
            this.rBtnEfectivo.Text = "Efectivo";
            this.rBtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(269, 107);
            this.maskedTextBox1.Mask = "99999999,99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 23);
            this.maskedTextBox1.TabIndex = 17;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubTotal.Location = new System.Drawing.Point(267, 86);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(68, 18);
            this.labelSubTotal.TabIndex = 18;
            this.labelSubTotal.Text = "SubTotal";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(269, 154);
            this.maskedTextBox2.Mask = "99999999,99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(146, 23);
            this.maskedTextBox2.TabIndex = 19;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIVA.Location = new System.Drawing.Point(269, 133);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(32, 18);
            this.labelIVA.TabIndex = 20;
            this.labelIVA.Text = "IVA";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.Location = new System.Drawing.Point(27, 86);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(73, 20);
            this.labelCantidad.TabIndex = 21;
            this.labelCantidad.Text = "Cantidad";
            // 
            // maskTxtCantidad
            // 
            this.maskTxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCantidad.Location = new System.Drawing.Point(27, 107);
            this.maskTxtCantidad.Mask = "99999";
            this.maskTxtCantidad.Name = "maskTxtCantidad";
            this.maskTxtCantidad.Size = new System.Drawing.Size(81, 26);
            this.maskTxtCantidad.TabIndex = 22;
            this.maskTxtCantidad.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox3.Location = new System.Drawing.Point(165, 105);
            this.maskedTextBox3.Mask = "99999,99";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(66, 26);
            this.maskedTextBox3.TabIndex = 23;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // labelPreUni
            // 
            this.labelPreUni.AutoSize = true;
            this.labelPreUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreUni.Location = new System.Drawing.Point(165, 84);
            this.labelPreUni.Name = "labelPreUni";
            this.labelPreUni.Size = new System.Drawing.Size(69, 20);
            this.labelPreUni.TabIndex = 24;
            this.labelPreUni.Text = "Precio/U";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(449, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 68);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // gridFacturas
            // 
            this.gridFacturas.AllowUserToAddRows = false;
            this.gridFacturas.AllowUserToDeleteRows = false;
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.numero_factura,
            this.cuil_cliente,
            this.monto_total});
            this.gridFacturas.Location = new System.Drawing.Point(8, 506);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.RowTemplate.Height = 25;
            this.gridFacturas.Size = new System.Drawing.Size(601, 254);
            this.gridFacturas.TabIndex = 25;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 80;
            // 
            // numero_factura
            // 
            this.numero_factura.HeaderText = "Numero de Factura";
            this.numero_factura.Name = "numero_factura";
            this.numero_factura.ReadOnly = true;
            this.numero_factura.Width = 180;
            // 
            // cuil_cliente
            // 
            this.cuil_cliente.HeaderText = "Cuil Cliente";
            this.cuil_cliente.Name = "cuil_cliente";
            this.cuil_cliente.ReadOnly = true;
            this.cuil_cliente.Width = 120;
            // 
            // monto_total
            // 
            this.monto_total.HeaderText = "Monto Total";
            this.monto_total.Name = "monto_total";
            this.monto_total.ReadOnly = true;
            this.monto_total.Width = 150;
            // 
            // ABM_Frm_FacturasRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 761);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.panelDetalleFactura);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelFactura);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_FacturasRepuestos";
            this.Text = "Factura Repuestos";
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelDetalleFactura.ResumeLayout(false);
            this.panelDetalleFactura.PerformLayout();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.MaskedTextBox maskTxtNroFactura;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtLegajo;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Panel panelDetalleFactura;
        private System.Windows.Forms.Button btnSearchFecha;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.MaskedTextBox maskTxtMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.ComboBox boxRepuestos;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelRepuestos;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.RadioButton rBtnTarjeta;
        private System.Windows.Forms.RadioButton rBtnEfectivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label labelPreUni;
        private System.Windows.Forms.MaskedTextBox maskTxtCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_total;
    }
}