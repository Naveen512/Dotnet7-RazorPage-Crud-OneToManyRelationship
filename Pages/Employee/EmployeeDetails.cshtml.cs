using dot7.razor.crudsample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dot7.razor.crudsample.Pages.Employee;

public class EmployeeDetails : PageModel
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeDetails(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    public dot7.razor.crudsample.Data.Entities.Employee Employee { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
        Employee = await _myWorldDbContext.Employee.Include(_ => _.EmployeeAddresses)
        .Where(_ => _.Id == id).FirstOrDefaultAsync();
        return Page();
    }
}