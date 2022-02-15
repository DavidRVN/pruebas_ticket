#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using pruebas_tickets.Data;
using pruebas_tickets.Models;

namespace pruebas_tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly pruebas_ticketsContext _context;

        public TicketsController(pruebas_ticketsContext context)
        {
            _context = context;
        }

       // GET: api/Tickets
        [HttpGet]
        public ActionResult GetTickets()
        {
            try
            {
                return Ok(_context.Ticket.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTickets(int id)
        {
            var tickets = await _context.Ticket.FindAsync(id);

            if (tickets == null)
            {
                return NotFound();
            }

            return tickets;
        }

        // PUT: api/Tickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTickets(int id, Ticket tickets)
        {
            if (id != tickets.id)
            {
                return BadRequest();
            }

            _context.Entry(tickets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTickets(Ticket tickets)
        {
            _context.Ticket.Add(tickets);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTickets", new { id = tickets.id }, tickets);
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTickets(int id)
        {
            var tickets = await _context.Ticket.FindAsync(id);
            if (tickets == null)
            {
                return NotFound();
            }

            _context.Ticket.Remove(tickets);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        private bool TicketsExists(int id)
        {
            return _context.Ticket.Any(e => e.id == id);
        }

       



    }
}
