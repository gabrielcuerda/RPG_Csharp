using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Con_Avatar_Customizado
{
    internal class Personaje
    {
        public int IdPersonaje { get; set; }
        public string NombreAvatar { get; set; }

        // Configuración estética (Rutas a los PNGs)
        public string SpritePelo { get; set; }

        public string SpriteCejas { get; set; }
        public string SpriteOjos { get; set; }
        public string SpriteCara { get; set; }
        public string SpriteBoca { get; set; }

        public string SpriteRopa { get; set; }

        // Claves foráneas (Integridad de datos)
        public int IdPartida { get; set; }
        public int IdClase { get; set; }

        // Propiedades de navegación de EF Core
        public ClasePersonaje Clase { get; set; }
    }
}
