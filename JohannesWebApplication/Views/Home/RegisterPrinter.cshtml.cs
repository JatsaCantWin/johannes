using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JohannesWebApplication.Views.Home;

public class RegisterPrinter : PageModel
{
    public PrinterInputModel PrinterInput { get; set; }
    public class PrinterInputModel
    {
        public string Name { get; set; }
    }
    
    public void OnGet()
    {
        
    }
}