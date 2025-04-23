
using ProductApi.Models;

public class Producer{
    public int Id{get; set;}
    public string Name{get; set;}

    // 1 producer <==> many Product

    public ICollection<Product> Products{get;set;}
    = new List<Product>();

}