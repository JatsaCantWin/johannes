using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class OrderMaterial
{
    [Key]
    public int OrderMaterialId { get; set; }
    
    public int OrderId { get; set; }
    public OrderModel Order { get; set; }
    public int MaterialId { get; set; }
    public MaterialModel Material { get; set; }
}