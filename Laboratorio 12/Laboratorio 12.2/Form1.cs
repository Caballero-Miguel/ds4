using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNotaUno.Text);
            double nota2 = Convert.ToDouble(txtNotaDos.Text);
            double nota3 = Convert.ToDouble(txtNotaTres.Text);
            double promedio = (nota1 + nota2 + nota3) / 3;
            txtResultado.Text = Math.Round(promedio, 2).ToString(); //Round(); metodo de la clase Math que redondea el resultado a 2 decimales, luego se convierte a cadena(String) para mostrar en el textbox.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNotaUno.Clear();
            txtNotaDos.Clear();
            txtNotaTres.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}