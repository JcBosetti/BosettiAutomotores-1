
namespace AAA.Formularios_ABM
{
    partial class A_Frm_Ciudades
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
            this.labelCargarCiudade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.boxPaices = new System.Windows.Forms.ComboBox();
            this.labelNombreCiudad = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
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
            this.panelTitulo.Controls.Add(this.labelCargarCiudade);
            this.panelTitulo.Location = new System.Drawing.Point(12, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(496, 38);
            this.panelTitulo.TabIndex = 32;
            // 
            // labelCargarCiudade
            // 
            this.labelCargarCiudade.AutoSize = true;
            this.labelCargarCiudade.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargarCiudade.Location = new System.Drawing.Point(128, -1);
            this.labelCargarCiudade.Margin = new System.Windows.Forms.Padding(0);
            this.labelCargarCiudade.Name = "labelCargarCiudade";
            this.labelCargarCiudade.Size = new System.Drawing.Size(226, 35);
            this.labelCargarCiudade.TabIndex = 22;
            this.labelCargarCiudade.Text = "Cargar Ciudade";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.txtPatente);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelPais);
            this.panel1.Controls.Add(this.boxPaices);
            this.panel1.Controls.Add(this.labelNombreCiudad);
            this.panel1.Controls.Add(this.txtNombreBarrio);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 209);
            this.panel1.TabIndex = 46;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatente.Location = new System.Drawing.Point(29, 54);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(141, 30);
            this.txtPatente.TabIndex = 30;
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
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPais.Location = new System.Drawing.Point(209, 28);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(48, 23);
            this.labelPais.TabIndex = 35;
            this.labelPais.Text = "Pais";
            // 
            // boxPaices
            // 
            this.boxPaices.FormattingEnabled = true;
            this.boxPaices.Location = new System.Drawing.Point(209, 57);
            this.boxPaices.Name = "boxPaices";
            this.boxPaices.Size = new System.Drawing.Size(250, 28);
            this.boxPaices.TabIndex = 36;
            // 
            // labelNombreCiudad
            // 
            this.labelNombreCiudad.AutoSize = true;
            this.labelNombreCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreCiudad.Location = new System.Drawing.Point(30, 112);
            this.labelNombreCiudad.Margin = new System.Windows.Forms.Padding(0);
            this.labelNombreCiudad.Name = "labelNombreCiudad";
            this.labelNombreCiudad.Size = new System.Drawing.Size(146, 23);
            this.labelNombreCiudad.TabIndex = 33;
            this.labelNombreCiudad.Text = "Nombre Ciudad";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreBarrio.Location = new System.Drawing.Point(30, 138);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(250, 30);
            this.txtNombreBarrio.TabIndex = 34;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(269, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 65);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(42, 264);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(201, 65);
            this.btnClean.TabIndex = 47;
            this.btnClean.UseVisualStyleBackColor = false;
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
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // A_Frm_Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 341);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "A_Frm_Ciudades";
            this.Text = "Cargar Ciudad";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelCargarCiudade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.ComboBox boxPaices;
        private System.Windows.Forms.Label labelNombreCiudad;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAtras;
    }
}