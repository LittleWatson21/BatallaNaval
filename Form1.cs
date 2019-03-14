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
            T1 = new Terricola ("Lalo");
            T2 = new Terricola("El Emi");
            T2.recibirTiro(T1.Disparar());

        }
    }
}
