namespace RPG_Con_Avatar_Customizado
{
    partial class InicioJuego
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
            this.btnEmpezarJuego = new System.Windows.Forms.Button();
            this.btnContinuarJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpezarJuego
            // 
            this.btnEmpezarJuego.Location = new System.Drawing.Point(346, 213);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(254, 85);
            this.btnEmpezarJuego.TabIndex = 0;
            this.btnEmpezarJuego.Text = "Empezar Juego";
            this.btnEmpezarJuego.UseVisualStyleBackColor = true;
            // 
            // btnContinuarJuego
            // 
            this.btnContinuarJuego.Location = new System.Drawing.Point(346, 325);
            this.btnContinuarJuego.Name = "btnContinuarJuego";
            this.btnContinuarJuego.Size = new System.Drawing.Size(254, 85);
            this.btnContinuarJuego.TabIndex = 1;
            this.btnContinuarJuego.Text = "Continuar Juego";
            this.btnContinuarJuego.UseVisualStyleBackColor = true;
            // 
            // InicioJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 578);
            this.Controls.Add(this.btnContinuarJuego);
            this.Controls.Add(this.btnEmpezarJuego);
            this.Name = "InicioJuego";
            this.Text = "InicioJuego";
            this.Load += new System.EventHandler(this.InicioJuego_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpezarJuego;
        private System.Windows.Forms.Button btnContinuarJuego;
    }
}