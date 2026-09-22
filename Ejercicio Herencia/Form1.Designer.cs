namespace Ejercicio_Herencia
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
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.lFechanacimiento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lDocumento = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.pnlEstudiante = new System.Windows.Forms.Panel();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.dtpFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.lFechaingreso = new System.Windows.Forms.Label();
            this.lCarrera = new System.Windows.Forms.Label();
            this.lLegajo = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lFiltro = new System.Windows.Forms.Label();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.pnlPersona.SuspendLayout();
            this.pnlEstudiante.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPersona
            // 
            this.pnlPersona.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlPersona.Controls.Add(this.txtNombre);
            this.pnlPersona.Controls.Add(this.txtApellido);
            this.pnlPersona.Controls.Add(this.dtpFechanacimiento);
            this.pnlPersona.Controls.Add(this.lFechanacimiento);
            this.pnlPersona.Controls.Add(this.txtDocumento);
            this.pnlPersona.Controls.Add(this.lDocumento);
            this.pnlPersona.Controls.Add(this.chkEstudiante);
            this.pnlPersona.Controls.Add(this.lApellido);
            this.pnlPersona.Controls.Add(this.lNombre);
            this.pnlPersona.Location = new System.Drawing.Point(12, 12);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(267, 147);
            this.pnlPersona.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(99, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechanacimiento.Location = new System.Drawing.Point(99, 97);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechanacimiento.TabIndex = 6;
            // 
            // lFechanacimiento
            // 
            this.lFechanacimiento.AutoSize = true;
            this.lFechanacimiento.Location = new System.Drawing.Point(14, 103);
            this.lFechanacimiento.Name = "lFechanacimiento";
            this.lFechanacimiento.Size = new System.Drawing.Size(79, 13);
            this.lFechanacimiento.TabIndex = 5;
            this.lFechanacimiento.Text = "Fecha de nac.:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(99, 73);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // lDocumento
            // 
            this.lDocumento.AutoSize = true;
            this.lDocumento.Location = new System.Drawing.Point(28, 73);
            this.lDocumento.Name = "lDocumento";
            this.lDocumento.Size = new System.Drawing.Size(65, 13);
            this.lDocumento.TabIndex = 4;
            this.lDocumento.Text = "Documento:";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(108, 123);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chkEstudiante.TabIndex = 1;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(46, 50);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(47, 13);
            this.lApellido.TabIndex = 3;
            this.lApellido.Text = "Apellido:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(46, 29);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // pnlEstudiante
            // 
            this.pnlEstudiante.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlEstudiante.Controls.Add(this.txtLegajo);
            this.pnlEstudiante.Controls.Add(this.txtCarrera);
            this.pnlEstudiante.Controls.Add(this.dtpFechaingreso);
            this.pnlEstudiante.Controls.Add(this.lFechaingreso);
            this.pnlEstudiante.Controls.Add(this.lCarrera);
            this.pnlEstudiante.Controls.Add(this.lLegajo);
            this.pnlEstudiante.Location = new System.Drawing.Point(12, 165);
            this.pnlEstudiante.Name = "pnlEstudiante";
            this.pnlEstudiante.Size = new System.Drawing.Size(267, 125);
            this.pnlEstudiante.TabIndex = 1;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(99, 22);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 5;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(99, 51);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 4;
            // 
            // dtpFechaingreso
            // 
            this.dtpFechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaingreso.Location = new System.Drawing.Point(99, 80);
            this.dtpFechaingreso.Name = "dtpFechaingreso";
            this.dtpFechaingreso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaingreso.TabIndex = 3;
            // 
            // lFechaingreso
            // 
            this.lFechaingreso.AutoSize = true;
            this.lFechaingreso.Location = new System.Drawing.Point(16, 86);
            this.lFechaingreso.Name = "lFechaingreso";
            this.lFechaingreso.Size = new System.Drawing.Size(77, 13);
            this.lFechaingreso.TabIndex = 2;
            this.lFechaingreso.Text = "Fecha ingreso:";
            // 
            // lCarrera
            // 
            this.lCarrera.AutoSize = true;
            this.lCarrera.Location = new System.Drawing.Point(49, 54);
            this.lCarrera.Name = "lCarrera";
            this.lCarrera.Size = new System.Drawing.Size(44, 13);
            this.lCarrera.TabIndex = 1;
            this.lCarrera.Text = "Carrera:";
            // 
            // lLegajo
            // 
            this.lLegajo.AutoSize = true;
            this.lLegajo.Location = new System.Drawing.Point(51, 25);
            this.lLegajo.Name = "lLegajo";
            this.lLegajo.Size = new System.Drawing.Size(42, 13);
            this.lLegajo.TabIndex = 0;
            this.lLegajo.Text = "Legajo:";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.Khaki;
            this.pnlFiltro.Controls.Add(this.cbFiltro);
            this.pnlFiltro.Controls.Add(this.lFiltro);
            this.pnlFiltro.Controls.Add(this.lbPersonas);
            this.pnlFiltro.Location = new System.Drawing.Point(299, 12);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(198, 278);
            this.pnlFiltro.TabIndex = 2;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "TODOS",
            "Estudiantes",
            "NO estudiantes"});
            this.cbFiltro.Location = new System.Drawing.Point(17, 26);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 2;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(14, 10);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(32, 13);
            this.lFiltro.TabIndex = 1;
            this.lFiltro.Text = "Filtro:";
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.Location = new System.Drawing.Point(17, 53);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.Size = new System.Drawing.Size(167, 212);
            this.lbPersonas.TabIndex = 0;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(12, 311);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(232, 311);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(422, 311);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 346);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlEstudiante);
            this.Controls.Add(this.pnlPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlPersona.ResumeLayout(false);
            this.pnlPersona.PerformLayout();
            this.pnlEstudiante.ResumeLayout(false);
            this.pnlEstudiante.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersona;
        private System.Windows.Forms.Panel pnlEstudiante;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.Label lFechanacimiento;
        private System.Windows.Forms.Label lDocumento;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.DateTimePicker dtpFechaingreso;
        private System.Windows.Forms.Label lFechaingreso;
        private System.Windows.Forms.Label lCarrera;
        private System.Windows.Forms.Label lLegajo;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCerrar;
    }
}

