
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_TiposDeServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_TiposDeServicios));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxInsumo1 = new System.Windows.Forms.ComboBox();
            this.boxInsumos2 = new System.Windows.Forms.ComboBox();
            this.boxInsumos3 = new System.Windows.Forms.ComboBox();
            this.boxHerramientas3 = new System.Windows.Forms.ComboBox();
            this.boxHerramientas2 = new System.Windows.Forms.ComboBox();
            this.boxHerramientas1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInsumos = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.labelActivos = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelNombre.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Ivory;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.labelPrincipal);
            this.panelTitulo.Controls.Add(this.btnAtras);
            this.panelTitulo.Location = new System.Drawing.Point(1, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(748, 43);
            this.panelTitulo.TabIndex = 1;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrincipal.Location = new System.Drawing.Point(282, 7);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(195, 27);
            this.labelPrincipal.TabIndex = 22;
            this.labelPrincipal.Text = "Tipo de Services ";
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
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(18, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(143, 18);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre del service";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // panelNombre
            // 
            this.panelNombre.Controls.Add(this.button2);
            this.panelNombre.Controls.Add(this.labelDescripcion);
            this.panelNombre.Controls.Add(this.txtDescripcion);
            this.panelNombre.Controls.Add(this.labelNombre);
            this.panelNombre.Controls.Add(this.txtNombre);
            this.panelNombre.Location = new System.Drawing.Point(1, 55);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(748, 88);
            this.panelNombre.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(283, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescripcion.Location = new System.Drawing.Point(329, 16);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(149, 18);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion Service";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(330, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(407, 23);
            this.txtDescripcion.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxInsumo1);
            this.panel1.Controls.Add(this.boxInsumos2);
            this.panel1.Controls.Add(this.boxInsumos3);
            this.panel1.Controls.Add(this.boxHerramientas3);
            this.panel1.Controls.Add(this.boxHerramientas2);
            this.panel1.Controls.Add(this.boxHerramientas1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelInsumos);
            this.panel1.Location = new System.Drawing.Point(1, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 184);
            this.panel1.TabIndex = 6;
            // 
            // boxInsumo1
            // 
            this.boxInsumo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInsumo1.FormattingEnabled = true;
            this.boxInsumo1.Location = new System.Drawing.Point(18, 47);
            this.boxInsumo1.Name = "boxInsumo1";
            this.boxInsumo1.Size = new System.Drawing.Size(333, 26);
            this.boxInsumo1.TabIndex = 11;
            // 
            // boxInsumos2
            // 
            this.boxInsumos2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInsumos2.FormattingEnabled = true;
            this.boxInsumos2.Location = new System.Drawing.Point(18, 88);
            this.boxInsumos2.Name = "boxInsumos2";
            this.boxInsumos2.Size = new System.Drawing.Size(333, 26);
            this.boxInsumos2.TabIndex = 10;
            // 
            // boxInsumos3
            // 
            this.boxInsumos3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxInsumos3.FormattingEnabled = true;
            this.boxInsumos3.Location = new System.Drawing.Point(18, 131);
            this.boxInsumos3.Name = "boxInsumos3";
            this.boxInsumos3.Size = new System.Drawing.Size(333, 26);
            this.boxInsumos3.TabIndex = 9;
            // 
            // boxHerramientas3
            // 
            this.boxHerramientas3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxHerramientas3.FormattingEnabled = true;
            this.boxHerramientas3.Location = new System.Drawing.Point(394, 131);
            this.boxHerramientas3.Name = "boxHerramientas3";
            this.boxHerramientas3.Size = new System.Drawing.Size(333, 26);
            this.boxHerramientas3.TabIndex = 8;
            // 
            // boxHerramientas2
            // 
            this.boxHerramientas2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxHerramientas2.FormattingEnabled = true;
            this.boxHerramientas2.Location = new System.Drawing.Point(394, 88);
            this.boxHerramientas2.Name = "boxHerramientas2";
            this.boxHerramientas2.Size = new System.Drawing.Size(333, 26);
            this.boxHerramientas2.TabIndex = 7;
            // 
            // boxHerramientas1
            // 
            this.boxHerramientas1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxHerramientas1.FormattingEnabled = true;
            this.boxHerramientas1.Location = new System.Drawing.Point(394, 47);
            this.boxHerramientas1.Name = "boxHerramientas1";
            this.boxHerramientas1.Size = new System.Drawing.Size(333, 26);
            this.boxHerramientas1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(471, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Herramientas Principales";
            // 
            // labelInsumos
            // 
            this.labelInsumos.AutoSize = true;
            this.labelInsumos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsumos.Location = new System.Drawing.Point(101, 16);
            this.labelInsumos.Name = "labelInsumos";
            this.labelInsumos.Size = new System.Drawing.Size(147, 18);
            this.labelInsumos.TabIndex = 2;
            this.labelInsumos.Text = "Insumos Principales";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCosto.Location = new System.Drawing.Point(75, 354);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(138, 18);
            this.labelCosto.TabIndex = 12;
            this.labelCosto.Text = "Costo Aproximado";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(75, 375);
            this.maskedTextBox1.Mask = "99999999,99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(138, 26);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipo_servicio,
            this.nombre_servicio,
            this.descripcion,
            this.costo});
            this.dataGridView1.Location = new System.Drawing.Point(284, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(465, 255);
            this.dataGridView1.TabIndex = 13;
            // 
            // id_tipo_servicio
            // 
            this.id_tipo_servicio.HeaderText = "ID";
            this.id_tipo_servicio.Name = "id_tipo_servicio";
            this.id_tipo_servicio.Width = 50;
            // 
            // nombre_servicio
            // 
            this.nombre_servicio.HeaderText = "Tipo de Servicio";
            this.nombre_servicio.Name = "nombre_servicio";
            this.nombre_servicio.Width = 120;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 170;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo Aproximado";
            this.costo.Name = "costo";
            this.costo.Width = 80;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(5, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(273, 64);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(102, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 117);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImage = global::AAA.Properties.Resources.ReTool_32px;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(5, 513);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 117);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.BackgroundImage = global::AAA.Properties.Resources.TrashCan_24px;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(190, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 117);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // labelActivos
            // 
            this.labelActivos.AutoSize = true;
            this.labelActivos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActivos.Location = new System.Drawing.Point(434, 345);
            this.labelActivos.Margin = new System.Windows.Forms.Padding(0);
            this.labelActivos.Name = "labelActivos";
            this.labelActivos.Size = new System.Drawing.Size(150, 27);
            this.labelActivos.TabIndex = 23;
            this.labelActivos.Text = "Tipos Activos";
            // 
            // ABM_Frm_TiposDeServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 633);
            this.Controls.Add(this.labelActivos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_TiposDeServicios";
            this.Text = "ABM_Frm_TiposDeServicios";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox boxInsumo1;
        private System.Windows.Forms.ComboBox boxInsumos2;
        private System.Windows.Forms.ComboBox boxInsumos3;
        private System.Windows.Forms.ComboBox boxHerramientas3;
        private System.Windows.Forms.ComboBox boxHerramientas2;
        private System.Windows.Forms.ComboBox boxHerramientas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInsumos;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelActivos;
    }
}