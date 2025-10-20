using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidad = Convert.ToDouble(txtVelocidad.Text);
            double tiempo = Convert.ToDouble(txtTiempo.Text);
            double distancia = velocidad * tiempo;
            txtResultado.Text = distancia.ToString() + "Km";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra toda la aplicación (Form1, Form2, etc)
            //this.close(); Cierra solo el formulario actual
        }
    }
}
