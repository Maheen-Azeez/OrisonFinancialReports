using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Shared.Models;


namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniqueAccountsController : ControllerBase
    {
        private IWebHostEnvironment _environment;

        public UniqueAccountsController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // GET: api/UniqueAccounts
        [HttpGet]
        public async Task<int> GetUniqueAccounts(string acckeyword)
        {
            UniqueAccount UNAcc;
            UNAcc = _context.UniqueAccounts.FirstOrDefault(a => a.Keyword == acckeyword);
            if (UNAcc == null)
            {
                return 0;
            }
            return (int)UNAcc.AccId;
        }
        //public async Task<ActionResult<IEnumerable<UniqueAccount>>> GetUniqueAccounts()
        //{
        //    return await _context.UniqueAccounts.ToListAsync();
        //}

        // GET: api/UniqueAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UniqueAccount>> GetUniqueAccount(string id)
        {
            var uniqueAccount = await _context.UniqueAccounts.FindAsync(id);

            if (uniqueAccount == null)
            {
                return NotFound();
            }

            return uniqueAccount;
        }

        // PUT: api/UniqueAccounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniqueAccount(string id, UniqueAccount uniqueAccount)
        {
            if (id != uniqueAccount.Keyword)
            {
                return BadRequest();
            }

            _context.Entry(uniqueAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniqueAccountExists(id))
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

        // POST: api/UniqueAccounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UniqueAccount>> PostUniqueAccount(UniqueAccount uniqueAccount)
        {
            _context.UniqueAccounts.Add(uniqueAccount);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UniqueAccountExists(uniqueAccount.Keyword))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUniqueAccount", new { id = uniqueAccount.Keyword }, uniqueAccount);
        }

        // DELETE: api/UniqueAccounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UniqueAccount>> DeleteUniqueAccount(string id)
        {
            var uniqueAccount = await _context.UniqueAccounts.FindAsync(id);
            if (uniqueAccount == null)
            {
                return NotFound();
            }

            _context.UniqueAccounts.Remove(uniqueAccount);
            await _context.SaveChangesAsync();

            return uniqueAccount;
        }

        private bool UniqueAccountExists(string id)
        {
            return _context.UniqueAccounts.Any(e => e.Keyword == id);
        }
    }
}
