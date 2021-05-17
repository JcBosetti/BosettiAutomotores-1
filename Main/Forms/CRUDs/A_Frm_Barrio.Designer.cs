
namespace AAA.Formularios_ABM
{
    partial class A_Frm_Barrio
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelCargarBarrios = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.boxCiudades = new System.Windows.Forms.ComboBox();
            this.labelNombreBarrio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LightGray;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.btnAtras);
            this.panelTitulo.Controls.Add(this.labelCargarBarrios);
            this.panelTitulo.Location = new System.Drawing.Point(12, 1);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(496, 38);
            this.panelTitulo.TabIndex = 32;
            // 
            // labelCargarBarrios
            // 
            this.labelCargarBarrios.AutoSize = true;
            this.labelCargarBarrios.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargarBarrios.Location = new System.Drawing.Point(149, 2);
            this.labelCargarBarrios.Margin = new System.Windows.Forms.Padding(0);
            this.labelCargarBarrios.Name = "labelCargarBarrios";
            this.labelCargarBarrios.Size = new System.Drawing.Size(208, 35);
            this.labelCargarBarrios.TabIndex = 22;
            this.labelCargarBarrios.Text = "Cargar Barrios";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(42, 260);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(201, 65);
            this.btnClean.TabIndex = 42;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(269, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 65);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelCiudad);
            this.panel1.Controls.Add(this.boxCiudades);
            this.panel1.Controls.Add(this.labelNombreBarrio);
            this.panel1.Controls.Add(this.txtNombreBarrio);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 209);
            this.panel1.TabIndex = 45;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(29, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 30);
            this.txtId.TabIndex = 30;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(30, 28);
            this.labelId.Margin = new System.Windows.Forms.Padding(0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 23);
            this.labelId.TabIndex = 29;
            this.labelId.Text = "Id";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCiudad.Location = new System.Drawing.Point(209, 28);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(71, 23);
            this.labelCiudad.TabIndex = 35;
            this.labelCiudad.Text = "Ciudad";
            // 
            // boxCiudades
            // 
            this.boxCiudades.FormattingEnabled = true;
            this.boxCiudades.Location = new System.Drawing.Point(209, 57);
            this.boxCiudades.Name = "boxCiudades";
            this.boxCiudades.Size = new System.Drawing.Size(250, 28);
            this.boxCiudades.TabIndex = 36;
            // 
            // labelNombreBarrio
            // 
            this.labelNombreBarrio.AutoSize = true;
            this.labelNombreBarrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreBarrio.Location = new System.Drawing.Point(30, 112);
            this.labelNombreBarrio.Margin = new System.Windows.Forms.Padding(0);
            this.labelNombreBarrio.Name = "labelNombreBarrio";
            this.labelNombreBarrio.Size = new System.Drawing.Size(176, 23);
            this.labelNombreBarrio.TabIndex = 33;
            this.labelNombreBarrio.Text = "Nombre del Barrio ";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreBarrio.Location = new System.Drawing.Point(30, 138);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(250, 30);
            this.txtNombreBarrio.TabIndex = 34;
            this.txtNombreBarrio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnAtras.Size = new System.Drawing.Size(57, 38);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // A_Frm_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panelTitulo);
            this.Name = "A_Frm_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Barrio";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelCargarBarrios;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.ComboBox boxCiudades;
        private System.Windows.Forms.Label labelNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.Button btnAtras;
    }
}