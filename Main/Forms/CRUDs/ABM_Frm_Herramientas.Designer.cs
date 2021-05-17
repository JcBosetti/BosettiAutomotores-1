
namespace AAA.Formularios_ABM
{
    partial class ABM_Frm_Herramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Frm_Herramientas));
            this.gridHerramientas = new System.Windows.Forms.DataGridView();
            this.id_herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHerramienta = new System.Windows.Forms.Label();
            this.txtHerramienta = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHerramientas
            // 
            this.gridHerramientas.AllowUserToAddRows = false;
            this.gridHerramientas.AllowUserToDeleteRows = false;
            this.gridHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHerramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_herramienta,
            this.nombre,
            this.descripcion});
            this.gridHerramientas.Location = new System.Drawing.Point(12, 210);
            this.gridHerramientas.Name = "gridHerramientas";
            this.gridHerramientas.ReadOnly = true;
            this.gridHerramientas.RowTemplate.Height = 25;
            this.gridHerramientas.Size = new System.Drawing.Size(347, 259);
            this.gridHerramientas.TabIndex = 0;
            // 
            // id_herramienta
            // 
            this.id_herramienta.HeaderText = "ID";
            this.id_herramienta.Name = "id_herramienta";
            this.id_herramienta.ReadOnly = true;
            this.id_herramienta.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Herramienta";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // labelHerramienta
            // 
            this.labelHerramienta.AutoSize = true;
            this.labelHerramienta.Location = new System.Drawing.Point(12, 38);
            this.labelHerramienta.Name = "labelHerramienta";
            this.labelHerramienta.Size = new System.Drawing.Size(94, 18);
            this.labelHerramienta.TabIndex = 1;
            this.labelHerramienta.Text = "Herramienta";
            // 
            // txtHerramienta
            // 
            this.txtHerramienta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHerramienta.Location = new System.Drawing.Point(12, 59);
            this.txtHerramienta.Name = "txtHerramienta";
            this.txtHerramienta.Size = new System.Drawing.Size(267, 29);
            this.txtHerramienta.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Snow;
            this.btnSearch.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(285, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 112);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(347, 26);
            this.txtDescripcion.TabIndex = 16;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 91);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(92, 18);
            this.labelDescripcion.TabIndex = 17;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(12, 155);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 40);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Ivory;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(242, 155);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 40);
            this.btnClean.TabIndex = 19;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::AAA.Properties.Resources.FlechaAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(12, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(48, 34);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // ABM_Frm_Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 472);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHerramienta);
            this.Controls.Add(this.labelHerramienta);
            this.Controls.Add(this.gridHerramientas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABM_Frm_Herramientas";
            this.Text = "Herramientas";
            ((System.ComponentModel.ISupportInitialize)(this.gridHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHerramientas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_herramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label labelHerramienta;
        private System.Windows.Forms.TextBox txtHerramienta;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAtras;
    }
}