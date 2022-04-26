using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace JohannesWebApplication.Models;

public class ApplicationUser : IdentityUser
{
    [ForeignKey("UserId")]
    public virtual ICollection<UserPrinter> UserPrinters { get; set; }
    
    [ForeignKey("UserId")]
    public virtual ICollection<UserPrinterMaterial> UserPrinterMaterials { get; set; }
}