using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class MaterialModel
{
    public MaterialModel()
    {
        //OrderModels = new List<OrderModel>();
        //Printers = new List<PrinterModel>();
    }
    
    [Key]
    public int MaterialID { get; set; }
    
    public string Name { get; set; }

    //public ICollection<OrderModel> OrderModels { get; set; }
    //public ICollection<PrinterModel> Printers { get; set; }
}