using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdernarLista.Dtos;

namespace OrdernarLista.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);

        public void ordernarClientes(List<ClienteDto> listaAntigua);
    }
}
