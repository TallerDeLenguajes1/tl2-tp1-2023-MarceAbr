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

        public void agregarNuevoCadete(Cadete cadete)
        {
            listadoCadetes.Add(cadete);
        }

        public void agregarNuevoPedido(Cadete cadete, Pedido pedido)
        {
            cadete.agregarPedido(pedido);
        }

        public void asignarPedidoACadete(Cadete cad, Pedido ped)
        {
            cad.agregarPedido(ped);
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