using Example.Data;
using Example.Models;
using Example.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Example.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContactController(AppDbContext context)
    {
        _context = context;
    }

    // GET
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        return Ok(await _context.Contacts.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ContactCreateDto dto)
    {
        _context.Contacts.Add(new Contact()
        {
            Email = dto.Email,
            Country = dto.Country,
            FullName = dto.FullName,
            NumberPhone = dto.NumberPhone
        });
        await _context.SaveChangesAsync();
        return Ok(dto);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Update([FromBody] ContactUpdateDto dto, [FromRoute] string id)
    {
        var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
        if (contact == null) return BadRequest();
        
        contact.Email = dto.Email ?? contact.Email;
        contact.Country = dto.Country ?? contact.Country;
        contact.FullName = dto.FullName ?? contact.FullName;
        contact.NumberPhone = dto.NumberPhone ?? contact.NumberPhone;
        _context.Contacts.Update(contact);
        await _context.SaveChangesAsync();
        return Ok(dto);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id)
    {
        var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
        if (contact == null) return BadRequest();

        contact.IsDeleted = true;
        _context.Contacts.Update(contact);
        await _context.SaveChangesAsync();
        
        return NoContent();
    }
}