using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pruebas_tickets.Data;
using pruebas_tickets.Models;
using System.Net;

namespace pruebas_tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginacionController : ControllerBase
    {

        private readonly pruebas_ticketsContext _context;

        public PaginacionController(pruebas_ticketsContext context)
        {
            _context = context;
        }

        
        [HttpGet]

        public IEnumerable<Ticket> GetTickets([System.Web.Http.FromUri] Paginacion paginacion)
        {
            var tickets = (from ticket in _context.Ticket.OrderBy(t => t.id) select ticket).AsQueryable();

            int cont = tickets.Count();
            int currentPage = paginacion.numPagina;
            int pageSize = paginacion._tPage;
            int totalPages = (int)Math.Ceiling(currentPage / (double)pageSize);
            var items = tickets.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            int TotalCount = cont;
            var previousPage = currentPage > 1 ? "Si" : "No";


            var nextPage = currentPage < totalPages ? "Si" : "No";

            var paginationMetadata = new
            {
                totalCount = TotalCount,
                pageSize = pageSize,
                currentPage = currentPage,
                totalPages = totalPages,
                previousPage,
                nextPage
            };

            return items;
        }
    }
}
