using System;
using System.Windows.Forms;
using System.Media;

namespace RPG_Con_Avatar_Customizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_nombreUsuario.Text))
            {
                btnEmpezarJuego.Enabled = true;
            }
            else
            {
                btnEmpezarJuego.Enabled = false;
            }
        }

        private void btnEmpezarJuego_Click(object sender, EventArgs e)
        {
            // Cambia a la música de la pradera al pulsar el botón usando tu Recurso interno
            try
            {
                MusicaFondo.Reproducir(Properties.Resources.dstechnician_rogue_meadow_113856);
            }
            catch { }

            creacionAvatar ventanaAvatar = new creacionAvatar();
            ventanaAvatar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEmpezarJuego.Enabled = false;

            // Arranca la música del castillo medieval desde tus Recursos al cargar el juego
            try
            {
                MusicaFondo.Reproducir(Properties.Resources.ebunny_old_castle_357802);
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}