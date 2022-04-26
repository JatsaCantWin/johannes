namespace JohannesWebApplication.Models;

public class UserPrinter
{
    public string UserId;
    
    public int PrinterId { get; set; }
    public PrinterModel Printer { get; set; }
}