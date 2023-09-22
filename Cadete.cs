namespace tl2_tp1_2023_MarceAbr
{
    public class Cadete
    {
        private int id = 0;
        private string nombre;
        private string direccion;
        private string telefono;
        private int cantEntregados;

        public Cadete(int v, string nombre, string direccion, string telefono)
        {
            this.id++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.cantEntregados = 0;
        }

        //Cambiar estado
        // public void cambiarEstado(int num, estado estado)
        // {
        //     foreach (Pedido pedido in pedidos)
        //     {
        //         if (pedido.getNro() == num)
        //         {
        //             pedido.cambiarEstado(estado);
        //             if (estado == estado.Entregado)
        //             {
        //                 this.cantEntregados++;
        //             }
        //         }
        //     }
        // }

        //Mostrar pedidos
        // public void mostrarPedidos()
        // {
        //     Console.WriteLine("Pedidos del cadete de ID: " + getID() + "\n");
        //     foreach (var ped in pedidos)
        //     {
        //         Console.WriteLine("Pedido Nro: " + ped.getNro());
        //         Console.WriteLine("Observacion: " + ped.getObs());
        //         Console.WriteLine("Estado: " + ped.getEstado() + "\n");
        //     }
        //     Console.WriteLine("Entregados: " + getCantidadEntregado());
        // }

        //Devuelve el Nro del pedido
        // public bool existePedido(int numPed)
        // {
        //     bool valor = false;
        //     foreach (var ped in pedidos)
        //     {
        //         if (ped.getNro() == numPed)
        //         {
        //             return valor = true;
        //         }
        //     }
        //     return valor;
        // }

        //Borrar un pedido
        // public void borrarPedidoDeCadete(Pedido ped)
        // {
        //     pedidos.Remove(ped);
        // }

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