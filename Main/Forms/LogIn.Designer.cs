namespace Main.Forms {
	partial class LogIn {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panelLogin = new System.Windows.Forms.Panel();
			this.buttonEnter = new System.Windows.Forms.Button();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
			this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelSubtitle = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
			this.labelImgTitle = new System.Windows.Forms.Label();
			this.labelPicSubTitle = new System.Windows.Forms.Label();
			this.panelLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.panelLogin.Controls.Add(this.buttonEnter);
			this.panelLogin.Controls.Add(this.labelPassword);
			this.panelLogin.Controls.Add(this.labelUsername);
			this.panelLogin.Controls.Add(this.pictureBoxPassword);
			this.panelLogin.Controls.Add(this.pictureBoxUsername);
			this.panelLogin.Controls.Add(this.labelTitle);
			this.panelLogin.Controls.Add(this.labelSubtitle);
			this.panelLogin.Controls.Add(this.textBoxPassword);
			this.panelLogin.Controls.Add(this.textBoxUsername);
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelLogin.Location = new System.Drawing.Point(473, 0);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(327, 450);
			// 
			// buttonEnter
			// 
			this.buttonEnter.BackgroundImage = global::Main.Properties.Resources.LogButton;
			this.buttonEnter.FlatAppearance.BorderSize = 0;
			this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
			this.buttonEnter.Location = new System.Drawing.Point(39, 322);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(241, 51);
			this.buttonEnter.TabIndex = 2;
			this.buttonEnter.Text = "Ingresar";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.BackColor = System.Drawing.Color.Transparent;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
			this.labelPassword.Location = new System.Drawing.Point(36, 207);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(73, 15);
			this.labelPassword.Text = "Contraseña:";
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.BackColor = System.Drawing.Color.Transparent;
			this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
			this.labelUsername.Location = new System.Drawing.Point(36, 147);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(56, 15);
			this.labelUsername.Text = "Usuario: ";
			// 
			// pictureBoxPassword
			// 
			this.pictureBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
			this.pictureBoxPassword.Image = global::Main.Properties.Resources.passWhite;
			this.pictureBoxPassword.Location = new System.Drawing.Point(39, 225);
			this.pictureBoxPassword.Name = "pictureBoxPassword";
			this.pictureBoxPassword.Size = new System.Drawing.Size(22, 22);
			this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPassword.TabStop = false;
			// 
			// pictureBoxUsername
			// 
			this.pictureBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
			this.pictureBoxUsername.Image = global::Main.Properties.Resources.iconUserWhite;
			this.pictureBoxUsername.Location = new System.Drawing.Point(39, 165);
			this.pictureBoxUsername.Name = "pictureBoxUsername";
			this.pictureBoxUsername.Size = new System.Drawing.Size(22, 22);
			this.pictureBoxUsername.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
			this.labelTitle.Location = new System.Drawing.Point(105, 49);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(129, 25);
			this.labelTitle.Text = "Bienvenido";
			// 
			// labelSubtitle
			// 
			this.labelSubtitle.AutoSize = true;
			this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
			this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
			this.labelSubtitle.Location = new System.Drawing.Point(111, 68);
			this.labelSubtitle.Name = "labelSubtitle";
			this.labelSubtitle.Size = new System.Drawing.Size(115, 15);
			this.labelSubtitle.Text = "Ingresa a tu usuario";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(61, 225);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(216, 22);
			this.textBoxPassword.TabIndex = 1;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
			this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.Location = new System.Drawing.Point(61, 165);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(216, 22);
			this.textBoxUsername.TabIndex = 0;
			// 
			// pictureBoxBackground
			// 
			this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxBackground.Image = global::Main.Properties.Resources.LogIn;
			this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxBackground.Name = "pictureBoxBackground";
			this.pictureBoxBackground.Size = new System.Drawing.Size(473, 450);
			this.pictureBoxBackground.TabStop = false;
			// 
			// labelImgTitle
			// 
			this.labelImgTitle.AutoSize = true;
			this.labelImgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(194)))));
			this.labelImgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelImgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.labelImgTitle.Location = new System.Drawing.Point(12, 18);
			this.labelImgTitle.Name = "labelImgTitle";
			this.labelImgTitle.Size = new System.Drawing.Size(289, 25);
			this.labelImgTitle.Text = "Bosetti Automotores S.R.L";
			// 
			// labelPicSubTitle
			// 
			this.labelPicSubTitle.AutoSize = true;
			this.labelPicSubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(194)))));
			this.labelPicSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPicSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.labelPicSubTitle.Location = new System.Drawing.Point(22, 39);
			this.labelPicSubTitle.Name = "labelPicSubTitle";
			this.labelPicSubTitle.Size = new System.Drawing.Size(258, 18);
			this.labelPicSubTitle.Text = "Sistema de Gestión Integral de Ventas";
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelImgTitle);
			this.Controls.Add(this.labelPicSubTitle);
			this.Controls.Add(this.pictureBoxBackground);
			this.Controls.Add(this.panelLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelImgTitle;
        private System.Windows.Forms.Label labelPicSubTitle;
    }
}