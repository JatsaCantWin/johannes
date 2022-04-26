using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class OrderConversation
{
    [Key]
    public int OrderConversationId { get; set; }
    
    public int OrderId { get; set; }
    public OrderModel Order { get; set; }
    
    public ICollection<ConversationCommentModel> Comments { get; set; }
}