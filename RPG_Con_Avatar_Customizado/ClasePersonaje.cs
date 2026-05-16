using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Con_Avatar_Customizado
{
    internal class ClasePersonaje
    {
        public int IdClase { get; set; }
        public string Nombre { get; set; }

        // Estos son los stats, se verán reflejados como un número de estrellas del 1 al 5 en la ventana de inicio
        public int Nivel { get; set; }

        public int Experiencia { get; set; }

        public int Vitalidad { get; set; }

        public int Fuerza { get; set; }

        public int Agilidad { get; set; }

        public int Inteligencia { get; set; }

        public int Defensa { get; set; }

        public int Fe { get; set; }

        
    }
}
