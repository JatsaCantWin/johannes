using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class OrderModel
{
    [Key]
    public int PrinterID { get; set; }
    
    public float Infill { get; set; }
    public string FilePath { get; set; }
    
    public OrderMaterial Material { get; set; }
    public OrderConversation Conversation { get; set; }
}