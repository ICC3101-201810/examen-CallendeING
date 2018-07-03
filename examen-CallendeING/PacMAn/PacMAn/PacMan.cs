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
    public class PacMan
    {
        public BindingList<Puntaje> puntajes;
        private DateTime fecha;
        public int xFROJO, YFROJO, XFROSA, YFROSA,xPac,yPac;
        public string nombreJugador;
        public PacMan( )
        {
            fecha = DateTime.Now;
            puntajes = new BindingList<Puntaje>();
            xFROJO = 0;
            YFROJO = 0;
            YFROSA = 0;
            XFROSA = 0;
            xPac = 0;
            yPac = 0;
            nombreJugador = " ";



        }

    }
}
