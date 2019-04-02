using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_Escaleras
{
    class Jugadores :Tablero
    {
        private int _num,_posicion;
        public int numero
        {
            get { return _num; }
        }
        public int posicon
        {
            get { return _posicion; }
        }
        public Jugadores(int numero)
        {
            _num = numero;
            _posicion = 0;
        }
        public void avanzar(int posicion)
        {
            posicion += vec[posicion];
        }
        public override string ToString()
        {
            return "Jugador: " + _num + " Esta en Posicion: " + _posicion;
        }

    }
}
