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
using PacMAn.Properties;

namespace PacMAn
{
    public partial class PacMan : Form
    {
        public int cantidad = 15;
        public PacMan datos = new PacMan();
        public Puntaje p1 = new Puntaje("Juan", 100000);
        public Puntaje p2 = new Puntaje("Pedro", 120000);
        public Puntaje p3 = new Puntaje("Diego", 125000);
        public Puntaje p4 = new Puntaje("Fernando", 200000);
        public string nombreJ;
        public PacMan()
        {
            InitializeComponent();
            panelPacMan.Hide();
            panelPuntajes.Hide();
            panelInicio.Location = new Point(0, 0);
            panelPacMan.Location = new Point(0, 0);
            panelPuntajes.Location = new Point(0, 0);
            pbFrutaVerde.Hide(); pbCereza.Hide();
            datos.puntajes.Add(p1);
            datos.puntajes.Add(p2);
            datos.puntajes.Add(p3);
            datos.puntajes.Add(p4);
            lbPuntaje.Text = "0";

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (tbNombreJugador.Text == "") { MessageBox.Show("Ingrese un nombre por favor"); }
            else { nombreJ = tbNombreJugador.Text;
                panelInicio.Hide();
                panelPacMan.Show(); }
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTablaDePosiciones_Click(object sender, EventArgs e)
        {
            panelInicio.Hide();
            panelPuntajes.Show();
            int i = 0;
            BindingList<Puntaje> puntajes = new BindingList<Puntaje>();
            foreach (Puntaje pun in datos.puntajes) { if (i == 10) { break; } puntajes.Add(pun); i += 1; }
            dgvPuntajes.DataSource = puntajes;
            dgvPuntajes.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelInicio.Show();
            panelPuntajes.Hide();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = pbPacMan.Location.X;
            int y = pbPacMan.Location.Y;
            MessageBox.Show("holadsadsad");
            if (e.KeyChar == Convert.ToChar(Keys.Right)) { x += 1; MessageBox.Show("hola"); }
            if (e.KeyChar == Convert.ToChar(Keys.Left)) { x -= 1; }
            if (e.KeyChar == Convert.ToChar(Keys.Up)) { y += 1; }
            if (e.KeyChar == Convert.ToChar(Keys.Down)) { y -= 1; }

            pbPacMan.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoverPacMan(-cantidad, 0);
            pbPacMan.Image = Resources.pacman_left;
            TerminaTurno();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            MoverPacMan(0, cantidad);
            pbPacMan.Image = Resources.pacman_down;
            TerminaTurno();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            MoverPacMan(cantidad, 0);
            pbPacMan.Image = Resources.pacman_right;
            TerminaTurno();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            MoverPacMan(0, -cantidad);
            pbPacMan.Image = Resources.pacman_up;
            TerminaTurno();
        }

        public void TerminaTurno()
        {
            int xFR = pbFantasmaRojo.Location.X;
            int xFRy = pbFantasmaRojo.Location.Y;
            int xFRa = pbFantasmaRosado.Location.X;
            int xFRay = pbFantasmaRosado.Location.Y;
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber < 50) { xFR -= cantidad; } else { xFR += cantidad; }
            randomNumber = random.Next(0, 100);
            if (randomNumber < 50) { xFRy -= cantidad; } else { xFRy += cantidad; }
            randomNumber = random.Next(0, 100);
            if (randomNumber < 50) { xFRa -= cantidad; } else { xFRa += cantidad; }
            randomNumber = random.Next(0, 100);
            if (randomNumber < 50) { xFRay -= cantidad; } else { xFRay += cantidad; }

            pbFantasmaRojo.Location = new Point(xFR, xFRy);
            pbFantasmaRosado.Location = new Point(xFRa, xFRay);
            int pmx = pbPacMan.Location.X;
            int pmy = pbPacMan.Location.X;
            if ((pmx < xFRa && xFRa < pmx + cantidad && pmy < xFRay && xFRay < pmy + cantidad) || (pmx < xFR && xFR < pmx + cantidad && pmy < xFRy && xFRy < pmy + cantidad))
            {
                MessageBox.Show(nombreJ+" tu puntaje ha sido de " + Convert.ToString(lbPuntaje.Text) + " puntos");
                panelPacMan.Hide();
                panelPuntajes.Show();
            }
            randomNumber = random.Next(0, 100);
            if (randomNumber < 20)
            {
                randomNumber = random.Next(0, 100);
                if (randomNumber < 50)
                {
                    int rndy = random.Next(0, panelPacMan.Height);
                    int rndx = random.Next(0, panelPacMan.Width);
                    pbCereza.Location = new Point(rndx, rndy);
                    pbCereza.Show();
                }
                else
                {
                    int rndy = random.Next(0, panelPacMan.Height);
                    int rndx = random.Next(0, panelPacMan.Width);
                    pbFrutaVerde.Location = new Point(rndx, rndy);
                    pbFrutaVerde.Show();

                }
            }
        }

