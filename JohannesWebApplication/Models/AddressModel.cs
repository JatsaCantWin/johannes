using System.ComponentModel.DataAnnotations;

namespace JohannesWebApplication.Models;

public class AdressModel
{
    [Key]
    public int AdressID { get; set; }
    
    public string City { get; set; }
    public string? Street { get; set; }
    public int StreetNumber { get; set; }
    public int? ApartmentNumber { get; set; }
    public string PostalCode { get; set; }

    bool isNearby(AdressModel secondAdress)
    {
        return (this.City == secondAdress.City);
    }
}