using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{
    public partial class Form1 : Form
    {
        Cola Lista = new Cola(5);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;

            if (dato != "")
            {
                if (Lista.Insertar(dato))
                    MostrarCola();
                else
                    MessageBox.Show("La cola está llena");
            }
            else
            {
                MessageBox.Show("Ingrese un valor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Eliminar())
                MostrarCola();
            else
                MessageBox.Show("La cola está vacía");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;

            if (dato != "")
            {
                if (Lista.Buscar(dato))
                    MessageBox.Show("Elemento encontrado en la cola");
                else
                    MessageBox.Show("Elemento NO encontrado");
            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            Lista.Vaciar();
            MostrarCola();
        }

        private void MostrarCola()
        {
            lstDatosS.Items.Clear();
            foreach (string item in Lista.Mostrar())
            {
                lstDatosS.Items.Add(item);
            }
        }
    }
}    

