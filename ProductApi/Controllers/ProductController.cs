using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    //  [HttpGet]
    // public async Task<IActionResult> getAll(){
    //     Task.Delay(10000);
    //     return Ok("test");
    // }

    // [HttpGet]
    // public async Task<IActionResult> getAll(){
    //     await Task.Delay(10000);
    //     return Ok("test");
    // }
    

    // IActionResult : đại diện cho 1 http response
    // [HttpGet]
    // public IActionResult getAll() => Ok(_context.Products.ToList());


    [HttpGet]
    public async Task<IActionResult> GetAll() {
        return Ok(await _context.Products.ToListAsync());
    }

    // [HttpGet]
    // public async Task<IActionResult> GetAll() => Ok(await _context.Products.ToListAsync());

        




    // [HttpGet("{id}")]
    // public async Task<IActionResult> Get(int id)
    // {
    //     var product = await _context.Products.FindAsync(id);
    //     return product == null ? NotFound() : Ok(product);
    // }


    [HttpGet("{id}")]
    public async Task<IActionResult> getById( int id){
        var product =  _context.Products.Find(id);
        return product == null ? NotFound() : Ok(product);
    }

    // [HttpPost]
    // public async Task<IActionResult> Create([FromBody] Product product)
    // {
    //     _context.Products.Add(product);
    //     await _context.SaveChangesAsync();
    //     return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    // }

    // [HttpPut("{id}")]
    // public async Task<IActionResult> Update(int id, [FromBody] Product updated)
    // {
    //     var product = await _context.Products.FindAsync(id);
    //     if (product == null) return NotFound();

    //     product.Name = updated.Name;
    //     product.Price = updated.Price;
    //     await _context.SaveChangesAsync();

    //     return NoContent();
    // }

    // [HttpDelete("{id}")]
    // public async Task<IActionResult> Delete(int id)
    // {
    //     var product = await _context.Products.FindAsync(id);
    //     if (product == null) return NotFound();

    //     _context.Products.Remove(product);
    //     await _context.SaveChangesAsync();

    //     return NoContent();
    // }

    // [HttpGet("search")]
    // public async Task<IActionResult> Search([FromQuery] string keyword)
    // {
    //     var results = await _context.Products
    //         .Where(p => p.Name.Contains(keyword))
    //         .ToListAsync();

    //     return Ok(results);
    // }
}
