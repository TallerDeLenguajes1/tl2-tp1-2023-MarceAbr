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
        Cadete cadete;

        public Pedido(int nro, string obs, string nombreC, string direccionC, string telefonoC, string datosReferenciaDireccionC, Cadete cad)
        {
            this.nro = nro;
            this.obs = obs;
            var cliente = new Cliente(nombreC,direccionC, telefonoC, datosReferenciaDireccionC);
            this.estados = estado.NoEntregado;
        }

        public void agregarCadete(Cadete cad)
        {
            this.cadete = cad;
        }

        public void verDireccionCliente()
        {

        }

        public void verDatosCliente()
        {

        }
        //Ver bien.
        public void cambiarEstado(estado estado)
        {
            if (this.estados == estado.NoEntregado)
            {
                this.estados = estado;  
            } else if(estado == estado.NoEntregado)
            {
                Console.WriteLine("No puede cambiar el estado a 'No entregado'");
            } else {
                Console.WriteLine("El estado del pedido ya fue cambiado anteriormente");
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