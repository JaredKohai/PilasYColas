using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pilas
{
    class Estructura_Pila
    {
        private object[] Pila;
        protected int indx, limit;

        public Estructura_Pila(int n)
        {
            Pila = new object[n];
            limit = n - 1;
            indx = -1;
        }

        public void Inserta(object el)
        {
            if (lleno())
                System.Console.WriteLine("La pila esta llena");
            else
            {
                indx++;
                Pila[indx] = el;
            }

        }

        public object Retira()
        {
            object tmp;
            if (vacio()) return "No hay elementos";
            else
            {
                tmp = Pila[indx];
                indx--;
                return tmp;
            }
        }

        private bool lleno()
        {
            if (indx == limit) return true;
            return false;
        }

        private bool vacio()
        {
            if (indx == -1) return true;
            return false;
        }

        public void imprime()
        {
            int n;
            if (vacio()) System.Console.WriteLine("La pila esta vacia");
            else
            {
                for (n = indx; n >= 0; n--)
                    System.Console.WriteLine("*********** " + Pila[n] + "        *************");
            }
        }

        public object tope()
        {
            if (vacio()) return "No hay elementos";
            else return Pila[indx];
        }

        public bool busqueda(object el)
        {
            int i;
            for (i = 0; i < limit; i++)
            {
                if (Pila[i].Equals(el)) return true;
            }
            return false;
        }
    }
}
