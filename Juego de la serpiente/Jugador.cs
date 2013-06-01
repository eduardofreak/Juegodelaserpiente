using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    public class Jugador
    {
        int puntos;
        string nombre;
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public string Name
        {
            get { return nombre; }
            set { nombre= value; }
        }

        public Jugador()  { }


        public Jugador(string nom)
        { nombre = nom; }
 
    }
}
