using System.Runtime.CompilerServices;

namespace tl2_tp1_2023_MarceAbr
{
    public enum estado 
    {
        NoEntregado, 
        Entregado,
        Cancelado
    }
    public class Pedido
    {
        private int nro;
        private string obs;
        private Cliente cliente;
        estado estados;

        public Pedido(int nro, string obs, string nombreC, string direccionC, string telefonoC, string datosReferenciaDireccionC)
        {
            this.nro = nro;
            this.obs = obs;
            var cliente = new Cliente(nombreC,direccionC, telefonoC, datosReferenciaDireccionC);
            this.estados = estado.NoEntregado;
        }

        public void verDireccionCliente()
        {

        }

        public void verDatosCliente()
        {

        }
        //Falta control para borrar en caso de cancelar el pedido.
        public void cambiarEstado(estado estado)
        {
            if (this.estados == estado.NoEntregado && estado == estado.Entregado)
            {
                this.estados = estado;  
            } else {
                Console.WriteLine("El pedido esta Entregado o Cancelado");
            }
        }
        

        public int getNro()
        {
            return this.nro;
        }
        public string getObs()
        {
            return this.obs;
        }
        public estado getEstado()
        {
            return this.estados;
        }
        
    }
}