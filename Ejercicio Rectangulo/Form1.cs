using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Rectangulo
{
    public partial class Form1 : Form
    {
        int cantidad = 0;
        Rectangulo[] arregloRectangulos = new Rectangulo[100];
        public Form1()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            lCantidad.Text = "Cantidad: " + cantidad;
            if (cantidad == 0)
            {
                lMrectangulo.Text = "Mayor Rectangulo: -";
            }
            else
            {
                Rectangulo elMayor = arregloRectangulos[0];
                for (int i = 1; i < cantidad; i++)
                {
                    if (arregloRectangulos[i].Area() > elMayor.Area())
                    {
                        elMayor = arregloRectangulos[i];
                    }
                }
                lMrectangulo.Text = "Mayor Rectangulo: Base: " + elMayor.getbase() + " y altura: " + elMayor.getaltura();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            double baseUsuario = Convert.ToDouble(txtBase.Text);
            double alturaUsuario = Convert.ToDouble(txtAltura.Text);

            Rectangulo nuevoRectangulo = new Rectangulo(baseUsuario, alturaUsuario);

            arregloRectangulos[cantidad] = nuevoRectangulo;

            cantidad++;
            lbRectangulos.Items.Add("Rectangulo con base: " + nuevoRectangulo.getbase() + " y altura: " + nuevoRectangulo.getaltura());
            actualizar();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex != -1)
            {
                int posicion = lbRectangulos.SelectedIndex;
                Rectangulo rectanguloElegido = arregloRectangulos[posicion];
                double resultadoArea = rectanguloElegido.Area();
                MessageBox.Show("El area del rectangulo seleccionado es: " + resultadoArea);
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun Rectangulo");

            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex != -1)
            {
                int posicion = lbRectangulos.SelectedIndex;
                Rectangulo rectanguloSeleccionado = arregloRectangulos[posicion];
                double resultadoPerimetro = rectanguloSeleccionado.Perimetro();
                MessageBox.Show("El perimetro del rectangulo seleccionado es: " + resultadoPerimetro);
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun Rectangulo");
            }

        }

        private void bActualizarbase_Click(object sender, EventArgs e)
        {
          if (lbRectangulos.SelectedIndex != -1)
            {
                int posicion = lbRectangulos.SelectedIndex;
                double baseActualizada = Convert.ToDouble(txtBaseA.Text);
                Rectangulo rectanguloSeleccionado = arregloRectangulos[posicion];
                rectanguloSeleccionado.setbase(baseActualizada);
                lbRectangulos.Items[posicion] = ("Rectangulo con base: " + rectanguloSeleccionado.getbase() + " y altura: " + rectanguloSeleccionado.getaltura());
            }
          else
            {
                MessageBox.Show("No has seleccionado ningun Rectangulo");
            }
            actualizar();
        }

        private void bActualizaraltura_Click(object sender, EventArgs e)
        {
            if (lbRectangulos.SelectedIndex != -1)
            {
                int posicion = lbRectangulos.SelectedIndex;
                double alturaActualizada = Convert.ToDouble(txtAlturaA.Text);
                Rectangulo rectanguloSeleccionado = arregloRectangulos[posicion];
                rectanguloSeleccionado.setaltura(alturaActualizada);
                lbRectangulos.Items[posicion] = ("Rectangulo con base: " + rectanguloSeleccionado.getbase() + " y altura: " + rectanguloSeleccionado.getaltura());
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun Rectangulo");
            }
            actualizar();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
           if (lbRectangulos.SelectedIndex != -1)
            {
                int posicion = lbRectangulos.SelectedIndex;
                Rectangulo rectanguloSeleccionado = arregloRectangulos[posicion];
                lbRectangulos.Items.RemoveAt(posicion);
                for ( int i = posicion; i < cantidad -1; i++)
                {
                    arregloRectangulos[i] = arregloRectangulos[i + 1];         
                }
                cantidad--;
                arregloRectangulos[cantidad] = null;
                MessageBox.Show("Rectángulo eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un rectángulo para eliminar.");
            }
            actualizar();
        }

        private void bListarcuadrados_Click(object sender, EventArgs e)
        {
            string mensajeCuadrados = "Los rectangulos cuadrados encontrados son:\n\n";
            bool alMenosUno = false;
            for (int i = 0; i < cantidad; i++)
            {
                Rectangulo rectanguloActual = arregloRectangulos[i];
                if (arregloRectangulos[i].esCuadrado() == true)
                {
                    mensajeCuadrados += "Posicion: " + i + " con base: " + rectanguloActual.getbase() + " y altura: " + rectanguloActual.getaltura() + "\n";
                    alMenosUno = true;
                }
            }
            if (alMenosUno == false)
                {
                    MessageBox.Show("No hay ningun Rectangulo Cuadrado.");
                }
            else
                {
                    MessageBox.Show(mensajeCuadrados);
                }
        }
    }
}
