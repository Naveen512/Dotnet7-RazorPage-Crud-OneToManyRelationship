namespace dot7.razor.crudsample.Data.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? JobRole { get; set; }
    public List<EmployeeAddresses> EmployeeAddresses { get; set; }
}