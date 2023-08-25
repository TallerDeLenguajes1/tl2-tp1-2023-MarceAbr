namespace tl2_tp1_2023_MarceAbr
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> listadoCadetes;

        public Cadeteria(string nombre, string telefono, Cadete cadete)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            listadoCadetes.Add(cadete);
        }
    }
}