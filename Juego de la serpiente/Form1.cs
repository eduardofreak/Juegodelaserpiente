using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_serpiente
{
    public partial class Form1 : Form
    {
        //Declaramos todo
        Random RandComida = new Random();
        Graphics dibujar;
        Serpiente serpiente = new Serpiente();
        ComidaExtraGrande comidaextragrande;
        ComidaGrande comidagrande;
        Comida comida;

        //Declaramos los movimientos 
        bool izquierda = false;
        bool derecha = false;
        bool abajo = false;
        bool arriba = false;

        int puntuacion = 0;

        public Form1()
        {
            InitializeComponent();
            comida = new Comida(RandComida);
            comidagrande = new ComidaGrande(RandComida);
            comidaextragrande = new ComidaExtraGrande(RandComida);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dibujar = e.Graphics;
            comidaextragrande.DibComida(dibujar);
            comidagrande.DibComida(dibujar);
            comida.DibComida(dibujar);
            serpiente.DibujarSerp(dibujar);

        }

        //Metodo cuando presionamos alguna tecla y las otras no
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //Cuando el timer esta en true, que es cuando iniciamos el juego y presionamos Enter,
                //entonces las demas teclas se volveran false
                timer1.Enabled = true;
                BarraPresionarEnter.Text = "";
                abajo = false;
                arriba = false;
                derecha = false;
                izquierda = false;
            }

            //Presionamos Space para mostrar las puntuaciones mas altas
            /*if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                foreach (Resultados re in Resultados.resultados)
                {
                    BarraPresionarSpace.Text += re.Puntuacion + "\n";
                }
                abajo = false;
                arriba = false;
                derecha = false;
                izquierda = false;
            }*/
            

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


            //Ciclo para colision de serpiente y comida
            for (int i = 0; i < serpiente.recSerpiente.Length; i++)
            {
                //Si el rectangulo de la serpiente se intersecta con el rectangulo de la comida entonces:
                if (serpiente.recSerpiente[i].IntersectsWith(comida.RecComida))
                {
                    //La puntuacion aumenta en 10
                    puntuacion += 10;
                    //Se llama al metodo de aumentar la serpiente
                    serpiente.AumentarSerp();
                    //Se da una nueva posicion para la comida
                    comida.PosicionComida(RandComida);
                }
                
                //Condicion para cuando se intersecte con la comida mas grande
                if (serpiente.recSerpiente[i].IntersectsWith(comidagrande.RecComida2))
                {
                    puntuacion += 5;
                    serpiente.AumentarSerp3();
                    comidagrande.PosicionComida(RandComida);
                }

                //Condicion para cuando se intersecte con la comida extra grande
                if (serpiente.recSerpiente[i].IntersectsWith(comidaextragrande.RecComida3))
                {
                    puntuacion += 1;
                    serpiente.AumentarSerp2();
                    comidaextragrande.PosicionComida(RandComida);
                }
            }
                    
            //Mandamos a llamar a los metodos para que se inicien cuando se cumplan

            Colision();
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
            if (serpiente.recSerpiente[0].X < 0 || serpiente.recSerpiente[0].X > 280)
            {
                Reiniciar();
            }

            //Colision en la parte de arriba o abajo de la pantalla
            if (serpiente.recSerpiente[0].Y < 0 || serpiente.recSerpiente[0].Y > 269)
            {
                Reiniciar();
            }

        }

        public void Reiniciar()
        {
            //Cuando tocas haces colision, el timer pasa a false y mostramos el msj
            timer1.Enabled = false;
            MessageBox.Show("Perdiste. \nTu Puntuacion es " + puntuacion);

            BarraPuntuacionSerpiente.Text = "0";
            puntuacion = 0;

            BarraPresionarEnter.Text = "Presiona Enter"; 
            serpiente = new Serpiente();

            /*
            BarraPresioanarSpace.Text = "Presiona Space para Puntuaciones";
            MessageBox.Show("Puntuaciones\n 1.-" + puntuacion);
            */

        }

        public void Ganar()
        {
            if (puntuacion >= 100)
            {
                //Si se cumple la condicion automaticamente el timer se vuelve false, y mostramos el msj y el reinicio
                timer1.Enabled = false;
                MessageBox.Show("Ganaste el juego\n Tu puntuacion es: " + puntuacion);
                BarraPuntuacionSerpiente.Text = "0";
                puntuacion = 0;
                
                BarraPresionarEnter.Text = ("Presiona Enter");
                serpiente = new Serpiente();
            }   
           
        }
    }
}



       

                
    

