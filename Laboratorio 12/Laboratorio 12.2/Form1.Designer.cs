namespace Laboratorio_12._2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNotaUno = new System.Windows.Forms.Label();
            this.lblNotaDos = new System.Windows.Forms.Label();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNotaUno = new System.Windows.Forms.TextBox();
            this.txtNotaDos = new System.Windows.Forms.TextBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(160, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nota Promedio";
            // 
            // lblNotaUno
            // 
            this.lblNotaUno.AutoSize = true;
            this.lblNotaUno.Location = new System.Drawing.Point(57, 106);
            this.lblNotaUno.Name = "lblNotaUno";
            this.lblNotaUno.Size = new System.Drawing.Size(101, 20);
            this.lblNotaUno.TabIndex = 1;
            this.lblNotaUno.Text = " NOTA No. 1:";
            // 
            // lblNotaDos
            // 
            this.lblNotaDos.AutoSize = true;
            this.lblNotaDos.Location = new System.Drawing.Point(57, 144);
            this.lblNotaDos.Name = "lblNotaDos";
            this.lblNotaDos.Size = new System.Drawing.Size(97, 20);
            this.lblNotaDos.TabIndex = 2;
            this.lblNotaDos.Text = "NOTA No. 2:";
            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Location = new System.Drawing.Point(57, 186);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(97, 20);
            this.lblNotaTres.TabIndex = 3;
            this.lblNotaTres.Text = "NOTA No. 3:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(57, 304);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(118, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Nota Promedio:";
            // 
            // txtNotaUno
            // 
            this.txtNotaUno.Location = new System.Drawing.Point(224, 100);
            this.txtNotaUno.Name = "txtNotaUno";
            this.txtNotaUno.Size = new System.Drawing.Size(100, 26);
            this.txtNotaUno.TabIndex = 5;
            // 
            // txtNotaDos
            // 
            this.txtNotaDos.Location = new System.Drawing.Point(224, 144);
            this.txtNotaDos.Name = "txtNotaDos";
            this.txtNotaDos.Size = new System.Drawing.Size(100, 26);
            this.txtNotaDos.TabIndex = 6;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(224, 186);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(100, 26);
            this.txtNotaTres.TabIndex = 7;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(207, 301);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(117, 26);
            this.txtResultado.TabIndex = 8;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(61, 247);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(97, 29);
            this.btnPromedio.TabIndex = 9;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(168, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 30);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(246, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 29);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 439);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNotaTres);
            this.Controls.Add(this.txtNotaDos);
            this.Controls.Add(this.txtNotaUno);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNotaTres);
            this.Controls.Add(this.lblNotaDos);
            this.Controls.Add(this.lblNotaUno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Calcular Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNotaUno;
        private System.Windows.Forms.Label lblNotaDos;
        private System.Windows.Forms.Label lblNotaTres;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNotaUno;
        private System.Windows.Forms.TextBox txtNotaDos;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

