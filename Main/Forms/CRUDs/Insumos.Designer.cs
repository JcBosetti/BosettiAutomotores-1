
namespace AAA.Parte_Bruno
{
    partial class Insumos
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
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.labelidInsumos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtidInsumos = new System.Windows.Forms.TextBox();
            this.btnSearchCUIL = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.panelPersonal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPersonal.Controls.Add(this.btnSearchCUIL);
            this.panelPersonal.Controls.Add(this.labelidInsumos);
            this.panelPersonal.Controls.Add(this.labelNombre);
            this.panelPersonal.Controls.Add(this.txtNombre);
            this.panelPersonal.Controls.Add(this.txtidInsumos);
            this.panelPersonal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPersonal.Location = new System.Drawing.Point(-1, 53);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(307, 114);
            this.panelPersonal.TabIndex = 49;
            // 
            // labelidInsumos
            // 
            this.labelidInsumos.AutoSize = true;
            this.labelidInsumos.Location = new System.Drawing.Point(55, 65);
            this.labelidInsumos.Name = "labelidInsumos";
            this.labelidInsumos.Size = new System.Drawing.Size(27, 18);
            this.labelidInsumos.TabIndex = 3;
            this.labelidInsumos.Text = "ID:";
            this.labelidInsumos.Click += new System.EventHandler(this.labelEstanteria_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 18);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtidInsumos
            // 
            this.txtidInsumos.Location = new System.Drawing.Point(88, 62);
            this.txtidInsumos.Name = "txtidInsumos";
            this.txtidInsumos.Size = new System.Drawing.Size(159, 26);
            this.txtidInsumos.TabIndex = 0;
            // 
            // btnSearchCUIL
            // 
            this.btnSearchCUIL.BackColor = System.Drawing.Color.Snow;
            this.btnSearchCUIL.BackgroundImage = global::AAA.Properties.Resources.Search_32px;
            this.btnSearchCUIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCUIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCUIL.Location = new System.Drawing.Point(258, 65);
            this.btnSearchCUIL.Name = "btnSearchCUIL";
            this.btnSearchCUIL.Size = new System.Drawing.Size(27, 23);
            this.btnSearchCUIL.TabIndex = 48;
            this.btnSearchCUIL.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightYellow;
            this.btnClean.BackgroundImage = global::AAA.Properties.Resources.Clean_24px;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(8, 186);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 50);
            this.btnClean.TabIndex = 51;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.BackgroundImage = global::AAA.Properties.Resources.Create_24px;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(176, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 50);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnAtras);
            this.panelPrincipal.Controls.Add(this.labelPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(-1, 3);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(307, 47);
            this.panelPrincipal.TabIndex = 52;
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
            this.labelPrincipal.Location = new System.Drawing.Point(119, 12);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(88, 24);
            this.labelPrincipal.TabIndex = 15;
            this.labelPrincipal.Text = "Insumos";
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 241);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelPersonal);
            this.Name = "Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Label labelidInsumos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtidInsumos;
        private System.Windows.Forms.Button btnSearchCUIL;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label labelPrincipal;
    }
}