
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_FacturasCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_FacturasCompra));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelFactura = new System.Windows.Forms.Panel();
            this.btnSearchFecha = new System.Windows.Forms.Button();
            this.labelFactura = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearchFac = new System.Windows.Forms.Button();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.maskTxtNroFactura = new System.Windows.Forms.MaskedTextBox();
            this.labelCuil = new System.Windows.Forms.Label();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalleFactura = new System.Windows.Forms.Panel();
            this.labelDetalleFactura = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelRepuesto = new System.Windows.Forms.Label();
            this.boxRepuesto = new System.Windows.Forms.ComboBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.labelMonto = new System.Windows.Forms.Label();
            this.maskTxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.rBtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rBtnEfectivo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panelFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.panelDetalleFactura.SuspendLayout();
            this.panelFormasPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(530, 433);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 289);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.labelPrincipal);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 47);
            this.panel1.TabIndex = 8;
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
            this.labelPrincipal.Location = new System.Drawing.Point(220, 8);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(172, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Factura Compras";
            // 
            // panelFactura
            // 
            this.panelFactura.BackColor = System.Drawing.Color.Beige;
            this.panelFactura.Controls.Add(this.btnSearchFecha);
            this.panelFactura.Controls.Add(this.labelFactura);
            this.panelFactura.Controls.Add(this.labelProveedor);
            this.panelFactura.Controls.Add(this.labelFecha);
            this.panelFactura.Controls.Add(this.datePicker);
            this.panelFactura.Controls.Add(this.btnSearchFac);
            this.panelFactura.Controls.Add(this.labelNumeroFactura);
            this.panelFactura.Controls.Add(this.maskTxtNroFactura);
            this.panelFactura.Controls.Add(this.labelCuil);
            this.panelFactura.Controls.Add(this.maskTxtCuil);
            this.panelFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelFactura.Location = new System.Drawing.Point(2, 53);
            this.panelFactura.Margin = new System.Windows.Forms.Padding(0);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(601, 193);
            this.panelFactura.TabIndex = 5;
            // 
            // btnSearchFecha
            // 
            this.btnSearchFecha.BackColor = System.Drawing.Color.Snow;
            this.btnSearchFecha.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFecha.Location = new System.Drawing.Point(328, 149);
            this.btnSearchFecha.Name = "btnSearchFecha";
            this.btnSearchFecha.Size = new System.Drawing.Size(31, 29);
            this.btnSearchFecha.TabIndex = 24;
            this.btnSearchFecha.UseVisualStyleBackColor = false;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFactura.Location = new System.Drawing.Point(232, 11);
            this.labelFactura.Margin = new System.Windows.Forms.Padding(0);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(144, 24);
            this.labelFactura.TabIndex = 23;
            this.labelFactura.Text = "Datos Factura";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProveedor.Location = new System.Drawing.Point(389, 117);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(161, 18);
            this.labelProveedor.TabIndex = 15;
            this.labelProveedor.Text = "NombreDelProveedor";
            this.labelProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.Location = new System.Drawing.Point(26, 128);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(115, 18);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha  Entrega";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Location = new System.Drawing.Point(23, 149);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(289, 26);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2021, 5, 10, 10, 37, 48, 0);
            // 
            // btnSearchFac
            // 
            this.btnSearchFac.BackColor = System.Drawing.Color.Snow;
            this.btnSearchFac.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFac.Location = new System.Drawing.Point(170, 76);
            this.btnSearchFac.Name = "btnSearchFac";
            this.btnSearchFac.Size = new System.Drawing.Size(31, 29);
            this.btnSearchFac.TabIndex = 14;
            this.btnSearchFac.UseVisualStyleBackColor = false;
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Location = new System.Drawing.Point(25, 55);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(116, 18);
            this.labelNumeroFactura.TabIndex = 8;
            this.labelNumeroFactura.Text = "NumeroFactura";
            // 
            // maskTxtNroFactura
            // 
            this.maskTxtNroFactura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroFactura.Location = new System.Drawing.Point(28, 76);
            this.maskTxtNroFactura.Mask = "99-99999999";
            this.maskTxtNroFactura.Name = "maskTxtNroFactura";
            this.maskTxtNroFactura.Size = new System.Drawing.Size(126, 29);
            this.maskTxtNroFactura.TabIndex = 6;
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuil.Location = new System.Drawing.Point(406, 55);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(145, 18);
            this.labelCuil.TabIndex = 4;
            this.labelCuil.Text = "CUIT del Proveedor";
            // 
            // maskTxtCuil
            // 
            this.maskTxtCuil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtCuil.Location = new System.Drawing.Point(362, 76);
            this.maskTxtCuil.Mask = "99-99999999-9";
            this.maskTxtCuil.Name = "maskTxtCuil";
            this.maskTxtCuil.Size = new System.Drawing.Size(217, 29);
            this.maskTxtCuil.TabIndex = 0;
            this.maskTxtCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridFacturas
            // 
            this.gridFacturas.AllowUserToAddRows = false;
            this.gridFacturas.AllowUserToDeleteRows = false;
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.numero_factura,
            this.cuil_proveedor,
            this.monto_total});
            this.gridFacturas.Location = new System.Drawing.Point(1, 433);
            this.gridFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.RowTemplate.Height = 25;
            this.gridFacturas.Size = new System.Drawing.Size(523, 289);
            this.gridFacturas.TabIndex = 7;
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
            // cuil_proveedor
            // 
            this.cuil_proveedor.HeaderText = "CUIL Proveedor";
            this.cuil_proveedor.Name = "cuil_proveedor";
            this.cuil_proveedor.ReadOnly = true;
            this.cuil_proveedor.Width = 120;
            // 
            // monto_total
            // 
            this.monto_total.HeaderText = "Monto Total";
            this.monto_total.Name = "monto_total";
            this.monto_total.ReadOnly = true;
            // 
            // panelDetalleFactura
            // 
            this.panelDetalleFactura.BackColor = System.Drawing.Color.Beige;
            this.panelDetalleFactura.Controls.Add(this.labelDetalleFactura);
            this.panelDetalleFactura.Controls.Add(this.labelPrecio);
            this.panelDetalleFactura.Controls.Add(this.labelCantidad);
            this.panelDetalleFactura.Controls.Add(this.maskedTextBox2);
            this.panelDetalleFactura.Controls.Add(this.maskedTextBox1);
            this.panelDetalleFactura.Controls.Add(this.labelRepuesto);
            this.panelDetalleFactura.Controls.Add(this.boxRepuesto);
            this.panelDetalleFactura.Controls.Add(this.btnClean);
            this.panelDetalleFactura.Controls.Add(this.labelMonto);
            this.panelDetalleFactura.Controls.Add(this.maskTxtMonto);
            this.panelDetalleFactura.Controls.Add(this.labelFormaPago);
            this.panelDetalleFactura.Controls.Add(this.panelFormasPago);
            this.panelDetalleFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDetalleFactura.Location = new System.Drawing.Point(2, 252);
            this.panelDetalleFactura.Margin = new System.Windows.Forms.Padding(0);
            this.panelDetalleFactura.Name = "panelDetalleFactura";
            this.panelDetalleFactura.Size = new System.Drawing.Size(601, 175);
            this.panelDetalleFactura.TabIndex = 6;
            // 
            // labelDetalleFactura
            // 
            this.labelDetalleFactura.AutoSize = true;
            this.labelDetalleFactura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetalleFactura.Location = new System.Drawing.Point(210, 0);
            this.labelDetalleFactura.Margin = new System.Windows.Forms.Padding(0);
            this.labelDetalleFactura.Name = "labelDetalleFactura";
            this.labelDetalleFactura.Size = new System.Drawing.Size(182, 24);
            this.labelDetalleFactura.TabIndex = 25;
            this.labelDetalleFactura.Text = "Detalle de Factura";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecio.Location = new System.Drawing.Point(210, 109);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(112, 18);
            this.labelPrecio.TabIndex = 29;
            this.labelPrecio.Text = "Precio Unitario";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.Location = new System.Drawing.Point(54, 109);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(72, 18);
            this.labelCantidad.TabIndex = 28;
            this.labelCantidad.Text = "Cantidad";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(210, 130);
            this.maskedTextBox2.Mask = "99999999,99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(113, 26);
            this.maskedTextBox2.TabIndex = 27;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(54, 130);
            this.maskedTextBox1.Mask = "99999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // labelRepuesto
            // 
            this.labelRepuesto.AutoSize = true;
            this.labelRepuesto.Location = new System.Drawing.Point(10, 44);
            this.labelRepuesto.Name = "labelRepuesto";
            this.labelRepuesto.Size = new System.Drawing.Size(75, 18);
            this.labelRepuesto.TabIndex = 25;
            this.labelRepuesto.Text = "Repuesto";
            // 
            // boxRepuesto
            // 
            this.boxRepuesto.FormattingEnabled = true;
            this.boxRepuesto.Location = new System.Drawing.Point(13, 65);
            this.boxRepuesto.Name = "boxRepuesto";
            this.boxRepuesto.Size = new System.Drawing.Size(329, 26);
            this.boxRepuesto.TabIndex = 14;
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
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonto.Location = new System.Drawing.Point(379, 109);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(87, 18);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto Total";
            // 
            // maskTxtMonto
            // 
            this.maskTxtMonto.Location = new System.Drawing.Point(381, 130);
            this.maskTxtMonto.Mask = "99999999,99";
            this.maskTxtMonto.Name = "maskTxtMonto";
            this.maskTxtMonto.Size = new System.Drawing.Size(113, 26);
            this.maskTxtMonto.TabIndex = 11;
            this.maskTxtMonto.ValidatingType = typeof(int);
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Location = new System.Drawing.Point(368, 44);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(126, 18);
            this.labelFormaPago.TabIndex = 10;
            this.labelFormaPago.Text = "Formas de Pago";
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.rBtnTarjeta);
            this.panelFormasPago.Controls.Add(this.rBtnEfectivo);
            this.panelFormasPago.Location = new System.Drawing.Point(368, 53);
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
            // ABM_Frm_FacturasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 726);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFactura);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.panelDetalleFactura);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_FacturasCompra";
            this.Text = "Facturas Compra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.panelDetalleFactura.ResumeLayout(false);
            this.panelDetalleFactura.PerformLayout();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnSearchFac;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.MaskedTextBox maskTxtNroFactura;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.Panel panelDetalleFactura;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.MaskedTextBox maskTxtMonto;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.RadioButton rBtnTarjeta;
        private System.Windows.Forms.RadioButton rBtnEfectivo;
        private System.Windows.Forms.Button btnSearchFecha;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Label labelDetalleFactura;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelRepuesto;
        private System.Windows.Forms.ComboBox boxRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_total;
    }
}