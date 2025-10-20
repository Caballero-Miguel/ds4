using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12._3
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC, semiperimetro; //Variables de clase, para no reescribir Convert... cada vez

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            //Metodo que Calcula el semiperimetro en el cuadro de texto correspondiente
            ladoA = Convert.ToDouble(txtLadoA.Text);
            ladoB = Convert.ToDouble(txtLadoB.Text);
            ladoC = Convert.ToDouble(txtLadoC.Text);
            semiperimetro = (ladoA + ladoB + ladoC) / 2;
            txtResultadoSp.Text = semiperimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            /*Formula para calcular el area de cualquier triangulo,
            Formula de Herón : Area = √(s(s-a)(s-b)(s-c))*/

            double Area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
            // el metodo Sqrt de la clase Math calcula la raiz cuadrada 

            txtResultadoArea.Text = Math.Round(Area, 2).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtResultadoSp.Clear();
            txtResultadoArea.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


