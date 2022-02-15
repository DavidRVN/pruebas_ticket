namespace pruebas_tickets.Models
{
    public class Paginacion
    {
        int maxPagina = 5;
        public int numPagina { get; set; } =  1;
        public int _tPage { get; set; } = 4;

        public int _page {  
            get { return _tPage; }

            set { _tPage = (value > maxPagina) ? maxPagina : value; }
        }
    }
}
