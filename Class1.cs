using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{
    internal class Cola
    {
        private int max;
        private int frente;
        private int final;
        private string[] Arreglo;

        public Cola(int m)
        {
            frente = -1;
            final = -1;
            max = m;
            Arreglo = new string[max];
        }

        public bool EstaVacio()
        {
            return (frente == -1);
        }

        public bool EstaLleno()
        {
            return (final == max - 1);
        }

        public bool Insertar(string dato)
        {
            if (!EstaLleno())
            {
                final++;
                Arreglo[final] = dato;
                if (frente == -1) frente = 0;
                return true;
            }
            return false;
        }

        public bool Eliminar()
        {
            if (!EstaVacio())
            {
                if (frente == final)
                {
                    // queda vacía
                    frente = -1;
                    final = -1;
                }
                else
                {
                    frente++;
                }
                return true;
            }
            return false;
        }

        public bool Buscar(string dato)
        {
            if (EstaVacio()) return false;
            for (int i = frente; i <= final; i++)
            {
                if (Arreglo[i] == dato) return true;
            }
            return false;
        }

        public void Vaciar()
        {
            frente = -1;
            final = -1;
        }

        public string[] Mostrar()
        {
            if (EstaVacio()) return new string[0];
            string[] elementos = new string[final - frente + 1];
            for (int i = frente, j = 0; i <= final; i++, j++)
            {
                elementos[j] = Arreglo[i];
            }
            return elementos;
        }
    }
}