using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15._4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            Double numeroA, numeroB, suma;
            numeroA = Convert.ToDouble(txtNumeroA.Text);
            numeroB = Convert.ToDouble(txtNumeroB.Text);
            suma = numeroA + numeroB;
            String resultado = suma.ToString();
            lblResultado.Text = "El resultado de la suma es: " + resultado;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "MessageBox", "window.alert('Operación Completada!\\nResultado en Pantalla.');", true);
        }
    }
}