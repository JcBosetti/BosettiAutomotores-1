
namespace AAA.Parte_Bruno
{
    partial class CajaRepuestos
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
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.txt_idcaja = new System.Windows.Forms.TextBox();
            this.txtid_estanteria = new System.Windows.Forms.TextBox();
            this.labelCaja = new System.Windows.Forms.Label();
            this.labelEstanteria = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelPersonal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(169, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 50);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(1, 208);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 50);
            this.btnClean.TabIndex = 46;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPersonal.Controls.Add(this.labelTitulo);
            this.panelPersonal.Controls.Add(this.labelEstanteria);
            this.panelPersonal.Controls.Add(this.labelCaja);
            this.panelPersonal.Controls.Add(this.txtid_estanteria);
            this.panelPersonal.Controls.Add(this.txt_idcaja);
            this.panelPersonal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPersonal.Location = new System.Drawing.Point(1, 49);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(298, 145);
            this.panelPersonal.TabIndex = 47;
            // 
            // txt_idcaja
            // 
            this.txt_idcaja.Location = new System.Drawing.Point(108, 50);
            this.txt_idcaja.Name = "txt_idcaja";
            this.txt_idcaja.Size = new System.Drawing.Size(159, 26);
            this.txt_idcaja.TabIndex = 0;
            this.txt_idcaja.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtid_estanteria
            // 
            this.txtid_estanteria.Location = new System.Drawing.Point(108, 93);
            this.txtid_estanteria.Name = "txtid_estanteria";
            this.txtid_estanteria.Size = new System.Drawing.Size(159, 26);
            this.txtid_estanteria.TabIndex = 1;
            // 
            // labelCaja
            // 
            this.labelCaja.AutoSize = true;
            this.labelCaja.Location = new System.Drawing.Point(57, 53);
            this.labelCaja.Name = "labelCaja";
            this.labelCaja.Size = new System.Drawing.Size(45, 18);
            this.labelCaja.TabIndex = 2;
            this.labelCaja.Text = "Caja:";
            // 
            // labelEstanteria
            // 
            this.labelEstanteria.AutoSize = true;
            this.labelEstanteria.Location = new System.Drawing.Point(19, 96);
            this.labelEstanteria.Name = "labelEstanteria";
            this.labelEstanteria.Size = new System.Drawing.Size(83, 18);
            this.labelEstanteria.TabIndex = 3;
            this.labelEstanteria.Text = "Estanteria:";
            this.labelEstanteria.Click += new System.EventHandler(this.labelEstanteria_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(1, 1);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(298, 47);
            this.panelPrincipal.TabIndex = 48;
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
            this.btnAtras.Size = new System.Drawing.Size(65, 44);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrincipal.Location = new System.Drawing.Point(98, 11);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(111, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Repuestos";
            this.labelPrincipal.Click += new System.EventHandler(this.labelPrincipal_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FloralWhite;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(47, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(220, 24);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Alta caja de repuestos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CajaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 260);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CajaRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CajaRepuestos";
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.TextBox txtid_estanteria;
        private System.Windows.Forms.TextBox txt_idcaja;
        private System.Windows.Forms.Label labelEstanteria;
        private System.Windows.Forms.Label labelCaja;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Label labelTitulo;
    }
}