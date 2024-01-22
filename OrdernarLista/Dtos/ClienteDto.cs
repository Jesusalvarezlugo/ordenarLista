using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdernarLista.Dtos
{
    internal class ClienteDto
    {
        //Atributos

        long idCliente;
        string nombreCliente = "aaaaa";
        string apellidoCliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        int edadCliente = 0;

        

        //Getters y Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        //Constructores

        public ClienteDto()
        {
            
        }
        public ClienteDto(long idCliente, string nombreCliente, string apellidoCliente, string nombreCompletoCliente, int edadCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.nombreCompletoCliente = nombreCliente+" "+apellidoCliente;
            this.edadCliente = edadCliente;
        }


        //ToString

        override
        public string ToString()
        {
            string texto="Nombre: "+this.nombreCompletoCliente + "\n Edad:  " + this.edadCliente;

            return texto;
        }
    }
}
