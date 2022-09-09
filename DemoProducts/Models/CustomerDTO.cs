using System.ComponentModel.DataAnnotations;

namespace DemoProducts.Data;

public class CustomerDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = "";
    [Required(ErrorMessage ="Please enter company name..")]
    public string ContactName { get; set; } = "";
    [Required(ErrorMessage ="Please enter contact name..")]
    public string PhoneNumber { get; set; } = "";
    [Required(ErrorMessage ="Please enter a phone number..")]
    public string EmailAddress { get; set; } = "";
    
    public string Street { get; set; } = "";
    [Required(ErrorMessage ="Please enter a street address..")]
    public string City { get; set; } = "";
    [Required(ErrorMessage ="Please enter city..")]
    public string State { get; set; } = "";
    [Required(ErrorMessage ="Please enter state..")]
    public string ZipCode { get; set; } = "";
    [Required(ErrorMessage ="Please enter zip code..")]

    public string Notes { get; set; } = "";
}