using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMAn
{
    [Serializable]
    public class Fruta
    {
        //Habria que crearlas aca y ponerlas en el random que las pone en el mapa de forma aleatoria
        public string nombre;
        public string puntaje;

        public Fruta(string nombre, string puntaje)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
        }
    }
}
