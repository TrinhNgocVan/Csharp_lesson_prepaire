

using System.ComponentModel.DataAnnotations;
using ProductApi.Models;

public class Inventory{ // ton kho
    public int Id {get; set;}
    
    // inverntory vs product : 1-1

    [Required]
    public int ProductId {get; set;}
    public int Quantity {get;set;}

    public Product Product {get;set;}


    


}