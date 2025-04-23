

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi.Data;

[ApiController]
[Route("api/producer")]
public class ProducerController : ControllerBase{
     private readonly AppDbContext _context;

    public ProducerController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        return Ok(await _context
        .Producers
        .ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> getById( int id){
        var producer =  _context.Producers.Find(id);
        return producer == null ? NotFound() : Ok(producer);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Producer producer)
    {
        _context.Producers.Add(producer);
        await _context.SaveChangesAsync();
        return Ok("Create producer success");
    }

    // todo : api lay product by  producer
    




}