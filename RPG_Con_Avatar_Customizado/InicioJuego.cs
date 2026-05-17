using RPG_Con_Avatar_Customizado.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Con_Avatar_Customizado
{
    public partial class creacionAvatar : Form
    {
        string url;
        Image imgCara;
        public creacionAvatar()
        {
            InitializeComponent();
        }

        public void ActualizarAvatar()
        {
            // 1. Creamos un mapa de bits del tamaño deseado
            Bitmap bmpLienzo = new Bitmap(200, 200);

            // 2. Creamos el objeto "Graphics" que nos permite dibujar sobre ese mapa
            using (Graphics g = Graphics.FromImage(bmpLienzo))
            {
                // Opcional: Mejorar la calidad del dibujo
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // 3. Dibujamos en orden de capa (el primero queda al fondo)
                g.DrawImage(imgCara, 0, 0, 200, 200);
            }

            // 4. Mostramos el resultado final en el PictureBox
            if (picAvatar.Image != null) picAvatar.Image.Dispose();

            picAvatar.Image = bmpLienzo;
        }
        private void InicioJuego_Load(object sender, EventArgs e)
        {
        }

        private void btnEmpezarJuego_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {


        }


        private void btn_cejas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_ojos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_pelo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn_boca_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

        }

        private void groupBox_rasgos_Enter(object sender, EventArgs e)
        {

        }

        private void imgDetalle1_Click(object sender, EventArgs e)
        {

        }

        private void imgDetalle3_Click(object sender, EventArgs e)
        {

        }

        private void imgDetalle2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_pelo_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_pelo_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_pelo_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_pelo_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_pelo_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        // ESTA FUNCIÓN ES LA QUE SOLUCIONA EL ERROR CS1061 DE LA CAPTURA
        private void picAvatar_Click(object sender, EventArgs e)
        {
        }
    }
}