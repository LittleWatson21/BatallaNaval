using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Guerra
{
    class Nave
    {
        private string _tipo;
        private Guerrero[] tripulantes = new Guerrero[10];
        //Constructor
        public Nave(string tipo) //Terricola o Marciano
        {
             if(tipo == "Terricola")
               for(int i=0; i< 10; i++)
                    tripulantes[i] = new Terricola("T" + i.Tostring());
            else
                for(int i=0; i< 10; i++)
                tripulantes[i] = new Marciano("Mx" + i.Tostring());
            _tipo = tipo;        
        }

        public int disparar(int turno)
        {
            return tripulantes[turno].Disparar();
        }

        public void RecibirDisparo(int disparo)
        {
            if (_tipo == "Terricola")
            {

                Terricola t;
                for (int i = 0; i < 10; i++)
                {
                    t = (Terricola)tripulantes[i];
                    t.recibirDisparo(disparo);
                }
            }

            else
            {
                for (int i = 0; i < 10; i++)
                {
                    ((Marciano)tripulantes[i]).recibirDisparo(disparo);
                }
            }
        }

        public int cuantosQuedan()
        {
            if (_tipo == "Terricola")
                return ((Terricola)tripulantes[0]).CuantosVivos;
            else
                return ((Marciano)tripulantes[5]).CuantosVivos;
        }
    }
}
 

    
      
    
        





      

