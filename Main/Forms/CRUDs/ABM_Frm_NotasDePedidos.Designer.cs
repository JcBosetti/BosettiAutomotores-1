
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_NotasDePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_NotasDePedidos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelPedido = new System.Windows.Forms.Panel();
            this.btnSearchFecha = new System.Windows.Forms.Button();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearchNota = new System.Windows.Forms.Button();
            this.labelNotaPedido = new System.Windows.Forms.Label();
            this.maskTxtNroNota = new System.Windows.Forms.MaskedTextBox();
            this.labelCuit = new System.Windows.Forms.Label();
            this.maskTxtCuil = new System.Windows.Forms.MaskedTextBox();
            this.rBtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rBtnTarjeta = new System.Windows.Forms.RadioButton();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.maskTxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.boxRepuesto = new System.Windows.Forms.ComboBox();
            this.labelRepuesto = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelDetalleFactura = new System.Windows.Forms.Label();
            this.panelDetallePedido = new System.Windows.Forms.Panel();
            this.gridNotas = new System.Windows.Forms.DataGridView();
            this.id_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_nota_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelPedido.SuspendLayout();
            this.panelFormasPago.SuspendLayout();
            this.panelDetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(368, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 41);
            this.panel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(84, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tarjeta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(6, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Efectivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Formas de Pago";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(381, 130);
            this.maskedTextBox5.Mask = "99999999,99";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(113, 26);
            this.maskedTextBox5.TabIndex = 11;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(379, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto Total";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightYellow;
            this.button2.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(528, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 75);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Repuesto";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(54, 130);
            this.maskedTextBox4.Mask = "99999999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox4.TabIndex = 26;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(210, 130);
            this.maskedTextBox3.Mask = "99999999,99";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(113, 26);
            this.maskedTextBox3.TabIndex = 27;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Precio Unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Detalle de Factura";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.maskedTextBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskedTextBox5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 175);
            this.panel1.TabIndex = 30;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Khaki;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(603, 47);
            this.panelPrincipal.TabIndex = 11;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::AAA.Properties.Resources.FlechaAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(1, 2);
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
            this.labelPrincipal.Size = new System.Drawing.Size(165, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Nota de Pedidos";
            // 
            // panelPedido
            // 
            this.panelPedido.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelPedido.Controls.Add(this.btnSearchFecha);
            this.panelPedido.Controls.Add(this.labelPedido);
            this.panelPedido.Controls.Add(this.labelProveedor);
            this.panelPedido.Controls.Add(this.labelFecha);
            this.panelPedido.Controls.Add(this.datePicker);
            this.panelPedido.Controls.Add(this.btnSearchNota);
            this.panelPedido.Controls.Add(this.labelNotaPedido);
            this.panelPedido.Controls.Add(this.maskTxtNroNota);
            this.panelPedido.Controls.Add(this.labelCuit);
            this.panelPedido.Controls.Add(this.maskTxtCuil);
            this.panelPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPedido.Location = new System.Drawing.Point(2, 53);
            this.panelPedido.Margin = new System.Windows.Forms.Padding(0);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(601, 193);
            this.panelPedido.TabIndex = 9;
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
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPedido.Location = new System.Drawing.Point(231, 6);
            this.labelPedido.Margin = new System.Windows.Forms.Padding(0);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(137, 24);
            this.labelPedido.TabIndex = 23;
            this.labelPedido.Text = "Datos Pedido";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.Location = new System.Drawing.Point(23, 128);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(129, 18);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha de Pedido";
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
            // btnSearchNota
            // 
            this.btnSearchNota.BackColor = System.Drawing.Color.Snow;
            this.btnSearchNota.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNota.Location = new System.Drawing.Point(170, 76);
            this.btnSearchNota.Name = "btnSearchNota";
            this.btnSearchNota.Size = new System.Drawing.Size(31, 29);
            this.btnSearchNota.TabIndex = 14;
            this.btnSearchNota.UseVisualStyleBackColor = false;
            // 
            // labelNotaPedido
            // 
            this.labelNotaPedido.AutoSize = true;
            this.labelNotaPedido.Location = new System.Drawing.Point(25, 55);
            this.labelNotaPedido.Name = "labelNotaPedido";
            this.labelNotaPedido.Size = new System.Drawing.Size(155, 18);
            this.labelNotaPedido.TabIndex = 8;
            this.labelNotaPedido.Text = "Numero Nota Pedido";
            // 
            // maskTxtNroNota
            // 
            this.maskTxtNroNota.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTxtNroNota.Location = new System.Drawing.Point(28, 76);
            this.maskTxtNroNota.Mask = "99999999";
            this.maskTxtNroNota.Name = "maskTxtNroNota";
            this.maskTxtNroNota.Size = new System.Drawing.Size(126, 29);
            this.maskTxtNroNota.TabIndex = 6;
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCuit.Location = new System.Drawing.Point(406, 55);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(145, 18);
            this.labelCuit.TabIndex = 4;
            this.labelCuit.Text = "CUIT del Proveedor";
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
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.rBtnTarjeta);
            this.panelFormasPago.Controls.Add(this.rBtnEfectivo);
            this.panelFormasPago.Location = new System.Drawing.Point(368, 53);
            this.panelFormasPago.Name = "panelFormasPago";
            this.panelFormasPago.Size = new System.Drawing.Size(164, 41);
            this.panelFormasPago.TabIndex = 0;
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
            // maskTxtMonto
            // 
            this.maskTxtMonto.Location = new System.Drawing.Point(381, 130);
            this.maskTxtMonto.Mask = "99999999,99";
            this.maskTxtMonto.Name = "maskTxtMonto";
            this.maskTxtMonto.Size = new System.Drawing.Size(113, 23);
            this.maskTxtMonto.TabIndex = 11;
            this.maskTxtMonto.ValidatingType = typeof(int);
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
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(515, 16);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(73, 75);
            this.btnClean.TabIndex = 4;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // boxRepuesto
            // 
            this.boxRepuesto.FormattingEnabled = true;
            this.boxRepuesto.Location = new System.Drawing.Point(13, 65);
            this.boxRepuesto.Name = "boxRepuesto";
            this.boxRepuesto.Size = new System.Drawing.Size(329, 26);
            this.boxRepuesto.TabIndex = 14;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(407, 65);
            this.maskedTextBox1.Mask = "99999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.Location = new System.Drawing.Point(407, 44);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(72, 18);
            this.labelCantidad.TabIndex = 28;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelDetalleFactura
            // 
            this.labelDetalleFactura.AutoSize = true;
            this.labelDetalleFactura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetalleFactura.Location = new System.Drawing.Point(202, 0);
            this.labelDetalleFactura.Margin = new System.Windows.Forms.Padding(0);
            this.labelDetalleFactura.Name = "labelDetalleFactura";
            this.labelDetalleFactura.Size = new System.Drawing.Size(175, 24);
            this.labelDetalleFactura.TabIndex = 25;
            this.labelDetalleFactura.Text = "Detalle de Pedido";
            // 
            // panelDetallePedido
            // 
            this.panelDetallePedido.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelDetallePedido.Controls.Add(this.labelDetalleFactura);
            this.panelDetallePedido.Controls.Add(this.labelCantidad);
            this.panelDetallePedido.Controls.Add(this.maskedTextBox1);
            this.panelDetallePedido.Controls.Add(this.labelRepuesto);
            this.panelDetallePedido.Controls.Add(this.boxRepuesto);
            this.panelDetallePedido.Controls.Add(this.btnClean);
            this.panelDetallePedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDetallePedido.Location = new System.Drawing.Point(2, 252);
            this.panelDetallePedido.Margin = new System.Windows.Forms.Padding(0);
            this.panelDetallePedido.Name = "panelDetallePedido";
            this.panelDetallePedido.Size = new System.Drawing.Size(601, 110);
            this.panelDetallePedido.TabIndex = 10;
            // 
            // gridNotas
            // 
            this.gridNotas.AllowUserToAddRows = false;
            this.gridNotas.AllowUserToDeleteRows = false;
            this.gridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_repuesto,
            this.fecha_pedido,
            this.numero_nota_pedido,
            this.cuil_cliente,
            this.monto_total});
            this.gridNotas.Location = new System.Drawing.Point(0, 418);
            this.gridNotas.Margin = new System.Windows.Forms.Padding(0);
            this.gridNotas.Name = "gridNotas";
            this.gridNotas.ReadOnly = true;
            this.gridNotas.RowTemplate.Height = 25;
            this.gridNotas.Size = new System.Drawing.Size(603, 234);
            this.gridNotas.TabIndex = 12;
            // 
            // id_repuesto
            // 
            this.id_repuesto.HeaderText = "ID_Repuesto";
            this.id_repuesto.Name = "id_repuesto";
            this.id_repuesto.ReadOnly = true;
            // 
            // fecha_pedido
            // 
            this.fecha_pedido.HeaderText = "Fecha de entrega";
            this.fecha_pedido.Name = "fecha_pedido";
            this.fecha_pedido.ReadOnly = true;
            this.fecha_pedido.Width = 120;
            // 
            // numero_nota_pedido
            // 
            this.numero_nota_pedido.HeaderText = "Numero de Pedido";
            this.numero_nota_pedido.Name = "numero_nota_pedido";
            this.numero_nota_pedido.ReadOnly = true;
            this.numero_nota_pedido.Width = 120;
            // 
            // cuil_cliente
            // 
            this.cuil_cliente.HeaderText = "CUIL Proveedor";
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.BackgroundImage = global::AAA.Properties.Resources.TrashCan_24px;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(441, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 50);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(213, 365);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(189, 50);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(2, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 50);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            // ABM_Frm_NotasDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(602, 655);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gridNotas);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelPedido);
            this.Controls.Add(this.panelDetallePedido);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_NotasDePedidos";
            this.Text = "Nota de Pedido";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            this.panelDetallePedido.ResumeLayout(false);
            this.panelDetallePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Panel panelPedido;
        private System.Windows.Forms.Button btnSearchFecha;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnSearchNota;
        private System.Windows.Forms.Label labelNotaPedido;
        private System.Windows.Forms.MaskedTextBox maskTxtNroNota;
        private System.Windows.Forms.Label labelCuit;
        private System.Windows.Forms.MaskedTextBox maskTxtCuil;
        private System.Windows.Forms.RadioButton rBtnEfectivo;
        private System.Windows.Forms.RadioButton rBtnTarjeta;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.MaskedTextBox maskTxtMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox boxRepuesto;
        private System.Windows.Forms.Label labelRepuesto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelDetalleFactura;
        private System.Windows.Forms.Panel panelDetallePedido;
        private System.Windows.Forms.DataGridView gridNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_nota_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_total;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelProveedor;
    }
}