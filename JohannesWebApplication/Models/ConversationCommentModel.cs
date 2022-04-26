using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class ConversationCommentModel
{
    [Key]
    public int ConversationCommentId { get; set; }
    
    public int OrderConversationId { get; set; }
    public OrderConversation OrderConversation { get; set; }
    
    public string CommentText { get; set; }
    public DateTime CommentTimestamp { get; set; }
}