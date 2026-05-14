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
        Image caraBase = Resources.cara_base;
        Image cejas0 = Resources.cejas_0_200x200;
        Image cejas1 = Resources.cejas_1_200x200;
        Image cejas2 = Resources.cejas_2_200x200;
        Image ojos0 = Resources.ojos_0_200x200;
        Image ojos1 = Resources.ojos_1_200x200;
        Image ojos2 = Resources.ojos_2_200x200;
        Image ojos3 = Resources.ojos_3_200x200;
        Image boca0 = Resources.sprite_boca0_200x200;
        Image boca1 = Resources.sprite_boca1_200x200;
        //int ancho = picAvatar.Width;
        //int alto = picAvatar.Height;

        public creacionAvatar()
        {
            InitializeComponent();
        }

        public void ActualizarAvatar()
        {
            
            //Image imgCara = Resources.cara;
            //Image imgOjos = Resources.ojos;
            //Image imgBoca = Resources.boca;
            
            // 1. Creamos un mapa de bits del tamaño deseado
            Bitmap bmpLienzo = new Bitmap(200, 200);

            // 2. Creamos el objeto "Graphics" que nos permite dibujar sobre ese mapa
            using (Graphics g = Graphics.FromImage(bmpLienzo))
            {
                g.Clear(Color.Transparent);
                // Opcional: Mejorar la calidad del dibujo
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                // 4. Dibujamos en orden (Fondo -> Forma -> Detalles)
                // Es vital verificar que las imágenes no sean nulas antes de dibujar
                if (caraBase != null) g.DrawImage(caraBase, 0, 0, 200,200);


                if (cejas0 != null) g.DrawImage(cejas0, 0, 0, 200, 200);
                // 3. Dibujamos en orden de capa (el primero queda al fondo)
                // Asumiendo que tienes las rutas o recursos listos:
                //g.DrawImage(imgCara, 0, 0, 200, 200);
                //g.DrawImage(imgOjos, 0, 0, 200, 200);
                //g.DrawImage(imgOjos, 0, 0, 200, 200);
                //g.DrawImage(imgCejas, 0, 0, 200, 200);
                //g.DrawImage(imgPelo, 0, 0, 200, 200);
                //g.DrawImage(imgBoca, 0, 0, 200, 200)
            }

            // 4. Mostramos el resultado final en el PictureBox
            // Si ya había una imagen antes, la liberamos para no llenar la RAM
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
            }

            picAvatar.Image = bmpLienzo;
        }
        private void InicioJuego_Load(object sender, EventArgs e)
        {
            //btnContinuarJuego.Enabled = false;
            //imgCara = Image.FromFile("./Resources/cara_base.png");/*Image.FromFile("./Resources/cara_base.png");*/
            // Esto busca la carpeta Resources justo al lado de tu archivo .exe
            //url = Path.Combine(Application.StartupPath, "Resources", "cara_base.png");
            //url = "./Resources/cara_base.png";
            //using (var temp = new Bitmap(url))
            //{
            //    imgCara = new Bitmap(temp);
            //}
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
            ActualizarAvatar();
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

        private void picAvatar_Click(object sender, EventArgs e)
        {
            //int ancho = picAvatar.Width;
            //int alto = picAvatar.Height;
        }
    }
}
