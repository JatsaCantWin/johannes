namespace JohannesWebApplication.Models;

public class UserPrinterMaterial
{
    public string UserId;
    
    public int PrinterMaterialId { get; set; }
    public PrinterMaterial PrinterMaterial { get; set; }
}