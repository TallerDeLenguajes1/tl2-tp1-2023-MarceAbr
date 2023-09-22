using System.Reflection;

namespace tl2_tp1_2023_MarceAbr
{
    public class Cadeteria
    {
        private string nombre { get; set; }
        private string telefono { get; set; }
        private List<Cadete> listadoCadetes { get; set; }
        private List<Pedido> listadoPedidos { get; set; }

        public Cadeteria(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            listadoCadetes = new List<Cadete>();
            listadoPedidos = new List<Pedido>();
        }

        public float JornalACobrar(int id)
        {
            foreach (var cad in listadoCadetes)
            {
                if (cad.getID()== id)
                {
                    return (cad.getCantidadEntregado() * 500);
                }
            }
            return 0;
        }

        //Asigna o reasigna un pedido a un cadete
        public void asignarPedidoACadete(Cadete cad, Pedido ped)
        {   
            ped.agregarCadete(cad);
        }

        //Agrega nuevo cadete
        public void agregarNuevoCadete(Cadete cadete)
        {
            listadoCadetes.Add(cadete);
        }

        public void agregarNuevoPedido(Pedido ped)
        {
            listadoPedidos.Add(ped);
        }

        //Crea un nuevo pedido
        // public void agregarNuevoPedido(Cadete cadete, Pedido pedido)
        // {
        //     cadete.agregarPedido(pedido);
        // }

        //Asigna o reasigna un pedido a un cadete
        // public void asignarPedidoACadete(Cadete cad, Pedido ped)
        // {   
        //     if (cad.existePedido(ped.getNro()))
        //     {
        //         Console.WriteLine("Este cadete ya tiene este pedido");
        //     } else {
        //         foreach (var cadete in listadoCadetes)
        //         {
        //             if(cadete.existePedido(ped.getNro()))
        //             {
        //                 cadete.borrarPedidoDeCadete(ped);
        //             }
        //         }
        //         cad.agregarPedido(ped);
        //     }
        // }

        public void listarCadetes()
        {
            foreach (var cadete in listadoCadetes)
            {
                Console.WriteLine("ID: " + cadete.getID());
                Console.WriteLine("Nombre: " + cadete.getNombre());
                Console.WriteLine("Direccion: " + cadete.getDireccion());
                Console.WriteLine("Telefono: " + cadete.getTelefono() + "\n");
            }
        }
    }
}