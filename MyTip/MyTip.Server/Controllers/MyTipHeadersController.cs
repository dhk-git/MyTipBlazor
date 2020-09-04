using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTip.Server.DbContexts;
using MyTip.Shared.MyTipModels;

namespace MyTip.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTipHeadersController : ControllerBase
    {
        private readonly MyTipDbContext _context;

        public MyTipHeadersController(MyTipDbContext context)
        {
            _context = context;
        }

        // GET: api/MyTipHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyTipHeader>>> GetMyTipHeaders()
        {
            return await _context.MyTipHeaders.ToListAsync();
        }

        // GET: api/MyTipHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyTipHeader>> GetMyTipHeader(int id)
        {
            var myTipHeader = await _context.MyTipHeaders.FindAsync(id);

            if (myTipHeader == null)
            {
                return NotFound();
            }

            return myTipHeader;
        }

        // PUT: api/MyTipHeaders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyTipHeader(int id, MyTipHeader myTipHeader)
        {
            if (id != myTipHeader.TipHeaderID)
            {
                return BadRequest();
            }

            _context.Entry(myTipHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyTipHeaderExists(id))
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

        // POST: api/MyTipHeaders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MyTipHeader>> PostMyTipHeader(MyTipHeader myTipHeader)
        {
            _context.MyTipHeaders.Add(myTipHeader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyTipHeader", new { id = myTipHeader.TipHeaderID }, myTipHeader);
        }

        // DELETE: api/MyTipHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MyTipHeader>> DeleteMyTipHeader(int id)
        {
            var myTipHeader = await _context.MyTipHeaders.FindAsync(id);
            if (myTipHeader == null)
            {
                return NotFound();
            }

            _context.MyTipHeaders.Remove(myTipHeader);
            await _context.SaveChangesAsync();

            return myTipHeader;
        }

        private bool MyTipHeaderExists(int id)
        {
            return _context.MyTipHeaders.Any(e => e.TipHeaderID == id);
        }
    }
}
