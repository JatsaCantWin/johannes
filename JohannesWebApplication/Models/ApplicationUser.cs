using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JohannesWebApplication.Models;

public class ApplicationUser : IdentityUser
{
    public virtual ICollection<UserPrinter> UserPrinters { get; set; }
}