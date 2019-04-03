using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syp
{
    class Jugadores : Tablero
    {
        private int _num, _posicion;
        public int numero
        {
            get { return _num; }
        }
        public int posicion
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
            _posicion += posicion;
            if (_posicion > 100)
            {
                _posicion = 100;
            }
            else
            {
                _posicion += vec[_posicion];
            }
        }
        public override string ToString()
        {
            return "Jugador: " + _num + " Esta en Posicion: " + _posicion;
        }
    }
}
