using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Juego_Guerra
{
    class Terricola:Guerrero
    {
        private static int _cuantosVivos = 0;
        public Terricola(string nombre) : base(nombre)
        {
            _cuantosVivos++;
        }
        public int CuantosVivos
        {
            get { return _cuantosVivos; }
        }
        ///Se hace la clase recibir tiro y se compara con el estado del guerrero y su posición para
        ///poder matarlo.
        
        public void recibirDisparo(int tiro)
        {
            if (_Vivo && _Blanco == tiro)
            {
                _Vivo = false;
                _cuantosVivos--;
            }
        }

    }
}
