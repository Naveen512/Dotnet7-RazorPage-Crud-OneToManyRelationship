using dot7.razor.crudsample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dot7.razor.crudsample.Pages.Employee;

public class EmployeeIndex : PageModel
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeIndex(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    public List<dot7.razor.crudsample.Data.Entities.Employee> AllEmployees { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        AllEmployees = await _myWorldDbContext.Employee.ToListAsync();
        return Page();
    }
}