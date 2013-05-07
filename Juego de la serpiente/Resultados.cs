using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    class Resultados
    {
        public int Puntuacion { get; set; }
        public static List<Resultados> resultados = new List<Resultados>();
        public Resultados(int puntuacion)
        {
            this.Puntuacion = puntuacion;            
            Resultados p = new Resultados(puntuacion);
            resultados.Add(p);
        }
    }
}
