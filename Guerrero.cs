using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Guerra
{
    abstract class Guerrero : SerVivo
    {
        private string _Nombre;
        protected int _Blanco; // indicara la posición del guerrero.
        private static Random ran = new Random();

        public Guerrero (string nombre)
        {
            _Nombre = nombre;
            _Blanco = ran.Next(10);
        }

        public string  Nombre
        {
            get { return _Nombre; }
        }
        public int Disparar ()
        {
            if (_Vivo)
                return ran.Next(10);
            else return -1;
        }
        public override string ToString()
        {
            return _Nombre +  base.ToString();
        }
    }
}
