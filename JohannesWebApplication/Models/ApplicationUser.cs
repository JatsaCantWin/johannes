using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JohannesWebApplication.Models;

public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        PrinterModel = new List<PrinterModel>();
    }
    
    public ICollection<PrinterModel> PrinterModel { get; set; }
}