using System;
using System.Windows.Forms;

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
            creacionAvatar ventanaAvatar = new creacionAvatar();
            ventanaAvatar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEmpezarJuego.Enabled = false;
        }
    }
}