namespace tl2_tp1_2023_MarceAbr
{
    public class Pedido
    {
        private int nro;
        private string obs;
        private Cliente cliente;
        private bool estado;

        public Pedido(int nro, string obs, bool estado, string nombreC, string direccionC, string telefonoC, string datosReferenciaDireccionC)
        {
            this.nro = nro;
            this.obs = obs;
            var cliente = new Cliente(nombreC,direccionC, telefonoC, datosReferenciaDireccionC);
            this.estado = estado;
        }
    }
}