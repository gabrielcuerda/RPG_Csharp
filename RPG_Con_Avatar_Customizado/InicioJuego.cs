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

        Image pelo0 = Resources.pelo_0_200x200;
        Image pelo1 = Resources.pelo_1_200x200;
        Image pelo2 = Resources.pelo_2_200x200;
        Image pelo3 = Resources.pelo_3_200x200;
        Image pelo4= Resources.pelo_4_200x200;
        Image pelo5 = Resources.pelo_5_200x200;
        Image pelo6 = Resources.pelo_6_200x200;

        Image caraSeleccionada;
        Image cejasSeleccionadas;
        Image ojosSeleccionados;
        Image bocaSeleccionada;
        Image peloSeleccionado;

        public creacionAvatar()
        {
            InitializeComponent();
            // Valores por defecto
            caraSeleccionada = Resources.cara_base;
            cejasSeleccionadas = Resources.cejas_0_200x200; // Opcional: empezar con cejas 0
            ojosSeleccionados = Resources.ojos_0_200x200;
            bocaSeleccionada = Resources.sprite_boca0_200x200;
            peloSeleccionado = Resources.sprite_boca0_200x200;

            ActualizarAvatar(); // Dibujar por primera vez
        }

        public void ActualizarAvatar()
        {
            Bitmap bmpLienzo = new Bitmap(200, 200);

            using (Graphics g = Graphics.FromImage(bmpLienzo))
            {
                g.Clear(Color.Transparent);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Dibujamos las capas en orden
                if (caraSeleccionada != null) g.DrawImage(caraSeleccionada, 0, 0, 200, 200);
                if (cejasSeleccionadas != null) g.DrawImage(cejasSeleccionadas, 0, 0, 200, 200);
                if (ojosSeleccionados != null) g.DrawImage(ojosSeleccionados, 0, 0, 200, 200);
                if (peloSeleccionado != null) g.DrawImage(peloSeleccionado, 0, 0, 200, 200);
                if (bocaSeleccionada != null) g.DrawImage(bocaSeleccionada, 0, 0, 200, 200);
            }

            if (picAvatar.Image != null) picAvatar.Image.Dispose();
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
            //Cejas 0
            cejasSeleccionadas = cejas0;
            ActualizarAvatar();
        }

        private void imgDetalle3_Click(object sender, EventArgs e)
        {
            //Ojos 0
            ojosSeleccionados = ojos0;
            ActualizarAvatar();
        }

        private void imgDetalle2_Click(object sender, EventArgs e)
        {
            //Cejas 1
            cejasSeleccionadas = cejas1;
            ActualizarAvatar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Cejas 2
            cejasSeleccionadas = cejas2;
            ActualizarAvatar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Ojos 1
            ojosSeleccionados = ojos1;
            ActualizarAvatar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Ojos 2
            ojosSeleccionados = ojos2;
            ActualizarAvatar();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Ojos 3
            ojosSeleccionados = ojos3;
            ActualizarAvatar();
        }

        private void pictureBox_pelo_0_Click(object sender, EventArgs e)
        {
            //Pelo 0
            peloSeleccionado = pelo0;
            ActualizarAvatar();
        }

        private void pictureBox_pelo_1_Click(object sender, EventArgs e)
        {
            //Pelo 1
            peloSeleccionado = pelo1;
            ActualizarAvatar();
        }

        private void pictureBox_pelo_2_Click(object sender, EventArgs e)
        {
            //Pelo 2
            peloSeleccionado = pelo2;
            ActualizarAvatar();
        }

        private void pictureBox_pelo_3_Click(object sender, EventArgs e)
        {
            //Pelo 3
            peloSeleccionado = pelo3;
            ActualizarAvatar();
        }

        private void pictureBox_pelo_4_Click(object sender, EventArgs e)
        {
            //Pelo 4
            peloSeleccionado = pelo4;
            ActualizarAvatar();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Pelo 5
            peloSeleccionado = pelo5;
            ActualizarAvatar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Pelo 6
            peloSeleccionado = pelo6;
            ActualizarAvatar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Boca 0
            bocaSeleccionada = boca0;
            ActualizarAvatar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Boca 1
            bocaSeleccionada = boca1;
            ActualizarAvatar();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            //int ancho = picAvatar.Width;
            //int alto = picAvatar.Height;
        }
    }
}
