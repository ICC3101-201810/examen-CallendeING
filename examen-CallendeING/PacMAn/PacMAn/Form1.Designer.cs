namespace PacMAn
{
    partial class PacMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInicio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTablaDePosiciones = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.tbNombreJugador = new System.Windows.Forms.TextBox();
            this.btnSalirInicio = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.panelPuntajes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPuntajes = new System.Windows.Forms.DataGridView();
            this.panelPacMan = new System.Windows.Forms.Panel();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalirGuardar = new System.Windows.Forms.Button();
            this.btnSalirPMSinGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCereza = new System.Windows.Forms.PictureBox();
            this.pbFrutaVerde = new System.Windows.Forms.PictureBox();
            this.pbFantasmaRojo = new System.Windows.Forms.PictureBox();
            this.pbFantasmaRosado = new System.Windows.Forms.PictureBox();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.pbPacMan = new System.Windows.Forms.PictureBox();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPuntajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).BeginInit();
            this.panelPacMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCereza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrutaVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasmaRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasmaRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacMan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.pictureBox1);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.btnTablaDePosiciones);
            this.panelInicio.Controls.Add(this.btnRestaurar);
            this.panelInicio.Controls.Add(this.tbNombreJugador);
            this.panelInicio.Controls.Add(this.btnSalirInicio);
            this.panelInicio.Controls.Add(this.btnComenzar);
            this.panelInicio.Location = new System.Drawing.Point(13, 13);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(311, 359);
            this.panelInicio.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacMAn.Properties.Resources.Logo_de_PAC_MAN;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese su nombre";
            // 
            // btnTablaDePosiciones
            // 
            this.btnTablaDePosiciones.Location = new System.Drawing.Point(24, 302);
            this.btnTablaDePosiciones.Name = "btnTablaDePosiciones";
            this.btnTablaDePosiciones.Size = new System.Drawing.Size(75, 45);
            this.btnTablaDePosiciones.TabIndex = 5;
            this.btnTablaDePosiciones.Text = "Tabla de posiciones";
            this.btnTablaDePosiciones.UseVisualStyleBackColor = true;
            this.btnTablaDePosiciones.Click += new System.EventHandler(this.btnTablaDePosiciones_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(57, 229);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(178, 23);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.Text = "Restaurar ultimo juego";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // tbNombreJugador
            // 
            this.tbNombreJugador.Location = new System.Drawing.Point(57, 142);
            this.tbNombreJugador.Name = "tbNombreJugador";
            this.tbNombreJugador.Size = new System.Drawing.Size(178, 20);
            this.tbNombreJugador.TabIndex = 3;
            // 
            // btnSalirInicio
            // 
            this.btnSalirInicio.Location = new System.Drawing.Point(208, 324);
            this.btnSalirInicio.Name = "btnSalirInicio";
            this.btnSalirInicio.Size = new System.Drawing.Size(75, 23);
            this.btnSalirInicio.TabIndex = 2;
            this.btnSalirInicio.Text = "Salir";
            this.btnSalirInicio.UseVisualStyleBackColor = true;
            this.btnSalirInicio.Click += new System.EventHandler(this.btnSalirInicio_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(57, 168);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(178, 23);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar juego nuevo";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // panelPuntajes
            // 
            this.panelPuntajes.Controls.Add(this.button1);
            this.panelPuntajes.Controls.Add(this.dgvPuntajes);
            this.panelPuntajes.Location = new System.Drawing.Point(13, 378);
            this.panelPuntajes.Name = "panelPuntajes";
            this.panelPuntajes.Size = new System.Drawing.Size(311, 359);
            this.panelPuntajes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver al Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPuntajes
            // 
            this.dgvPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntajes.Location = new System.Drawing.Point(23, 28);
            this.dgvPuntajes.Name = "dgvPuntajes";
            this.dgvPuntajes.Size = new System.Drawing.Size(271, 280);
            this.dgvPuntajes.TabIndex = 0;
            // 
            // panelPacMan
            // 
            this.panelPacMan.Controls.Add(this.lbPuntaje);
            this.panelPacMan.Controls.Add(this.label4);
            this.panelPacMan.Controls.Add(this.btnSalirGuardar);
            this.panelPacMan.Controls.Add(this.btnSalirPMSinGuardar);
            this.panelPacMan.Controls.Add(this.label1);
            this.panelPacMan.Controls.Add(this.pbCereza);
            this.panelPacMan.Controls.Add(this.pbFrutaVerde);
            this.panelPacMan.Controls.Add(this.pbFantasmaRojo);
            this.panelPacMan.Controls.Add(this.pbFantasmaRosado);
            this.panelPacMan.Controls.Add(this.btnAbajo);
            this.panelPacMan.Controls.Add(this.btnArriba);
            this.panelPacMan.Controls.Add(this.btnDerecha);
            this.panelPacMan.Controls.Add(this.btnIzquierda);
            this.panelPacMan.Controls.Add(this.pbPacMan);
            this.panelPacMan.Location = new System.Drawing.Point(338, 13);
            this.panelPacMan.Name = "panelPacMan";
            this.panelPacMan.Size = new System.Drawing.Size(505, 416);
            this.panelPacMan.TabIndex = 1;
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.AutoSize = true;
            this.lbPuntaje.Location = new System.Drawing.Point(203, 382);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(94, 13);
            this.lbPuntaje.TabIndex = 17;
            this.lbPuntaje.Text = "Ingrese su nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puntaje:";
            // 
            // btnSalirGuardar
            // 
            this.btnSalirGuardar.Location = new System.Drawing.Point(316, 348);
            this.btnSalirGuardar.Name = "btnSalirGuardar";
            this.btnSalirGuardar.Size = new System.Drawing.Size(90, 51);
            this.btnSalirGuardar.TabIndex = 16;
            this.btnSalirGuardar.Text = "Salir y Guardar";
            this.btnSalirGuardar.UseVisualStyleBackColor = true;
            this.btnSalirGuardar.Click += new System.EventHandler(this.btnSalirGuardar_Click);
            // 
            // btnSalirPMSinGuardar
            // 
            this.btnSalirPMSinGuardar.Location = new System.Drawing.Point(412, 348);
            this.btnSalirPMSinGuardar.Name = "btnSalirPMSinGuardar";
            this.btnSalirPMSinGuardar.Size = new System.Drawing.Size(90, 51);
            this.btnSalirPMSinGuardar.TabIndex = 8;
            this.btnSalirPMSinGuardar.Text = "Salir";
            this.btnSalirPMSinGuardar.UseVisualStyleBackColor = true;
            this.btnSalirPMSinGuardar.Click += new System.EventHandler(this.btnSalirPMSinGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-8, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // pbCereza
            // 
            this.pbCereza.Image = global::PacMAn.Properties.Resources.cherry;
            this.pbCereza.Location = new System.Drawing.Point(94, 142);
            this.pbCereza.Name = "pbCereza";
            this.pbCereza.Size = new System.Drawing.Size(21, 20);
            this.pbCereza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCereza.TabIndex = 15;
            this.pbCereza.TabStop = false;
            // 
            // pbFrutaVerde
            // 
            this.pbFrutaVerde.Image = global::PacMAn.Properties.Resources.tile114;
            this.pbFrutaVerde.Location = new System.Drawing.Point(324, 190);
            this.pbFrutaVerde.Name = "pbFrutaVerde";
            this.pbFrutaVerde.Size = new System.Drawing.Size(21, 20);
            this.pbFrutaVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFrutaVerde.TabIndex = 14;
            this.pbFrutaVerde.TabStop = false;
            // 
            // pbFantasmaRojo
            // 
            this.pbFantasmaRojo.Image = global::PacMAn.Properties.Resources.red_left1;
            this.pbFantasmaRojo.Location = new System.Drawing.Point(53, 288);
            this.pbFantasmaRojo.Name = "pbFantasmaRojo";
            this.pbFantasmaRojo.Size = new System.Drawing.Size(20, 20);
            this.pbFantasmaRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFantasmaRojo.TabIndex = 13;
            this.pbFantasmaRojo.TabStop = false;
            // 
            // pbFantasmaRosado
            // 
            this.pbFantasmaRosado.Image = global::PacMAn.Properties.Resources.pink_left1;
            this.pbFantasmaRosado.Location = new System.Drawing.Point(336, 70);
            this.pbFantasmaRosado.Name = "pbFantasmaRosado";
            this.pbFantasmaRosado.Size = new System.Drawing.Size(20, 20);
            this.pbFantasmaRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFantasmaRosado.TabIndex = 12;
            this.pbFantasmaRosado.TabStop = false;
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(75, 374);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(60, 29);
            this.btnAbajo.TabIndex = 11;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(75, 339);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(60, 29);
            this.btnArriba.TabIndex = 10;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(137, 374);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(60, 29);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(13, 374);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(60, 29);
            this.btnIzquierda.TabIndex = 8;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbPacMan
            // 
            this.pbPacMan.Image = global::PacMAn.Properties.Resources.pacman_right;
            this.pbPacMan.Location = new System.Drawing.Point(228, 190);
            this.pbPacMan.Name = "pbPacMan";
            this.pbPacMan.Size = new System.Drawing.Size(20, 20);
            this.pbPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPacMan.TabIndex = 0;
            this.pbPacMan.TabStop = false;
            // 
            // PacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1858, 917);
            this.Controls.Add(this.panelPuntajes);
            this.Controls.Add(this.panelPacMan);
            this.Controls.Add(this.panelInicio);
            this.Name = "PacMan";
            this.Text = "Pac Man";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPuntajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).EndInit();
            this.panelPacMan.ResumeLayout(false);
            this.panelPacMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCereza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrutaVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasmaRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasmaRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Button btnTablaDePosiciones;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox tbNombreJugador;
        private System.Windows.Forms.Button btnSalirInicio;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Panel panelPuntajes;
        private System.Windows.Forms.Panel panelPacMan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPuntajes;
        private System.Windows.Forms.PictureBox pbPacMan;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.PictureBox pbFantasmaRojo;
        private System.Windows.Forms.PictureBox pbFantasmaRosado;
        private System.Windows.Forms.PictureBox pbCereza;
        private System.Windows.Forms.PictureBox pbFrutaVerde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirGuardar;
        private System.Windows.Forms.Button btnSalirPMSinGuardar;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Label label4;
    }
}

