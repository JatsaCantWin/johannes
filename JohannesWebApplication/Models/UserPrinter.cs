using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JohannesWebApplication.Models;

public class UserPrinter
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserPrinterId { get; set; }
    
    public int PrinterId { get; set; }
    public PrinterModel Printer { get; set; }
    
    public virtual ApplicationUser ApplicationUser { get; set; }
}