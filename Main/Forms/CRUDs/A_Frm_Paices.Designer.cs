
namespace AAA.Formularios_ABM
{
    partial class A_Frm_Paices
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombrePais = new System.Windows.Forms.Label();
            this.txtNombrePais = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelCargarPais = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(266, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 65);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(42, 213);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(201, 65);
            this.btnClean.TabIndex = 51;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelNombrePais);
            this.panel1.Controls.Add(this.txtNombrePais);
            this.panel1.Location = new System.Drawing.Point(13, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 137);
            this.panel1.TabIndex = 50;
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
            // labelNombrePais
            // 
            this.labelNombrePais.AutoSize = true;
            this.labelNombrePais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombrePais.Location = new System.Drawing.Point(205, 28);
            this.labelNombrePais.Margin = new System.Windows.Forms.Padding(0);
            this.labelNombrePais.Name = "labelNombrePais";
            this.labelNombrePais.Size = new System.Drawing.Size(146, 23);
            this.labelNombrePais.TabIndex = 33;
            this.labelNombrePais.Text = "Nombre Ciudad";
            // 
            // txtNombrePais
            // 
            this.txtNombrePais.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtNombrePais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePais.Location = new System.Drawing.Point(205, 54);
            this.txtNombrePais.Name = "txtNombrePais";
            this.txtNombrePais.Size = new System.Drawing.Size(250, 30);
            this.txtNombrePais.TabIndex = 34;
            this.txtNombrePais.TextChanged += new System.EventHandler(this.txtNombreBarrio_TextChanged);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LightGray;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.btnAtras);
            this.panelTitulo.Controls.Add(this.labelCargarPais);
            this.panelTitulo.Location = new System.Drawing.Point(13, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(496, 38);
            this.panelTitulo.TabIndex = 49;
            // 
            // labelCargarPais
            // 
            this.labelCargarPais.AutoSize = true;
            this.labelCargarPais.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargarPais.Location = new System.Drawing.Point(153, -1);
            this.labelCargarPais.Margin = new System.Windows.Forms.Padding(0);
            this.labelCargarPais.Name = "labelCargarPais";
            this.labelCargarPais.Size = new System.Drawing.Size(172, 35);
            this.labelCargarPais.TabIndex = 22;
            this.labelCargarPais.Text = "Cargar Pais";
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
            this.btnAtras.Size = new System.Drawing.Size(65, 38);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // A_Frm_Paices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 294);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "A_Frm_Paices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Paices";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombrePais;
        private System.Windows.Forms.TextBox txtNombrePais;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelCargarPais;
        private System.Windows.Forms.Button btnAtras;
    }
}