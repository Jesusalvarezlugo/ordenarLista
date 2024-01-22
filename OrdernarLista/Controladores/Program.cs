using OrdernarLista.Dtos;
using OrdernarLista.Servicios;

namespace OrdernarLista
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            
            List<ClienteDto> listaClientes=new List<ClienteDto>();
            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionS = mi.mostrarMenuYSeleccion();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrara el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se dara de alta un nuevo cliente.");

                        string respuesta = " ";
                        do
                        {
                            oi.darAltaCliente(listaClientes);

                            Console.WriteLine("¿Quiere dar de alta a otro cliente?");
                            respuesta=Console.ReadLine();

                        } while (respuesta =="s");
                        

                        

                        break;

                    case 2:
                        Console.WriteLine("[INFO] Se ordenara la lista de clientes");

                        if(listaClientes.Count <= 2)
                        {
                            Console.WriteLine("[Error!] Son necesarios al menos 3 clientes para poder ordenar la lista.");
                            break;
                        }

                        else
                        {
                            foreach (ClienteDto cliente in listaClientes)
                            {
                                Console.WriteLine(cliente.ToString());
                               
                            }
                        }

                        oi.ordernarClientes(listaClientes);

                        foreach(ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }

                        


                        break;

                    default:
                        Console.WriteLine("[ERROR] opcion introducida erronea.");
                        
                        break;
                }
            }
        }
    }
}
