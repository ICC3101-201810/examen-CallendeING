using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace PacMAn
{
    [Serializable]
    public class Puntaje
    {
        string nombre;
        int puntaje;

        public Puntaje(string nombre, int puntaje)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int pun { get => puntaje; set => puntaje = value; }
    }
}
