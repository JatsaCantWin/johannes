using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JohannesWebApplication.Models;

public class OrderModel
{
    public OrderModel()
    {
        PotentialExecutioners = new List<ApplicationUser>();
    }
    
    [Key]
    public int OrderId { get; set; }
    
    public string Name { get; set; }
    public float Infill { get; set; }
    
    public string PrintFilePath { get; set; }
    public int SizeX { get; set; }
    public int SizeY { get; set; }
    public int SizeZ { get; set; }
    
    public bool OrderSent { get; set; }
    public bool OrderFinalized { get; set; }
    
    public ApplicationUser Commisioner { get; set; }
    public ApplicationUser? CommisionExecutioner { get; set; }
    public ICollection<ApplicationUser> PotentialExecutioners { get; set; }

    public OrderMaterial Material { get; set; }
}

public class OrderModelVM
{
    public string Name { get; set; }
    public float Infill { get; set; }
    public IFormFile PrintFile { get; set; }
    public int SizeX { get; set; }
    public int SizeY { get; set; }
    public int SizeZ { get; set; }
}