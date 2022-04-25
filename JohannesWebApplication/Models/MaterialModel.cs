using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class MaterialModel
{
    [Key]
    public int MaterialID { get; set; }
    
    public string Name { get; set; }
}