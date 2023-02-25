using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarLanza
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        //Declaracion de Variables
        int numero;

        private int Numero(int numero)
        {
            for (numero = 1; numero <= 100; numero++)
            {
                Valores.Items.Add(numero);
                if (numero % 3 == 0)
                {

                    Valores.Items.Add(" Cesar Andres  ");
                }
                if (numero % 5 == 0)
                {
                    Valores.Items.Add(" Lanza Barahona ");

                }
                else if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Valores.Items.Add(" Cesar Andres Lanza Barahona ");
                }
            }
            return numero;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Numero(numero);
        }
    }
}
