namespace RPG_Con_Avatar_Customizado
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.txtbox_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btnEmpezarJuego = new System.Windows.Forms.Button();
            this.comboBox_clase = new System.Windows.Forms.ComboBox();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(180, 100);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(224, 17);
            this.lbl_nombreUsuario.TabIndex = 5;
            this.lbl_nombreUsuario.Text = "¿COMO SE LLAMA TÚ HÉROE?";
            // 
            // txtbox_nombreUsuario
            // 
            this.txtbox_nombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtbox_nombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_nombreUsuario.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtbox_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.txtbox_nombreUsuario.Location = new System.Drawing.Point(180, 125);
            this.txtbox_nombreUsuario.Name = "txtbox_nombreUsuario";
            this.txtbox_nombreUsuario.Size = new System.Drawing.Size(250, 23);
            this.txtbox_nombreUsuario.TabIndex = 4;
            this.txtbox_nombreUsuario.TextChanged += new System.EventHandler(this.nombreUsuario_TextChanged);
            // 
            // btnEmpezarJuego
            // 
            this.btnEmpezarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.btnEmpezarJuego.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnEmpezarJuego.FlatAppearance.BorderSize = 2;
            this.btnEmpezarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezarJuego.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpezarJuego.ForeColor = System.Drawing.Color.Gold;
            this.btnEmpezarJuego.Location = new System.Drawing.Point(230, 320);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(150, 40);
            this.btnEmpezarJuego.TabIndex = 3;
            this.btnEmpezarJuego.Text = "CREAR AVATAR";
            this.btnEmpezarJuego.UseVisualStyleBackColor = false;
            this.btnEmpezarJuego.Click += new System.EventHandler(this.btnEmpezarJuego_Click);
            // 
            // comboBox_clase
            // 
            this.comboBox_clase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.comboBox_clase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_clase.Font = new System.Drawing.Font("Courier New", 10F);
            this.comboBox_clase.ForeColor = System.Drawing.Color.White;
            this.comboBox_clase.FormattingEnabled = true;
            this.comboBox_clase.Items.AddRange(new object[] {
            "GUERRERO",
            "MAGO",
            "ARQUERO",
            "VAGABUNDO"});
            this.comboBox_clase.Location = new System.Drawing.Point(180, 195);
            this.comboBox_clase.Name = "comboBox_clase";
            this.comboBox_clase.Size = new System.Drawing.Size(250, 24);
            this.comboBox_clase.TabIndex = 6;
            // 
            // lbl_clase
            // 
            this.lbl_clase.AutoSize = true;
            this.lbl_clase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clase.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_clase.ForeColor = System.Drawing.Color.White;
            this.lbl_clase.Location = new System.Drawing.Point(180, 170);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(134, 17);
            this.lbl_clase.TabIndex = 7;
            this.lbl_clase.Text = "ELIGE TU CLASE";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(180, 240);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(161, 17);
            this.lbl_genero.TabIndex = 9;
            this.lbl_genero.Text = "¿QUÉ GÉNERO ERES?";
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.comboBox_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Genero.Font = new System.Drawing.Font("Courier New", 10F);
            this.comboBox_Genero.ForeColor = System.Drawing.Color.White;
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.comboBox_Genero.Location = new System.Drawing.Point(180, 265);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Genero.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
            this.lblTitulo.Location = new System.Drawing.Point(124, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 34);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "ECHOES OF THE FALLEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(650, 420);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.comboBox_Genero);
            this.Controls.Add(this.lbl_clase);
            this.Controls.Add(this.comboBox_clase);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.txtbox_nombreUsuario);
            this.Controls.Add(this.btnEmpezarJuego);
            this.Name = "Form1";
            this.Text = "AVATAR FORGE - RPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.TextBox txtbox_nombreUsuario;
        private System.Windows.Forms.Button btnEmpezarJuego;
        private System.Windows.Forms.ComboBox comboBox_clase;
        private System.Windows.Forms.Label lbl_clase;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.Label lblTitulo;
    }
}