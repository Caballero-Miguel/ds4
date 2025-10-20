using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;                  //Importacion del namespaces para manejo de datos
using System.Data.SqlClient;        //Importacion del namespaces para manejo de SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_13._2
{
    public partial class Form1 : Form
    {
        String connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try { 
                conexion.Open();
                MessageBox.Show("Se abrio la conexión");
                String consultaSql = "SELECT ProductName FROM [dbo].[Products]";
                SqlCommand comando = new SqlCommand(consultaSql);
                comando.Connection = conexion;
                SqlDataReader reader = comando.ExecuteReader();
                lstTablaProductos.Items.Clear();
                while (reader.Read())
                {
                    String producto = reader["ProductName"].ToString();
                    lstTablaProductos.Items.Add(producto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerro la conexión");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
