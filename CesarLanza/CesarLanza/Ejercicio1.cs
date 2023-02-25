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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //Declaracion de Variables
        double intereses;
        double total;
        int cantidad;
        double tasa;

        private double Intereses(double intereses, double total, int cantidad, double tasa)
        {
            cantidad = 200000;
            intereses = Convert.ToDouble(cantidad * 0.015) * 12;
            tasa = Convert.ToDouble(cantidad * 0.015);

            total = cantidad + intereses;
            TotalIntereses.Text = "L. " + (intereses).ToString();
            Txt_InteresesGanadosAño.Text = "L. " + (total).ToString();
            CantidadDepositadaTextBox.Text = "L. " + (cantidad).ToString();
            InteresMensual.Text = "L. " + (tasa).ToString();

            Meses.Items.Add("Intereses ganados en el mes de Enero          L. " + tasa);
            Meses.Items.Add("Intereses ganados en el mes de Febrero        L. " + (tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Marzo          L. " + (tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Abril          L. " + (tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Mayo           L. " + (tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Junio          L. " + (tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Julio:         L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Agosto         L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Septiembre     L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Octubre        L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Noviembre      L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa));
            Meses.Items.Add("Intereses ganados en el mes de Diciembre      L. " + (tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa + tasa));

            return intereses;
        }
        private void InteresesMensualButton_Click(object sender, EventArgs e)
        {
            Intereses(total, intereses, cantidad, tasa);
        }
    }
}
