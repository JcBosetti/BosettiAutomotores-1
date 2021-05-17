
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_FacturasServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_FacturasServices));
            this.panelDetalleFactura = new System.Windows.Forms.Panel();
            this.btnSearchFecha = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.maskTxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTipoService = new System.Windows.Forms.Label();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.rBtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rBtnEfectivo = new System.Windows.Forms.RadioButton();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.labelCuil = new System.Windows.Forms.Label();
            this.maskTxtNroFactura = new System.Windows.Forms.MaskedTextBox();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.btnSearchFactura = new System.Windows.Forms.Button();
            this.labelClientes = new System.Windows.Forms.Label();
            this.panelFactura = new System.Windows.Forms.Panel();
            this.labelFactura = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.panelDetalleFactura.SuspendLayout();
            this.panelFormasPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalleFactura
            // 
            this.panelDetalleFactura.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelDetalleFactura.Controls.Add(this.btnSearchFecha);
            this.panelDetalleFactura.Controls.Add(this.btnClean);
            this.panelDetalleFactura.Controls.Add(this.maskTxtMonto);
            this.panelDetalleFactura.Controls.Add(this.labelMonto);
            this.panelDetalleFactura.Controls.Add(this.comboBox1);
            this.panelDetalleFactura.Controls.Add(this.labelFecha);
            this.panelDetalleFactura.Controls.Add(this.datePicker);
            this.panelDetalleFactura.Controls.Add(this.labelTipoService);
            this.panelDetalleFactura.Controls.Add(this.labelFormaPago);
            this.panelDetalleFactura.Controls.Add(this.panelFormasPago);
            this.panelDetalleFactura.Location = new System.Drawing.Point(2, 252);
            this.panelDetalleFactura.Name = "panelDetalleFactura";
            this.panelDetalleFactura.Size = new System.Drawing.Size(601, 175);
            this.panelDetalleFactura.TabIndex = 1;
            // 
            // btnSearchFecha
            // 
            this.btnSearchFecha.BackColor = System.Drawing.Color.Snow;
            this.btnSearchFecha.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFecha.Location = new System.Drawing.Point(267, 49);
            this.btnSearchFecha.Name = "btnSearchFecha";
            this.btnSearchFecha.Size = new System.Drawing.Size(31, 29);
            this.btnSearchFecha.TabIndex = 16;
            this.btnSearchFecha.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(528, 100);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(73, 75);
            this.btnClean.TabIndex = 4;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // maskTxtMonto
            // 
            this.maskTxtMonto.Location = new System.Drawing.Point(306, 121);
            this.maskTxtMonto.Mask = "99999999,99";
            this.maskTxtMonto.Name = "maskTxtMonto";
            this.maskTxtMonto.Size = new System.Drawing.Size(113, 26);
            this.maskTxtMonto.TabIndex = 11;
            this.maskTxtMonto.ValidatingType = typeof(int);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonto.Location = new System.Drawing.Point(304, 100);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(87, 18);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 26);
            this.comboBox1.TabIndex = 12;
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
            this.datePicker.Location = new System.Drawing.Point(304, 49);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(289, 26);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // labelTipoService
            // 
            this.labelTipoService.AutoSize = true;
            this.labelTipoService.Location = new System.Drawing.Point(22, 100);
            this.labelTipoService.Name = "labelTipoService";
            this.labelTipoService.Size = new System.Drawing.Size(129, 18);
            this.labelTipoService.TabIndex = 11;
            this.labelTipoService.Text = "Tipos de Servicio";
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Location = new System.Drawing.Point(22, 22);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(126, 18);
            this.labelFormaPago.TabIndex = 10;
            this.labelFormaPago.Text = "Formas de Pago";
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.rBtnTarjeta);
            this.panelFormasPago.Controls.Add(this.rBtnEfectivo);
            this.panelFormasPago.Location = new System.Drawing.Point(22, 43);
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
            this.gridFacturas.Location = new System.Drawing.Point(1, 433);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.RowTemplate.Height = 25;
            this.gridFacturas.Size = new System.Drawing.Size(523, 289);
            this.gridFacturas.TabIndex = 2;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.labelPrincipal);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 47);
            this.panel1.TabIndex = 3;
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
            this.labelPrincipal.Location = new System.Drawing.Point(121, 6);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(357, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Alta y Consulta de Facturas Services";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(530, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 289);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            // maskTxtLegajo
            // 
            this.maskTxtLegajo.Location = new System.Drawing.Point(25, 135);
            this.maskTxtLegajo.Mask = "99999";
            this.maskTxtLegajo.Name = "maskTxtLegajo";
            this.maskTxtLegajo.Size = new System.Drawing.Size(90, 26);
            this.maskTxtLegajo.TabIndex = 2;
            this.maskTxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskTxtLegajo.ValidatingType = typeof(int);
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
            // maskTxtNroFactura
            // 
            this.maskTxtNroFactura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroFactura.Location = new System.Drawing.Point(59, 65);
            this.maskTxtNroFactura.Mask = "99-99999999";
            this.maskTxtNroFactura.Name = "maskTxtNroFactura";
            this.maskTxtNroFactura.Size = new System.Drawing.Size(126, 29);
            this.maskTxtNroFactura.TabIndex = 6;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new System.Drawing.Point(22, 104);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(132, 18);
            this.labelEmpleado.TabIndex = 7;
            this.labelEmpleado.Text = "Legajo Empleado";
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Location = new System.Drawing.Point(27, 44);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(116, 18);
            this.labelNumeroFactura.TabIndex = 8;
            this.labelNumeroFactura.Text = "NumeroFactura";
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Location = new System.Drawing.Point(140, 138);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(129, 18);
            this.labelNombreApellido.TabIndex = 9;
            this.labelNombreApellido.Text = "Apellido, Nombre";
            this.labelNombreApellido.Visible = false;
            // 
            // btnSearchFactura
            // 
            this.btnSearchFactura.BackColor = System.Drawing.Color.Snow;
            this.btnSearchFactura.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFactura.Location = new System.Drawing.Point(26, 65);
            this.btnSearchFactura.Name = "btnSearchFactura";
            this.btnSearchFactura.Size = new System.Drawing.Size(31, 29);
            this.btnSearchFactura.TabIndex = 14;
            this.btnSearchFactura.UseVisualStyleBackColor = false;
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
            // panelFactura
            // 
            this.panelFactura.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelFactura.Controls.Add(this.labelFactura);
            this.panelFactura.Controls.Add(this.labelClientes);
            this.panelFactura.Controls.Add(this.btnSearchFactura);
            this.panelFactura.Controls.Add(this.labelNombreApellido);
            this.panelFactura.Controls.Add(this.labelNumeroFactura);
            this.panelFactura.Controls.Add(this.labelEmpleado);
            this.panelFactura.Controls.Add(this.maskTxtNroFactura);
            this.panelFactura.Controls.Add(this.labelCuil);
            this.panelFactura.Controls.Add(this.maskTxtLegajo);
            this.panelFactura.Controls.Add(this.maskTxtCuil);
            this.panelFactura.Location = new System.Drawing.Point(2, 53);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(601, 193);
            this.panelFactura.TabIndex = 0;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFactura.Location = new System.Drawing.Point(229, 0);
            this.labelFactura.Margin = new System.Windows.Forms.Padding(0);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(94, 27);
            this.labelFactura.TabIndex = 22;
            this.labelFactura.Text = "Factura";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetalle.Location = new System.Drawing.Point(183, 235);
            this.labelDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(210, 27);
            this.labelDetalle.TabIndex = 23;
            this.labelDetalle.Text = "Detalle de Factura";
            // 
            // ABM_Frm_FacturasServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(607, 731);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFactura);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.panelDetalleFactura);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_FacturasServices";
            this.Text = "Facturas";
            this.panelDetalleFactura.ResumeLayout(false);
            this.panelDetalleFactura.PerformLayout();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDetalleFactura;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_total;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.MaskedTextBox maskTxtMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelTipoService;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.RadioButton rBtnTarjeta;
        private System.Windows.Forms.RadioButton rBtnEfectivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtLegajo;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtNroFactura;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Button btnSearchFactura;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSearchFecha;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Label labelDetalle;
    }
}