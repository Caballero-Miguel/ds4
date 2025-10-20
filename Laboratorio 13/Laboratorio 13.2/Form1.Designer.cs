namespace Laboratorio_13._2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConexion = new System.Windows.Forms.Button();
            this.lstTablaProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.LightGray;
            this.btnConexion.Location = new System.Drawing.Point(203, 47);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(222, 123);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Conectar y Desconectar de SQL Server";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // lstTablaProductos
            // 
            this.lstTablaProductos.FormattingEnabled = true;
            this.lstTablaProductos.ItemHeight = 20;
            this.lstTablaProductos.Location = new System.Drawing.Point(137, 190);
            this.lstTablaProductos.Name = "lstTablaProductos";
            this.lstTablaProductos.Size = new System.Drawing.Size(360, 264);
            this.lstTablaProductos.TabIndex = 1;
            this.lstTablaProductos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 496);
            this.Controls.Add(this.lstTablaProductos);
            this.Controls.Add(this.btnConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.ListBox lstTablaProductos;
    }
}

