namespace DemoProducts.Data;

public class Customer
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = "";
    public string ContactName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    
    public string Street { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";

    public string CustomerNotes { get; set; } = "";
}