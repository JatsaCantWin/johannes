using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class PrinterMaterial
{
    [Key]
    public int PrinterMaterialID { get; set; }
    
    public int PrinterId { get; set; }
    public PrinterModel Printer { get; set; }
    public int MaterialId { get; set; }
    public MaterialModel Material { get; set; }
}