using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tp1_Definitivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListaGanadores lista;
        Movimientos juego;
        Inicializar cargarJuego;
        JuegoNuevo nuevo;
        ArrayList ganadores = new ArrayList();
        Basico TableroB;
        Intermedio TableroI;
        Experto TableroE;
        int ronda = 0;
        int columna, fila, columnaDragon, filaDragon,filaCalabozo,columnaCalabozo;
        PictureBox[] Caballeros;
        PictureBox[] Dragones;
        PictureBox[] Calabozos;
        bool Basico=false;
        bool Intermedio = false;
        bool Experto = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Caballeros = new PictureBox[4];
            Dragones = new PictureBox[8];
            Inicializar cargarJuego = new Inicializar(1);
            cargarJuego.ShowDialog();
            Caballeros[0] = caballero1; Caballeros[1] = caballero2; Caballeros[2] = caballero3; Caballeros[3] = caballero4;
            Dragones[0] = j1d1; Dragones[1] = j1d2; Dragones[2] = j2d1; Dragones[3] = j2d2; Dragones[4] = j3d1;
            Dragones[5] = j3d2; Dragones[6] = j4d1; Dragones[7] = j4d2;
            //calabozos[0] = pictureBox14; calabozos[1] = pictureBox15; calabozos[2] = pictureBox16;
        }

        private void Tablero_Click(object sender, EventArgs e)
        {

        }

        private void btnGanadores_Click(object sender, EventArgs e)
        {
            lista = new ListaGanadores();
            foreach (Caballero cab in ganadores) 
            {
                lista.lbGanadores.Items.Add(cab.Nombre);
            }
            lista.ShowDialog();
            if (lista.btnCerrar.DialogResult == DialogResult.OK) 
            {
                lista.Dispose();
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            nuevo = new JuegoNuevo();
            juego = new Movimientos();

            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                int cantJugadores = VerificarCantJugadores();

                if (nuevo.rbBasico.Checked)
                {
                    TableroB = new Basico(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Basico con {(cantJugadores - 1).ToString()} bots");
                    Basico = true;

                }
                if (nuevo.rbIntermedio.Checked)
                {
                    TableroI = new Intermedio(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Intermedio con {(cantJugadores - 1).ToString()} bots");
                    Intermedio = true;
                }
                if (nuevo.rbExperto.Checked)
                {
                    TableroI = new Experto(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Experto con {(cantJugadores - 1).ToString()} bots");
                    Experto = true;
                }
                btnMover.Visible = true;
            }
            if (Basico == true)
            {
                
                for (int i = 0; i < 4; i++)
                {
                    Caballeros[i].Visible = false;
                }
                for (int i = 0; i < 8; i++)
                {
                    Dragones[i].Visible = false;
                }
                while (TableroB.HayGanador() == false)
                {
                    juego.lbJuego.Items.Add($"______________Ronda N°{(ronda + 1)}______________");
                    TableroB.Jugar();
                    for (int i = 0; i < TableroB.CantJugadores - 1; i++)
                    {
                        Caballero caballero = TableroB.VerCaballero(i);
                        string movimientos = $"El caballero{caballero.Nombre} saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                        juego.lbJuego.Items.Add(movimientos);
                        fila = ((caballero.Posicion() - 1) / 10) * 90;
                        columna = ((caballero.Posicion() - 1) % 10) * 90;
                        Caballeros[i].Visible = true;
                        Caballeros[i].Left = columna + 55;
                        Caballeros[i].Top = (fila + 65);
                        if (caballero.Gano == true)
                        {
                            ganadores.Add(caballero);
                            MessageBox.Show($"Gano {caballero.Nombre}");
                        }
                    }
                    juego.ShowDialog(this);
                    ronda++;
                }
            }
            if (Intermedio)
            {
                if (TableroI.HayGanador() == false)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Caballeros[i].Visible = false;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        Dragones[i].Visible = false;
                    }
                    while (TableroI.HayGanador() == false)
                    {
                        TableroI.Jugar();
                        for (int i = 0; i < TableroI.CantJugadores; i++)
                        {
                            Caballero caballero = TableroI.VerCaballero(i);
                            if (caballero.Avanza == true)
                            {
                                string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon aliado avanza 5 casilleros: {caballero.Posicion()}";
                                juego.lbJuego.Items.Add(movimiento);
                            }
                            else if (caballero.Retrocede == true)
                            {
                                string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo, retrocede 5 casilleros: {caballero.Posicion()}";
                                juego.lbJuego.Items.Add(movimiento);
                            }
                            else
                            {
                                string movimientos = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                                juego.lbJuego.Items.Add(movimientos);
                                fila = (((caballero.Posicion() - 1) / 10) * 90);
                                columna = (((caballero.Posicion() - 1) % 10) * 90);
                                Caballeros[i].Visible = true;
                                Caballeros[i].Left = columna + 55;
                                Caballeros[i].Top = fila + 65;
                                for (int j = 0; j < TableroI.CantidadDragones; j++)
                                {
                                    Dragon movs = TableroI.VerDragon(j);
                                    filaDragon = ((movs.Posicion() - 1) / 10) * 90;
                                    columnaDragon = ((movs.Posicion() - 1) % 10) * 90;
                                    Dragones[j].Visible = true;
                                    Dragones[j].Left = columnaDragon + 55;
                                    Dragones[j].Top = filaDragon + 65;
                                }
                            }
                            if (caballero.Gano == true)
                            {
                                ganadores.Add(caballero);
                                MessageBox.Show($"Gano {caballero.Nombre}");
                                juego.Dispose();
                            }
                            caballero.ReiniciarTurno();

                        }
                    }
                }

            }
            if (Experto) 
            {
                for (int i = 0; i < 3; i++)
                {
                    Calabozo calabozo = TableroE.VerCalabozo(i);
                    string mov = $"Se ha generado el calabozo {i} en la posicion{calabozo.Posicion()}";
                    juego.lbJuego.Items.Add(mov);
                    filaCalabozo = (calabozo.Posicion() - 1) / 10;
                    columnaCalabozo = (calabozo.Posicion() - 1) % 10;
                    Calabozos[i].Visible = true;
                    Calabozos[i].Left = this.Tablero.Left + columnaCalabozo * this.Tablero.Width / 10;
                    Calabozos[i].Top = this.Tablero.Top + filaCalabozo * this.Tablero.Height / 5;
                }
                while(TableroE.HayGanador() == false)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Caballeros[i].Visible = false;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        Dragones[i].Visible = false;
                    }
                    TableroE.Jugar();
                }
                for (int i = 0; i < TableroE.CantJugadores; i++)
                {
                    Caballero caballero = TableroI.VerCaballero(i);
                    if (caballero.Avanza == true)
                    {
                        string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon aliado avanza 5 casilleros: {caballero.Posicion()}";
                        juego.lbJuego.Items.Add(movimiento);
                    }
                    else if (caballero.Retrocede == true)
                    {
                        string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo, retrocede 5 casilleros: {caballero.Posicion()}";
                        juego.lbJuego.Items.Add(movimiento);
                    }
                    else if (caballero.Muere == true)
                    {
                        string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo dentro de un calabozo y murio";
                        juego.lbJuego.Items.Add(movimiento);

                    }
                    else
                    {
                        string movimientos = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                        juego.lbJuego.Items.Add(movimientos);
                        Caballeros[i].Visible = true;
                        fila = (((caballero.Posicion() - 1) / 10) * 90);
                        columna = (((caballero.Posicion() - 1) % 10) * 90);
                        Caballeros[i].Visible = true;
                        Caballeros[i].Left = columna + 55;
                        Caballeros[i].Top = fila + 65;
                        for (int j = 0; j < TableroI.CantidadDragones; j++)
                        {
                            Dragon movs = TableroI.VerDragon(j);
                            filaDragon = ((movs.Posicion() - 1) / 10) * 90;
                            columnaDragon = ((movs.Posicion() - 1) % 10) * 90;
                            Dragones[j].Visible = true;
                            Dragones[j].Left = columnaDragon + 55;
                            Dragones[j].Top = filaDragon + 65;
                        }
                    }
                    if (caballero.Gano == true)
                    {
                        ganadores.Add(caballero);
                        MessageBox.Show($"Gano {caballero.Nombre}");
                    }
                    caballero.ReiniciarTurno();
                }

            }
        }


        private void btnMover_Click(object sender, EventArgs e)
        {
            if (btnMover.DialogResult == DialogResult.OK)
            {
               
                if (Basico == true)
                {
                    if (TableroB.HayGanador() == false)
                    {
                        juego.lbJuego.Items.Add($"______________Ronda N°{(ronda + 1)}______________");
                        for (int i = 0; i < 4; i++)
                        {
                            Caballeros[i].Visible = false;
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            Dragones[i].Visible = false;
                        }
                        TableroB.Jugar();
                        for (int i = 0; i < TableroB.CantJugadores-1; i++)
                        {
                            Caballero caballero = TableroB.VerCaballero(i);
                            string movimientos = $"El caballero{caballero.Nombre} saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                            juego.lbJuego.Items.Add(movimientos);
                            fila = ((caballero.Posicion()-1)/10)*90;
                            columna = ((caballero.Posicion()-1) % 10)*90;
                            Caballeros[i].Visible = true;
                            Caballeros[i].Left = columna + 55;
                            Caballeros[i].Top = fila + 65;
                            if (caballero.Gano == true)
                            {
                                ganadores.Add(caballero);
                                MessageBox.Show($"Gano {caballero.Nombre}");
                            }
                        }
                        juego.ShowDialog(this);
                        ronda++;
                    }
                }
                if (Intermedio)
                {
                    if (TableroI.HayGanador() == false)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Caballeros[i].Visible = false;
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            Dragones[i].Visible = false;
                        }
                        TableroI.Jugar();
                        for (int i = 0; i < TableroI.CantJugadores; i++)
                        {
                            Caballero caballero = TableroI.VerCaballero(i);
                            if (caballero.Avanza == true)
                            {
                                string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon aliado avanza 5 casilleros: {caballero.Posicion()}";
                                juego.lbJuego.Items.Add(movimiento);
                            }
                            else if (caballero.Retrocede == true)
                            {
                                string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo, retrocede 5 casilleros: {caballero.Posicion()}";
                                juego.lbJuego.Items.Add(movimiento);
                            }
                            else
                            {
                                string movimientos = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                                juego.lbJuego.Items.Add(movimientos);
                                fila = (((caballero.Posicion() - 1) / 10) * 90);
                                columna = (((caballero.Posicion() - 1) % 10)*90);
                                Caballeros[i].Visible = true;
                                Caballeros[i].Left = columna + 55;
                                Caballeros[i].Top = fila + 65;
                                for (int j = 0; j < TableroI.CantidadDragones; j++)
                                {
                                    Dragon movs = TableroI.VerDragon(j);
                                    filaDragon = ((movs.Posicion() - 1) / 10) * 90;
                                    columnaDragon = ((movs.Posicion() - 1) % 10)*90;
                                    Dragones[j].Visible = true;
                                    Dragones[j].Left = columnaDragon + 55;
                                    Dragones[j].Top = filaDragon + 65;
                                }
                            }
                            if (caballero.Gano == true)
                            {
                                ganadores.Add(caballero);
                                MessageBox.Show($"Gano  {caballero.Nombre}");
                                juego.Dispose();
                            }
                            caballero.ReiniciarTurno();
                        }

                    }
                }
                if (Experto)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Calabozo calabozo = TableroE.VerCalabozo(i);
                        string mov = $"Se ha generado el calabozo {i} en la posicion{calabozo.Posicion()}";
                        juego.lbJuego.Items.Add(mov);
                        filaCalabozo = (calabozo.Posicion() - 1) / 10;
                        columnaCalabozo = (calabozo.Posicion() - 1) % 10;
                        Calabozos[i].Visible = true;
                        Calabozos[i].Left = this.Tablero.Left + columnaCalabozo * this.Tablero.Width / 10;
                        Calabozos[i].Top = this.Tablero.Top + filaCalabozo * this.Tablero.Height / 5;
                    }
                    if (TableroE.HayGanador() == false)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Caballeros[i].Visible = false;
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            Dragones[i].Visible = false;
                        }
                        TableroE.Jugar();
                    }
                    for (int i = 0; i < TableroE.CantJugadores; i++)
                    {
                        Caballero caballero = TableroI.VerCaballero(i);
                        
                        if (caballero.Avanza == true)
                        {
                            string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon aliado avanza 5 casilleros: {caballero.Posicion()}";
                            juego.lbJuego.Items.Add(movimiento);
                        }
                        else if (caballero.Retrocede == true)
                        {
                            string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo, retrocede 5 casilleros: {caballero.Posicion()}";
                            juego.lbJuego.Items.Add(movimiento);
                        }
                        else if (caballero.Muere == true)
                        {
                            string movimiento = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}\n Se encontro con un Dragon enemigo dentro de un calabozo y murio";
                            juego.lbJuego.Items.Add(movimiento);

                        }
                        else
                        {
                            string movimientos = $"El caballero saco {caballero.Movimiento} se movio desde la posicion {caballero.CasAnt} a {caballero.Casillero}";
                            juego.lbJuego.Items.Add(movimientos);
                            Caballeros[i].Visible = true;
                            fila = (((caballero.Posicion() - 1) / 10) * 90);
                            columna = (((caballero.Posicion() - 1) % 10) * 90);
                            Caballeros[i].Visible = true;
                            Caballeros[i].Left = columna + 55;
                            Caballeros[i].Top = fila + 65;
                            for (int j = 0; j < TableroI.CantidadDragones; j++)
                            {
                                Dragon movs = TableroI.VerDragon(j);
                                filaDragon = ((movs.Posicion() - 1) / 10) * 90;
                                columnaDragon = ((movs.Posicion() - 1) % 10) * 90;
                                Dragones[j].Visible = true;
                                Dragones[j].Left = columnaDragon + 55;
                                Dragones[j].Top = filaDragon + 65;
                            }
                        }
                        if (caballero.Gano == true)
                        {
                            ganadores.Add(caballero);
                            MessageBox.Show($"Gano el {caballero.Nombre}");
                        }
                        caballero.ReiniciarTurno();
                    }

                }
            }
        }
        

        private void btJuego_Click(object sender, EventArgs e)
        {
            nuevo = new JuegoNuevo();
            juego = new Movimientos();

            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                int cantJugadores = VerificarCantJugadores();

                if (nuevo.rbBasico.Checked)
                {
                    TableroB = new Basico(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Basico con {(cantJugadores - 1).ToString()} bots");
                    Basico = true;

                }
                if (nuevo.rbIntermedio.Checked)
                {
                    TableroI = new Intermedio(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Intermedio con {(cantJugadores - 1).ToString()} bots");
                    Intermedio = true;
                }
                if (nuevo.rbExperto.Checked)
                {
                    TableroI = new Experto(nuevo.textBox1.Text, cantJugadores);
                    MessageBox.Show($"Se ha creado un Tablero Experto con {(cantJugadores - 1).ToString()} bots");
                    Experto = true;
                }
                btnMover.Visible = true;
            }
        }
    
        private int VerificarCantJugadores()
        {
            int cantJ=0;
        try
        {
            if (nuevo.rb1J.Checked)
            {
                cantJ = 2;
            }
            if (nuevo.rb2J.Checked)
            {
                cantJ = 3;
            }
            if (nuevo.rb3J.Checked)
            {
                cantJ = 4;
            }
        }
            catch (Exception ex) { MessageBox.Show("Indique una cantidad de jugadores"); }

            return cantJ;
        }

    }
}


