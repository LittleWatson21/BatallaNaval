using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Guerra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Terricola T1, T2;
            Marciano M1, M2;
            M1 = new Marciano("Puga");
            M2 = new Marciano("Josué");
            T1 = new Terricola("Lalo");
            T2 = new Terricola("El Emi");
            T2.recibirTiro(T1.Disparar());

        }
        Nave nave_terricola, nave_marciano;
        private void Iniciar_Guerra_Click(object sender, EventArgs e)
        {
            nave_terricola = new Nave("Terricola");
            nave_marciano = new Nave("Marciano");
            mostrar_Guerra = Batalla(nave_terricola, nave_marciano);
        }

        private string Batalla(Nave nave_marciano, Nave nave_terricola)
        {
            while(nave_marciano.cuantosQuedan()>0 && nave_terricola.cuantosQuedan()>0)

            {
                nave_marciano.RecibirDisparo(nave_terricola.disparar(turno));
                nave_terricola.RecibirDisparo(nave_marciano.disparar(turno));
            }

            if (nave_terricola.cuantosQuedan() > 0)
                return "Ganamos los terricolas, podemos seguir acabando el planeta";
            else
                return "Los marcianos llegaron ya y  llegaron bailando chacha cha";
        }
    }
}
