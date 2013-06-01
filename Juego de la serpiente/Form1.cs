using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Juego_de_la_serpiente
{
    public partial class Form1 : Form
    {
        //Declaramos todo
        Random RandComida = new Random();
        Graphics dibujar;
        Serpiente serpiente = new Serpiente();
        ComidaMuerte comidamuerte;
        ComidaExtraGrande comidaextragrande;
        ComidaGrande comidagrande;
        Comida comida;

        //Declaramos las listas
        public List<int> Puntuacion = new List<int>();
        public Jugador player;
        public List<Jugador> Players = new List<Jugador>();
        
        
        //Declaramos los movimientos 
        bool izquierda = false;
        bool derecha = false;
        bool abajo = false;
        bool arriba = false;
        

        //Declaramos la puntuacion
        int puntuacion = 0;

        public Form1()
        {
            InitializeComponent();
            comida = new Comida(RandComida);
            comidagrande = new ComidaGrande(RandComida);
            comidaextragrande = new ComidaExtraGrande(RandComida);
            comidamuerte = new ComidaMuerte(RandComida);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dibujar = e.Graphics;
            comida.DibComida(dibujar);
            comidagrande.DibComida(dibujar);
            comidaextragrande.DibComida(dibujar);
            comidamuerte.DibComida(dibujar);
            serpiente.DibujarSerp(dibujar);

        }

        //Metodo cuando presionamos alguna tecla y las otras no
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Si presionamos la tecla de abajo y la tenemos presiona y al mismo tiempo presionamos la de arriba, 
            //esto se vuelve false y la tecla de abajo continua siendo true y las demas false. Esto es igual para las demas teclas.
            if (e.KeyData == Keys.Down && arriba == false)
            {
                abajo = true;
                arriba = false;
                derecha = false;
                izquierda = false;
            }
            if (e.KeyData == Keys.Up && abajo == false)
            {
                abajo = false;
                arriba = true;
                derecha = false;
                izquierda = false;
            }
            if (e.KeyData == Keys.Right && izquierda == false)
            {
                abajo = false;
                arriba = false;
                derecha = true;
                izquierda = false;
            }
            if (e.KeyData == Keys.Left && derecha == false)
            {
                abajo = false;
                arriba = false;
                derecha = false;
                izquierda = true;
            }

        }

        private void Velocidad()
        {
            //Velocidad segun puntuacion(NIVELES)
            if (puntuacion >= 8)
            {
                timer1.Interval = 134;
                BarraDeNivel.Text = "1";
            }

            if (puntuacion >= 18)
            {
                timer1.Interval = 123;             
                BarraDeNivel.Text = "2";
            }

            if (puntuacion >= 30)
            {
                timer1.Interval = 112;             
                BarraDeNivel.Text = "3";
            }

            if (puntuacion >= 44)
            {
                timer1.Interval = 101;
                BarraDeNivel.Text = "4";
            }

            if (puntuacion >= 60)
            {
                timer1.Interval = 85;
                BarraDeNivel.Text = "5";
            }

            if (puntuacion >= 78)
            {
                timer1.Interval = 79;
                BarraDeNivel.Text = "6";
            }

            if (puntuacion >= 98)
            {
                timer1.Interval = 68;
                BarraDeNivel.Text = "7";
            }

            if (puntuacion >= 120)
            {
                timer1.Interval = 57;
                BarraDeNivel.Text = "8";
            }

            if (puntuacion >= 144)
            {
                timer1.Interval = 46;
                BarraDeNivel.Text = "9";
            }

            if (puntuacion >= 160)
            {
                timer1.Interval = 40;
                BarraDeNivel.Text = "10";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Convertir la barra de puntuacion de int a string
            BarraPuntuacionSerpiente.Text = Convert.ToString(puntuacion);
            
            //Mandar a llamar los metodos
            //Si presionamos una tecla de las que declaramos, se manda a llamar el metodo especificado
            if (abajo) { serpiente.MoverAbajo(); }
            if (arriba) { serpiente.MoverArriba(); }
            if (derecha) { serpiente.MoverDerecha(); }
            if (izquierda) { serpiente.MoverIzquierda(); }

                //Si el rectangulo de la serpiente se intersecta con el rectangulo de la comida entonces:
                if (serpiente.recSerpiente[0].IntersectsWith(comida.RecComida))
                {
                    //Agregamos un sonido al intersectar la serpiente con la comida
                    System.Media.SoundPlayer SonidoComida = new System.Media.SoundPlayer(Properties.Resources.ComidaChica);
                    SonidoComida.Play();
                    //La puntuacion aumenta en 10
                    puntuacion += 3;
                    //Se llama al metodo de aumentar la serpiente
                    serpiente.AumentarSerp();
                    //Se da una nueva posicion para la comida
                    comida.PosicionComida(RandComida);
                }
                
                //Condicion para cuando se intersecte con la comida mas grande
                if (serpiente.recSerpiente[0].IntersectsWith(comidagrande.RecComida2))
                {

                    System.Media.SoundPlayer SonidoComidaGrande = new System.Media.SoundPlayer(Properties.Resources.ComidaGrande);
                    SonidoComidaGrande.Play();
                    puntuacion += 5;
                    serpiente.AumentarSerp3();
                    comidagrande.PosicionComida(RandComida);
                }

                //Condicion para cuando se intersecte con la comida extra grande
                if (serpiente.recSerpiente[0].IntersectsWith(comidaextragrande.RecComida3))
                {
                    System.Media.SoundPlayer SonidoComida = new System.Media.SoundPlayer(Properties.Resources.ComidaChica);
                    SonidoComida.Play();
                    puntuacion += 2;
                    serpiente.AumentarSerp2();
                    comidaextragrande.PosicionComida(RandComida);

                }
                
                //Condicion para cuando se intersecte con la comida muerte
                if (serpiente.recSerpiente[0].IntersectsWith(comidamuerte.RecComidaMuerte))
                {
                    Reiniciar();
                }
            

            //Mandamos a llamar a los metodos para que se inicien cuando se den las diferentes circunstancias
            Colision();
            Velocidad();
            Ganar();
            this.Invalidate();

        }

        public void Colision()
        {
            //ciclo para colision con cualquier parte de la serpiente
            for (int i = 1; i < serpiente.recSerpiente.Length; i++)
            {
                //Si el rectangulo de la serpiente se intersecta con el rectangulo de la serpiente despues del 1
                if (serpiente.recSerpiente[0].IntersectsWith(serpiente.recSerpiente[i]))
                {
                    Reiniciar();
                }
            }

            //Colision en la parte izquierda o derecha de la pantalla
            if (serpiente.recSerpiente[0].X < 0 || serpiente.recSerpiente[0].X > 330)
            {
                Reiniciar();
            }

            //Colision en la parte de arriba o abajo de la pantalla
            if (serpiente.recSerpiente[0].Y < 0 || serpiente.recSerpiente[0].Y > 290)
            {
                Reiniciar();
            }

        }

        public void Ordernar()
        {
            
        }
    


        private void Reiniciar()
        {
            //Mandamos a llamar el sonido
            System.Media.SoundPlayer SonidoComida = new System.Media.SoundPlayer(Properties.Resources.Perder);
            SonidoComida.Load();
            SonidoComida.Play();
            //Cuando tocas haces colision, el timer pasa a false y mostramos el msj
            timer1.Enabled = false;
            MessageBox.Show("Perdiste. \nTu Puntuacion es " + puntuacion);
            //Agregamos la puntuacion
            /*Puntuacion.Add(puntuacion);*/
            player.Puntos = puntuacion;
            //Volvemos a cero las puntuaciones
            BarraPuntuacionSerpiente.Text = "0";
            puntuacion = 0;
            //Volvemos a cero los niveles
            BarraDeNivel.Text = "0";
            //Reiniciamos el timer de la velocidad
            timer1.Interval = 140;
            //Modificamos los botones, cuadros de texto y labels, para que se presentar como uno quiere
            BotonIniciar.Enabled = false;
            BotonInstrucciones.Enabled = true;
            BotonPuntuaciones.Enabled = true;
            clearBtn.Enabled = true;
            NombreTxt.Visible = true;
            BtnAgregar.Visible = true;
            LblIngresa.Visible = true;
            NombreTxt.Enabled = true;
            BtnAgregar.Enabled = true;
            //Iniciamos el nuevo juego
            serpiente = new Serpiente();
        }

        private void Ganar()
        {
            if (puntuacion >= 160)
            {
                System.Media.SoundPlayer SonidoComida = new System.Media.SoundPlayer(Properties.Resources.Ganar);
                SonidoComida.Load();
                SonidoComida.Play();
                //Si se cumple la condicion automaticamente el timer se vuelve false, y mostramos el msj y el reinicio
                timer1.Enabled = false;
                MessageBox.Show("Ganaste el juego\n Tu puntuacion es: " + puntuacion);
                //Agregamos la puntuacion
                /*Puntuacion.Add(puntuacion);*/
                player.Puntos = puntuacion;
                //Volvemos a cero las puntuaciones
                BarraPuntuacionSerpiente.Text = "0";
                puntuacion = 0;
                //Volvemos a cero los niveles
                BarraDeNivel.Text = "0";
                //Reiniciamos el timer de la velocidad
                timer1.Interval = 140;
                //Volvemos verdaderos todos los botones
                BotonIniciar.Enabled = false;
                BotonInstrucciones.Enabled = true;
                BotonPuntuaciones.Enabled = true;
                clearBtn.Enabled = true;
                NombreTxt.Visible = true;
                BtnAgregar.Visible = true;
                LblIngresa.Visible = true;
                NombreTxt.Enabled = true;
                BtnAgregar.Enabled = true;
                //Iniciamos el nuevo juego
                serpiente = new Serpiente();                
            }   
           
        }

        //Al hacer click en el boton, iniciamos el juego y volvemos falsos todos los botones.
        private void BotonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            abajo = false;
            arriba = false;
            derecha = false;
            izquierda = false;
            BotonIniciar.Enabled = false;
            BotonInstrucciones.Enabled = false;
            BotonPuntuaciones.Enabled = false;
            clearBtn.Enabled = false;
            NombreTxt.Enabled = false;
            BtnAgregar.Enabled = false;
            timer1.Interval = 140;
            System.Media.SoundPlayer SonidoComida = new System.Media.SoundPlayer(Properties.Resources.ComidaChica);
            SonidoComida.Load();
        }

        //Al hacer click en el boton, mostramos las puntuaciones mas altas
        private void BotonPuntuaciones_Click(object sender, EventArgs e)
        {
            /*BinaryWriter bw = new BinaryWriter(new FileStream(@"Puntuacion.dat", FileMode.Append, FileAccess.Write));

            foreach (Jugador j in Players)
            {
                bw.Write(j.Puntos);
            }

            bw.Close();
            
            BinaryReader br = new BinaryReader(
                new FileStream(@"Puntuacion.dat", FileMode.OpenOrCreate, FileAccess.Read));

            while (br.PeekChar() != -1)
            {
                Players.Add(new Jugador());

            }*/
            
            string MostrarPuntuacion = "Puntuaciones Altas\n\n\n";
            foreach (Jugador j in Players)
            {
                MostrarPuntuacion += j.Name + " " + j.Puntos + "\n";
            }

            MessageBox.Show(MostrarPuntuacion);
        }

        //Al hacer click en el boton, mostramos las instrucciones del juego
        private void BotonInstrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones\n 1.- Agrega tu nombre \n 2.- Has click en el boton Iniciar, para comenzar el juego. \n 3.- Las teclas que debes utilizar son ↑, ↓, ← y →. \n 4.- La comida roja te aumenta 1 cuadro, la amarilla 3 y la verde 2. \n 5.- Existen 10 niveles, aumentando la velocidad en cada uno. \n 6.- Al tocar la comida negra, pierdes automaticamente. \n 7.- Ganas al llegar a 160 puntos. \n Suerte!! :)");
        }

        //timer para dar el tiempo de posicion de la comida muerte
        private void timer2_Tick(object sender, EventArgs e)
        {
            comidamuerte.PosicionComida(RandComida);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Players.Clear();
            Puntuacion.Clear();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (NombreTxt.Text == string.Empty)
            {
                NombreTxt.Focus();
                return;
            }

            player = new Jugador(NombreTxt.Text);
            string nombre = (NombreTxt.Text);
            Players.Add(player);

            NombreTxt.Text = string.Empty;
            NombreTxt.Focus();

            clearBtn.Enabled = true;
            BotonIniciar.Enabled = true;
            BotonPuntuaciones.Enabled = true;
            LblIngresa.Visible = false;
            NombreTxt.Visible = false;
            BtnAgregar.Visible = false;
        }
    }
}