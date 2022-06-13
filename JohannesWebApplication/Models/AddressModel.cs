using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class AddressModel
{
    [Key]
    public int AdressID { get; set; }
    
    public string City { get; set; }
    public string? Street { get; set; }
    public int StreetNumber { get; set; }
    public int? ApartmentNumber { get; set; }
    public string PostalCode { get; set; }

    public string ApplicationUserForeignKey { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    bool isNearby(AddressModel secondAddress)
    {
        return (this.City == secondAddress.City);
    }
}