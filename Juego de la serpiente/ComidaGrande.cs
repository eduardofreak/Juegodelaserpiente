using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    class ComidaGrande
    {
        //Declaramos
        private int x, y, ancho, largo;
        private SolidBrush brocha;
        public Rectangle RecComida2;

        //Creamos un constructor para poner aleatoreamente la comida
        public ComidaGrande(Random RandComida)
        {
            //le damos el rango en el que se podria colocar la comida
            x = RandComida.Next(0, 28) * 10;
            y = RandComida.Next(0, 26) * 10;

            //Rellenamos el rectangulo comida
            brocha = new SolidBrush(Color.Yellow);

            ancho = 15;
            largo = 15;

            RecComida2 = new Rectangle(x, y, ancho, largo);
        }

        //Creamos un metodo para dar la posicion a la comida dentro del rango marcado
        public void PosicionComida(Random RandComida)
        {
            x = RandComida.Next(0, 28) * 10;
            y = RandComida.Next(0, 26) * 10;
        }

        //Creamos el metodo dibujar comida, dada la posicion aleatoria, es donde se creara y rellenara el rectangulo de comida
        public void DibComida(Graphics dibujar)
        {
            RecComida2.X = x;
            RecComida2.Y = y;

            dibujar.FillRectangle(brocha, RecComida2);
        }

    }
}