using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JohannesWebApplication.Models;

public class OrderModel
{
    [Key]
    public int PrinterID { get; set; }
    
    public float Infill { get; set; }
    
    public string PrintFilePath { get; set; }

    public OrderMaterial Material { get; set; }
    public OrderConversation Conversation { get; set; }
}

public class OrderModelVM
{
    public float Infill { get; set; }
    public IFormFile PrintFile { get; set; }
}