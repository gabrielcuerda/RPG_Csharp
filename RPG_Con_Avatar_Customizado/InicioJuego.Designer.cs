namespace RPG_Con_Avatar_Customizado
{
    partial class creacionAvatar
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
            this.groupBox_rasgos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_rasgos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_rasgos
            // 
            this.groupBox_rasgos.Controls.Add(this.pictureBox1);
            this.groupBox_rasgos.Location = new System.Drawing.Point(12, 33);
            this.groupBox_rasgos.Name = "groupBox_rasgos";
            this.groupBox_rasgos.Size = new System.Drawing.Size(263, 533);
            this.groupBox_rasgos.TabIndex = 3;
            this.groupBox_rasgos.TabStop = false;
            this.groupBox_rasgos.Text = "Elige la parte del personaje que deseas personalizar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // creacionAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 578);
            this.Controls.Add(this.groupBox_rasgos);
            this.Name = "creacionAvatar";
            this.Text = "Ventana de Personalización de Avatar";
            this.Load += new System.EventHandler(this.InicioJuego_Load);
            this.groupBox_rasgos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_rasgos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}