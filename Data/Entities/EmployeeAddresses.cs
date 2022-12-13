namespace dot7.razor.crudsample.Data.Entities;


public class EmployeeAddresses
{
    public int Id { get; set; }
    public string? AddressType { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; }
}

