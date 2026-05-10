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
            this.comboBox_clase = new System.Windows.Forms.ComboBox();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
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
            this.btnEmpezarJuego.Location = new System.Drawing.Point(344, 387);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(135, 37);
            this.btnEmpezarJuego.TabIndex = 3;
            this.btnEmpezarJuego.Text = "Empezar Juego";
            this.btnEmpezarJuego.UseVisualStyleBackColor = true;
            this.btnEmpezarJuego.Click += new System.EventHandler(this.btnEmpezarJuego_Click);
            this.btnEmpezarJuego.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEmpezarJuego_KeyDown);
            // 
            // comboBox_clase
            // 
            this.comboBox_clase.FormattingEnabled = true;
            this.comboBox_clase.Items.AddRange(new object[] {
            "Arquero",
            "Mago",
            "Guerrero",
            "Vagabundo"});
            this.comboBox_clase.Location = new System.Drawing.Point(262, 336);
            this.comboBox_clase.Name = "comboBox_clase";
            this.comboBox_clase.Size = new System.Drawing.Size(135, 24);
            this.comboBox_clase.TabIndex = 6;
            // 
            // lbl_clase
            // 
            this.lbl_clase.AutoSize = true;
            this.lbl_clase.Location = new System.Drawing.Point(259, 300);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(128, 16);
            this.lbl_clase.TabIndex = 7;
            this.lbl_clase.Text = "Clase del personaje";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(432, 300);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(52, 16);
            this.lbl_genero.TabIndex = 9;
            this.lbl_genero.Text = "Género";
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBox_Genero.Location = new System.Drawing.Point(435, 336);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(135, 24);
            this.comboBox_Genero.TabIndex = 8;
            // 
            // form_InicioJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 602);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.comboBox_Genero);
            this.Controls.Add(this.lbl_clase);
            this.Controls.Add(this.comboBox_clase);
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
        private System.Windows.Forms.ComboBox comboBox_clase;
        private System.Windows.Forms.Label lbl_clase;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.ComboBox comboBox_Genero;
    }
}

