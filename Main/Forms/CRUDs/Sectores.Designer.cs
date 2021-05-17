
namespace AAA.Parte_Bruno
{
    partial class Sectores
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelidSector = new System.Windows.Forms.Label();
            this.txtidSector = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelPrincipal.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelTitulo);
            this.panelPrincipal.Location = new System.Drawing.Point(1, 5);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(357, 47);
            this.panelPrincipal.TabIndex = 56;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::AAA.Properties.Resources.FlechaAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(-1, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(65, 44);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(119, 12);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(95, 24);
            this.labelTitulo.TabIndex = 15;
            this.labelTitulo.Text = "Sectores";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(4, 181);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(158, 53);
            this.btnClean.TabIndex = 55;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(200, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 53);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPersonal.Controls.Add(this.labelDescripcion);
            this.panelPersonal.Controls.Add(this.labelidSector);
            this.panelPersonal.Controls.Add(this.txtidSector);
            this.panelPersonal.Controls.Add(this.txtDescripcion);
            this.panelPersonal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPersonal.Location = new System.Drawing.Point(1, 55);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(357, 114);
            this.panelPersonal.TabIndex = 53;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(14, 67);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(96, 18);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelidSector
            // 
            this.labelidSector.AutoSize = true;
            this.labelidSector.Location = new System.Drawing.Point(33, 28);
            this.labelidSector.Name = "labelidSector";
            this.labelidSector.Size = new System.Drawing.Size(77, 18);
            this.labelidSector.TabIndex = 2;
            this.labelidSector.Text = "ID Sector:";
            // 
            // txtidSector
            // 
            this.txtidSector.Location = new System.Drawing.Point(120, 25);
            this.txtidSector.Name = "txtidSector";
            this.txtidSector.Size = new System.Drawing.Size(205, 26);
            this.txtidSector.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 62);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 26);
            this.txtDescripcion.TabIndex = 0;
            // 
            // Sectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 237);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelPersonal);
            this.Name = "Sectores";
            this.Text = "Sectores";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelidSector;
        private System.Windows.Forms.TextBox txtidSector;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}