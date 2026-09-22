using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Herencia
{
    public partial class Form1 : Form
    {
        Persona[] arregloPersona = new Persona[100];
        Estudiante[] arregloEstudiante = new Estudiante[100];
        int cantidadP = 0;
        int cantidadE = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any(char.IsDigit) || txtApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre y el apellido no pueden contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string nombreTemporal = txtNombre.Text;
            string apellidoTemporal = txtApellido.Text;
            int dniTemporal = Convert.ToInt32(txtDocumento.Text.Replace(".", "").Replace(" ", ""));
            DateTime fechanacTemporal = dtpFechanacimiento.Value;
            if (chkEstudiante.Checked == true)
            {
                int legajoTemporal;
                if (int.TryParse(txtLegajo.Text, out legajoTemporal) == false)
                {
                    MessageBox.Show("El legajo debe ser un número válido, sin letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string carreraTemporal = txtCarrera.Text;
                DateTime fechaingTemporal = dtpFechaingreso.Value;

                Estudiante unEstudiante = new Estudiante(legajoTemporal, carreraTemporal, fechaingTemporal, dniTemporal, nombreTemporal, apellidoTemporal, fechanacTemporal);
                arregloEstudiante[cantidadE] = unEstudiante;
                cantidadE++;
            }
            else
            {
                Persona unaPersona = new Persona(nombreTemporal, apellidoTemporal, dniTemporal, fechanacTemporal);
                arregloPersona[cantidadP] = unaPersona;
                cantidadP++;
            }

            cbFiltro_SelectedIndexChanged(sender, e);
        }

        
        private void ActualizarLista()
        {
            lbPersonas.Items.Clear(); 
            
            for (int i = 0; i < cantidadP; i++)
            {
                lbPersonas.Items.Add(arregloPersona[i].Mostrar());
            }

            for (int i = 0; i < cantidadE; i++)
            {
                lbPersonas.Items.Add(arregloEstudiante[i].Mostrar());
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFiltro.SelectedItem == null) return; 

            lbPersonas.Items.Clear();

            string opcionSeleccionada = cbFiltro.SelectedItem.ToString().Trim().ToUpper();

            if (opcionSeleccionada == "TODOS")
            {
                ActualizarLista();
            }
            else if (opcionSeleccionada == "ESTUDIANTES")
            {
                for (int i = 0; i < cantidadE; i++)
                {
                    lbPersonas.Items.Add(arregloEstudiante[i].Mostrar());
                }
            }
            else if (opcionSeleccionada == "NO ESTUDIANTES")
            {
                for (int i = 0; i < cantidadP; i++)
                {
                    lbPersonas.Items.Add(arregloPersona[i].Mostrar());
                }
            }
        }
       
        private void bBuscar_Click(object sender, EventArgs e)
        {
            
            int dniBuscado = Convert.ToInt32(txtDocumento.Text.Replace(".", "").Replace(" ", ""));
            bool encontrado = false;

            
            for (int i = 0; i < cantidadP; i++)
            {
                if (arregloPersona[i].getDni() == dniBuscado)
                {
                    MessageBox.Show("Persona encontrada: " + arregloPersona[i].Mostrar());
                    encontrado = true;
                }
            }

           
            for (int i = 0; i < cantidadE; i++)
            {
                if (arregloEstudiante[i].getDni() == dniBuscado) 
                {
                    MessageBox.Show("Estudiante encontrado: " + arregloEstudiante[i].Mostrar());
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("No se encontró a nadie con ese DNI.");
            }
        }
    }
}
