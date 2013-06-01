using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    public class Serpiente
    {
        //El rectangulo de la serpiente se pone en privado para que no sea modificado
        private Rectangle[] RecSerpiente;
        private SolidBrush brocha;
        private int x, y, ancho, largo;

        //Como en los constructores de colision utilizamos el rectangulo de serpiente, 
        //debemos llamar a la clase rectangulo privada y que nos los regrese para ser utilizada en la clase form1
        public Rectangle[] recSerpiente
        {
            get { return RecSerpiente; }
        }

        //Creamos el constructor serpiente, para dibujar y dar cordenadas
        public Serpiente()
        {
            //Creamos los 3 rectangulos del mismo ancho y largo, damos cordenadas de inicio
            RecSerpiente = new Rectangle[3];
            brocha = new SolidBrush(Color.Blue);

            x = 20;
            y = 0;
            ancho = 10;
            largo = 10;

            //Creamos un ciclo para cuando nos movemos 
            for (int i = 0; i < RecSerpiente.Length; i++)
            {
                RecSerpiente[i] = new Rectangle(x, y, ancho, largo);
                x -= 10;
            }
        }

        //Creamos el metodo dibujar la serpiente para dar relleno 
        public void DibujarSerp(Graphics dibujar)
        {
            //Rellenamos los rectangulos
            foreach (Rectangle rec in RecSerpiente)
            {
                dibujar.FillRectangle(brocha, rec);
            }

        }

        public void DibujarSerp()
        {
            //Creamos un ciclo para que se vaya quitando la parte de atras de la serpiente, cuando nos movemos
            for (int i = RecSerpiente.Length - 1; i > 0; i--)
            {
                RecSerpiente[i] = RecSerpiente[i - 1];
            }
        }

        //Creamos los metodos para los 4 diferentes movimientos
        public void MoverAbajo()
        {
            DibujarSerp();
            RecSerpiente[0].Y += 10;
        }

        public void MoverArriba()
        {
            DibujarSerp();
            RecSerpiente[0].Y -= 10;
        }

        public void MoverDerecha()
        {
            DibujarSerp();
            RecSerpiente[0].X += 10;
        }

        public void MoverIzquierda()
        {
            DibujarSerp();
            RecSerpiente[0].X -= 10;
        }


        //Creamos el metodo para cuando la serpiente come, con una lista donde se guardara el nuevo rectangulo.
        public void AumentarSerp()
        {
            List<Rectangle> rec = RecSerpiente.ToList();
            //Agregamos el nuevo rectangulo en la parte de atras de la serpiente
            rec.Add(new Rectangle(RecSerpiente[RecSerpiente.Length - 1].X, RecSerpiente[RecSerpiente.Length - 1].Y, ancho, largo));
            RecSerpiente = rec.ToArray();
        }

        public void AumentarSerp2()
        {
            List<Rectangle> rec = RecSerpiente.ToList();
            //Agregamos un ciclo para poner rectangulos en la parte de atras
            for (int a = 1; a <= 2; a++)
            {
                rec.Add(new Rectangle(RecSerpiente[a].X, RecSerpiente[a].Y, ancho, largo));
                RecSerpiente = rec.ToArray();
            }
        }

        public void AumentarSerp3()
        {
            List<Rectangle> rec = RecSerpiente.ToList();
            //Agregamos un ciclo para poner rectangulos en la parte de atras
            for (int a = 1; a <= 3; a++)
            {
                rec.Add(new Rectangle(RecSerpiente[a].X, RecSerpiente[a].Y, ancho, largo));
                RecSerpiente = rec.ToArray();
            }
        }
    }
}



