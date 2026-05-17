using System;
using System.Media;

namespace RPG_Con_Avatar_Customizado
{
    public static class MusicaFondo
    {
        private static SoundPlayer reproductor;

        public static void Reproducir(string rutaArchivo)
        {
            Detener();
            reproductor = new SoundPlayer(rutaArchivo);
            reproductor.PlayLooping();  // Repite en bucle
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