using System.ComponentModel.DataAnnotations;

namespace DemoProducts.Data;

public class CustomerDto
{
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Please enter company name..")]
    public string CompanyName { get; set; } = "";
    [Required(ErrorMessage ="Please enter contact name..")]
    public string ContactName { get; set; } = "";
    [Required(ErrorMessage ="Please enter a phone number..")]
    public string PhoneNumber { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    [Required(ErrorMessage ="Please enter a street address..")]
    public string Street { get; set; } = "";
    [Required(ErrorMessage ="Please enter city..")]
    public string City { get; set; } = "";
    [Required(ErrorMessage ="Please enter state..")]
    public string State { get; set; } = "";
    [Required(ErrorMessage ="Please enter zip code..")]
    public string ZipCode { get; set; } = "";


    public string Notes { get; set; } = "";
}