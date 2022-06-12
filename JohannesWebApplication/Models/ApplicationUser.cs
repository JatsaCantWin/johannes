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
        CommissionsPut = new List<OrderModel>();
        CommissionsTaken = new List<OrderModel>();
        PotentialCommisions = new List<OrderModel>();
    }
    
    public ICollection<PrinterModel> PrinterModel { get; set; }
    public ICollection<OrderModel> CommissionsPut { get; set; }
    public ICollection<OrderModel> CommissionsTaken { get; set; }
    public ICollection<OrderModel> PotentialCommisions { get; set; }
}