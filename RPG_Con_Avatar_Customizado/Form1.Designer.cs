namespace RPG_Con_Avatar_Customizado
{
    partial class form_InicioJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.txtbox_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btnEmpezarJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(263, 209);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(122, 16);
            this.lbl_nombreUsuario.TabIndex = 5;
            this.lbl_nombreUsuario.Text = "Nombre de usuario";
            // 
            // txtbox_nombreUsuario
            // 
            this.txtbox_nombreUsuario.Location = new System.Drawing.Point(266, 254);
            this.txtbox_nombreUsuario.Name = "txtbox_nombreUsuario";
            this.txtbox_nombreUsuario.Size = new System.Drawing.Size(293, 22);
            this.txtbox_nombreUsuario.TabIndex = 4;
            this.txtbox_nombreUsuario.TextChanged += new System.EventHandler(this.nombreUsuario_TextChanged);
            this.txtbox_nombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreUsuario_KeyPress);
            // 
            // btnEmpezarJuego
            // 
            this.btnEmpezarJuego.Location = new System.Drawing.Point(347, 316);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(135, 37);
            this.btnEmpezarJuego.TabIndex = 3;
            this.btnEmpezarJuego.Text = "Empezar Juego";
            this.btnEmpezarJuego.UseVisualStyleBackColor = true;
            this.btnEmpezarJuego.Click += new System.EventHandler(this.btnEmpezarJuego_Click);
            this.btnEmpezarJuego.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEmpezarJuego_KeyDown);
            // 
            // form_InicioJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 602);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.txtbox_nombreUsuario);
            this.Controls.Add(this.btnEmpezarJuego);
            this.Name = "form_InicioJuego";
            this.Text = "El inicio de la aventura";
            this.Load += new System.EventHandler(this.form_InicioJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.TextBox txtbox_nombreUsuario;
        private System.Windows.Forms.Button btnEmpezarJuego;
    }
}

