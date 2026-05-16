using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Con_Avatar_Customizado
{
    internal class Partida
    {
        public int IdPartida { get; set; }
        public DateTime FechaGuardado { get; set; }
        public int ProgresoHistoria { get; set; }

        // Relación: Una partida tiene un personaje
        public Personaje PersonajeAsociado { get; set; }
    }
}
