using System.ComponentModel.DataAnnotations;

namespace pruebas_tickets.Models
{
    public class Ticket
    {

        [Key]
        public int id { get; set; }
        public string usuario { get; set; }

        public string  fecha_creacion { get; set; }

        public string  fecha_actualizacion { get; set; }

        public string estatus { get; set; }
    }
}
