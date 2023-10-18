using System.Collections.Generic;
using System.Text;

namespace Practica_Pilas
{
    class Nodo
    {
        public object dato;
        public Nodo sig;

        public Nodo(object el, Nodo els)
        {
            dato = el;
            sig = els;
        }
    }
 

}