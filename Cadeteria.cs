namespace tl2_tp1_2023_MarceAbr
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> listadoCadetes;

        public Cadeteria(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            listadoCadetes = new List<Cadete>();
        }

        //Agrega nuevo cadete
        public void agregarNuevoCadete(Cadete cadete)
        {
            listadoCadetes.Add(cadete);
        }

        //Crea un nuevo pedido
        public void agregarNuevoPedido(Cadete cadete, Pedido pedido)
        {
            cadete.agregarPedido(pedido);
        }

        //Asigna o reasigna un pedido a un cadete
        public void asignarPedidoACadete(Cadete cad, Pedido ped)
        {   
            if (cad.existePedido(ped.getNro()))
            {
                Console.WriteLine("Este cadete ya tiene este pedido");
            } else {
                foreach (var cadete in listadoCadetes)
                {
                    if(cadete.existePedido(ped.getNro()))
                    {
                        cadete.borrarPedidoDeCadete(ped);
                    }
                }
                cad.agregarPedido(ped);
            }
        }

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