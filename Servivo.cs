using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Guerra
{
     abstract class SerVivo
    {
        protected bool _Vivo;
        
            public SerVivo()
        {
            _Vivo = true;
        }
        
        public bool Vivo
        {
            get { return _Vivo; }
        }
        public override string ToString()
        {
            if (_Vivo)
                return "Está vivo.";
            else
                return "Está muerto";
        }
    }
}