        public void MoverPacMan(int numerox, int numeroy)
        {
            int x = pbPacMan.Location.X;
            int y = pbPacMan.Location.Y;

            if ( y + numeroy < panelPacMan.Height || x > 0 || y > 0 ||  x + numerox < panelPacMan.Width)
            {
                y += numeroy;
                x += numerox;
                pbPacMan.Location = new Point(x, y);
            }
            else { MessageBox.Show("Haga un movimiento valido"); }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pbPacMan.Location.X;
            int y = pbPacMan.Location.Y;
            MessageBox.Show("holadsadsad");
            if (e.KeyCode == (Keys.Right)) { x += 1; MessageBox.Show("hola"); }
            if (e.KeyCode == (Keys.Left)) { x -= 1; }
            if (e.KeyCode == (Keys.Up)) { y += 1; }
            if (e.KeyCode == (Keys.Down)) { y -= 1; }

            pbPacMan.Location = new Point(x, y);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("PacMan_SaveGame.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                datos = (PacMan)formateador.Deserialize(miStream);
                miStream.Close();
                pbFantasmaRojo.Location = new Point(datos.xFROJO, datos.YFROJO);
                pbFantasmaRojo.Location = new Point(datos.XFROSA, datos.YFROSA);
                pbPacMan.Location = new Point(datos.xPac, datos.yPac);
                nombreJ = datos.nombreJugador;
                panelInicio.Hide();
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Bienvenido "+nombreJ);
                panelPacMan.Show();
            }
            catch
            {
                MessageBox.Show("No existe ningun juego previamente guardado");
            }
        }

        private void btnSalirGuardar_Click(object sender, EventArgs e)
        {
            datos.xFROJO = pbFantasmaRojo.Location.X;
            datos.XFROSA = pbFantasmaRosado.Location.X;
            datos.xPac = pbPacMan.Location.X;
            datos.yPac = pbPacMan.Location.Y;
            datos.YFROSA = pbFantasmaRosado.Location.Y;
            datos.YFROJO = pbFantasmaRojo.Location.Y;
            datos.nombreJugador = nombreJ;
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("PacMan_SaveGame.bin", FileMode.Create, FileAccess.Write);
            formateador.Serialize(miStream, datos);
            miStream.Close();
            System.Media.SystemSounds.Asterisk.Play();
            MessageBox.Show("La partida ha sido guardada con exito.\nGracias por preferirnos");
            this.Close();
        }

        private void btnSalirPMSinGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Puntaje p = new Puntaje(nombreJ, Convert.ToInt32(lbPuntaje.Text));
            datos.puntajes.Add(p);
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("PacMan_SaveGame.bin", FileMode.Create, FileAccess.Write);
            formateador.Serialize(miStream, datos);
            miStream.Close();
        }
    }
}
