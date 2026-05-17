using System;
using System.IO;
using System.Media;

namespace RPG_Con_Avatar_Customizado
{
    public static class MusicaFondo
    {
        private static SoundPlayer reproductor;

        // Ahora acepta el Stream nativo que genera tu ventana de Recursos
        public static void Reproducir(Stream recursoAudio)
        {
            try
            {
                Detener();

                // Le pasamos el recurso de memoria directamente al reproductor
                reproductor = new SoundPlayer(recursoAudio);
                reproductor.PlayLooping();  // Reproducción infinita en bucle
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al reproducir el recurso de audio: " + ex.Message);
            }
        }

        public static void Detener()
        {
            if (reproductor != null)
            {
                reproductor.Stop();
                reproductor.Dispose();
                reproductor = null;
            }
        }
    }
}