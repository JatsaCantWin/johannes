using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class PrinterModel
{
    [Key]
    public int PrinterID { get; set; }
    
    public string Name { get; set; }
    public int SizeX { get; set; }
    public int SizeY { get; set; }
    public int SizeZ { get; set; }
    public string? Description { get; set; }
    
    public PrinterMaterial? Material { get; set; }
}