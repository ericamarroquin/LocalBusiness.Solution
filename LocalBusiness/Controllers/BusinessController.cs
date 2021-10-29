using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using LocalBusiness.Models;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessController : ControllerBase
  {
    private readonly LocalBusinessContext _db;
    public BusinessController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string name, string businestype, string phone)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (businestype != null)
      {
        query = query.Where(entry => entry.BusinessType == businestype);
      }

      if (phone != null)
      {
        query = query.Where(entry => entry.Phone == phone);
      }
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      return business;
    }
    
    [HttpPut]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(business => business.BusinessId == id);
    }
  }
}