namespace RPG_Con_Avatar_Customizado
{
    partial class PersonalizacionAvatar
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
            this.groupBox_rasgos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_rasgos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_rasgos
            // 
            this.groupBox_rasgos.Controls.Add(this.pictureBox1);
            this.groupBox_rasgos.Location = new System.Drawing.Point(27, 26);
            this.groupBox_rasgos.Name = "groupBox_rasgos";
            this.groupBox_rasgos.Size = new System.Drawing.Size(263, 533);
            this.groupBox_rasgos.TabIndex = 0;
            this.groupBox_rasgos.TabStop = false;
            this.groupBox_rasgos.Text = "Elige la parte del personaje que deseas personalizar";
            this.groupBox_rasgos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PersonalizacionAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 602);
            this.Controls.Add(this.groupBox_rasgos);
            this.Name = "PersonalizacionAvatar";
            this.Text = "RPG";
            this.groupBox_rasgos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_rasgos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

