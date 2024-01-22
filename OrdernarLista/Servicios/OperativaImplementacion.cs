using OrdernarLista.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdernarLista.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto clienteNuevo =  nuevoCliente();

            listaAntigua.Add(clienteNuevo);
        }

       

        private ClienteDto nuevoCliente()
        {
            ClienteDto cliente= new ClienteDto();

            Console.WriteLine("Introduzca el id del cliente: ");
            cliente.IdCliente=Int64.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del cliente: ");
            cliente.EdadCliente = Int32.Parse(Console.ReadLine());

            cliente.NombreCompletoCliente = cliente.NombreCliente + " " + cliente.ApellidoCliente;

            return cliente;
        }

        public void ordernarClientes(List<ClienteDto> listaAntigua)
        {
           
            for(int i = 0; i < listaAntigua.Count-1; i++)
            {
                for(int j=0; j < listaAntigua.Count - 1 - i;j++)
                {
                    

                    if (listaAntigua[j].EdadCliente > listaAntigua[i].EdadCliente)
                    {
                        ClienteDto temp=listaAntigua[j];
                        listaAntigua[j] = listaAntigua[j + 1];
                        listaAntigua[j + 1] = temp;
                    }
                }
            }
        }
    }
}
