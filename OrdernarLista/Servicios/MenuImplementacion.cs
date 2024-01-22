using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdernarLista.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("#################");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Dar Alta Cliente");
            Console.WriteLine("2. Ordernar lista de clientes");
            Console.WriteLine("#################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
