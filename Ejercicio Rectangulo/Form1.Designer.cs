namespace Ejercicio_Rectangulo
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
            this.lBase = new System.Windows.Forms.Label();
            this.lAltura = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lMrectangulo = new System.Windows.Forms.Label();
            this.lBaseA = new System.Windows.Forms.Label();
            this.lAlturaA = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bListarcuadrados = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizaraltura = new System.Windows.Forms.Button();
            this.bActualizarbase = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lbRectangulos = new System.Windows.Forms.ListBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBaseA = new System.Windows.Forms.TextBox();
            this.txtAlturaA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lBase
            // 
            this.lBase.AutoSize = true;
            this.lBase.Location = new System.Drawing.Point(14, 29);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(34, 13);
            this.lBase.TabIndex = 0;
            this.lBase.Text = "Base:";
            // 
            // lAltura
            // 
            this.lAltura.AutoSize = true;
            this.lAltura.Location = new System.Drawing.Point(108, 29);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(37, 13);
            this.lAltura.TabIndex = 1;
            this.lAltura.Text = "Altura:";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(13, 332);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(61, 13);
            this.lCantidad.TabIndex = 2;
            this.lCantidad.Text = "Cantidad: 0";
            // 
            // lMrectangulo
            // 
            this.lMrectangulo.AutoSize = true;
            this.lMrectangulo.Location = new System.Drawing.Point(12, 362);
            this.lMrectangulo.Name = "lMrectangulo";
            this.lMrectangulo.Size = new System.Drawing.Size(103, 13);
            this.lMrectangulo.TabIndex = 3;
            this.lMrectangulo.Text = "Mayor Rectangulo: -";
            // 
            // lBaseA
            // 
            this.lBaseA.AutoSize = true;
            this.lBaseA.Location = new System.Drawing.Point(231, 141);
            this.lBaseA.Name = "lBaseA";
            this.lBaseA.Size = new System.Drawing.Size(34, 13);
            this.lBaseA.TabIndex = 4;
            this.lBaseA.Text = "Base:";
            // 
            // lAlturaA
            // 
            this.lAlturaA.AutoSize = true;
            this.lAlturaA.Location = new System.Drawing.Point(231, 202);
            this.lAlturaA.Name = "lAlturaA";
            this.lAlturaA.Size = new System.Drawing.Size(40, 13);
            this.lAlturaA.TabIndex = 5;
            this.lAlturaA.Text = "Altura: ";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(5, 399);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(342, 23);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = " Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bListarcuadrados
            // 
            this.bListarcuadrados.Location = new System.Drawing.Point(225, 312);
            this.bListarcuadrados.Name = "bListarcuadrados";
            this.bListarcuadrados.Size = new System.Drawing.Size(122, 23);
            this.bListarcuadrados.TabIndex = 7;
            this.bListarcuadrados.Text = "Listar cuadrados";
            this.bListarcuadrados.UseVisualStyleBackColor = true;
            this.bListarcuadrados.Click += new System.EventHandler(this.bListarcuadrados_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(225, 261);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(122, 23);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizaraltura
            // 
            this.bActualizaraltura.Location = new System.Drawing.Point(225, 232);
            this.bActualizaraltura.Name = "bActualizaraltura";
            this.bActualizaraltura.Size = new System.Drawing.Size(122, 23);
            this.bActualizaraltura.TabIndex = 9;
            this.bActualizaraltura.Text = "Actualizar altura";
            this.bActualizaraltura.UseVisualStyleBackColor = true;
            this.bActualizaraltura.Click += new System.EventHandler(this.bActualizaraltura_Click);
            // 
            // bActualizarbase
            // 
            this.bActualizarbase.Location = new System.Drawing.Point(225, 161);
            this.bActualizarbase.Name = "bActualizarbase";
            this.bActualizarbase.Size = new System.Drawing.Size(122, 23);
            this.bActualizarbase.TabIndex = 10;
            this.bActualizarbase.Text = "Actulizar base";
            this.bActualizarbase.UseVisualStyleBackColor = true;
            this.bActualizarbase.Click += new System.EventHandler(this.bActualizarbase_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(225, 99);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(122, 23);
            this.bPerimetro.TabIndex = 11;
            this.bPerimetro.Text = "Calcular perimetro ";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(225, 70);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(122, 23);
            this.bArea.TabIndex = 12;
            this.bArea.Text = "Calcular area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(225, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbRectangulos
            // 
            this.lbRectangulos.FormattingEnabled = true;
            this.lbRectangulos.Location = new System.Drawing.Point(12, 60);
            this.lbRectangulos.Name = "lbRectangulos";
            this.lbRectangulos.Size = new System.Drawing.Size(207, 238);
            this.lbRectangulos.TabIndex = 14;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(54, 26);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(35, 20);
            this.txtBase.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(151, 26);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(34, 20);
            this.txtAltura.TabIndex = 16;
            // 
            // txtBaseA
            // 
            this.txtBaseA.Location = new System.Drawing.Point(271, 138);
            this.txtBaseA.Name = "txtBaseA";
            this.txtBaseA.Size = new System.Drawing.Size(54, 20);
            this.txtBaseA.TabIndex = 17;
            // 
            // txtAlturaA
            // 
            this.txtAlturaA.Location = new System.Drawing.Point(272, 199);
            this.txtAlturaA.Name = "txtAlturaA";
            this.txtAlturaA.Size = new System.Drawing.Size(53, 20);
            this.txtAlturaA.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 432);
            this.Controls.Add(this.txtAlturaA);
            this.Controls.Add(this.txtBaseA);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lbRectangulos);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bActualizarbase);
            this.Controls.Add(this.bActualizaraltura);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bListarcuadrados);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lAlturaA);
            this.Controls.Add(this.lBaseA);
            this.Controls.Add(this.lMrectangulo);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label lMrectangulo;
        private System.Windows.Forms.Label lBaseA;
        private System.Windows.Forms.Label lAlturaA;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bListarcuadrados;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizaraltura;
        private System.Windows.Forms.Button bActualizarbase;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox lbRectangulos;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBaseA;
        private System.Windows.Forms.TextBox txtAlturaA;
    }
}

