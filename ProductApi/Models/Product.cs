using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    
    [Required]
    public int ProducerId{get;set;}

    public Producer?  Producer{get; set;}
}
