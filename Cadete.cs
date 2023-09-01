namespace tl2_tp1_2023_MarceAbr
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private List<Pedido> pedidos;
        private int cantEntregados;

        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            pedidos = new List<Pedido>();
            this.cantEntregados = 0;
        }

        public void JornalACobrar()
        {

        }
        //Agregar pedido
        public void agregarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        //Cambiar estado
        public void cambiarEstado(int num, estado estado)
        {
            foreach (Pedido pedido in pedidos)
            {
                if (pedido.getNro() == num)
                {
                    pedido.cambiarEstado(estado);
                    if (estado == estado.Entregado)
                    {
                        this.cantEntregados++;
                    }
                }
            }
        }

        //Mostrar pedidos
        public void mostrarPedidos()
        {
            Console.WriteLine("Pedidos del cadete de ID: " + getID() + "\n");
            foreach (var ped in pedidos)
            {
                Console.WriteLine("Pedido Nro: " + ped.getNro());
                Console.WriteLine("Observacion: " + ped.getObs());
                Console.WriteLine("Estado: " + ped.getEstado() + "\n");
            }
            Console.WriteLine("Entregados: " + getCantidadEntregado());
        }

        public int getID()
        {
            return this.id;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getDireccion()
        {
            return this.direccion;
        }
        public string getTelefono()
        {
            return this.telefono;
        }
        public int getCantidadEntregado()
        {
            return this.cantEntregados;
        }
    } 
}