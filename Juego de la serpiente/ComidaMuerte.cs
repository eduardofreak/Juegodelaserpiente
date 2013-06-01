using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    public class ComidaMuerte
    {
        //Declaramos
        private int x, y, ancho, largo;
        private SolidBrush brocha;
        public Rectangle RecComidaMuerte;

        //Creamos un constructor para poner aleatoreamente la comida
        public ComidaMuerte(Random RandComida)
        {
            
            //le damos el rango en el que se podria colocar la comida
            x = RandComida.Next(0, 33) * 10;
            y = RandComida.Next(0, 29) * 10;

            //Rellenamos el rectangulo comida
            brocha = new SolidBrush(Color.Black);

            ancho = 20;
            largo = 20;

            RecComidaMuerte = new Rectangle(x, y, ancho, largo);
        }

        //Creamos un metodo para dar la posicion a la comida dentro del rango marcado
        public void PosicionComida(Random RandComida)
        {
            x = RandComida.Next(0, 33) * 10;
            y = RandComida.Next(0, 29) * 10;
        }

        //Creamos el metodo dibujar comida, dada la posicion aleatoria, es donde se creara y rellenara el rectangulo de comida
        public void DibComida(Graphics dibujar)
        {
            RecComidaMuerte.X = x;
            RecComidaMuerte.Y = y;

            dibujar.FillRectangle(brocha, RecComidaMuerte);
        }
    }
}