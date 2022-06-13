using JohannesWebApplication.Data;
using JohannesWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JohannesWebApplication.Controllers;

public class AddressController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AddressController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        var applicationUser = await _userManager.GetUserAsync(HttpContext.User);
        var applicationUserDb = await _context.ApplicationUsers
            .Include("Address")
            .FirstOrDefaultAsync(u => u.Id == applicationUser.Id);
        var userAddress = applicationUserDb.Address;
        if (userAddress == null)
            userAddress = new AddressModel();

        return View(userAddress);
    }

    // POST: OrderModels/Index
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index([Bind("AdressID,City,Street,StreetNumber,ApartmentNumber,PostalCode")] AddressModel addressModel)
    {
        var applicationUser = await _userManager.GetUserAsync(HttpContext.User);
        var applicationUserDb = await _context.ApplicationUsers
            .Include("Address")
            .FirstOrDefaultAsync(u => u.Id == applicationUser.Id);
        
        applicationUserDb.Address = addressModel;
        await _context.SaveChangesAsync();
        
        return View(addressModel);
    }
}