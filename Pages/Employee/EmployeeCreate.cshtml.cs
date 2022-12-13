using dot7.razor.crudsample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dot7.razor.crudsample.Pages.Employee;

public class EmployeeCreate : PageModel
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeCreate(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }
    [BindProperty]
    public dot7.razor.crudsample.Data.Entities.Employee NewEmployee { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        _myWorldDbContext.Employee.Add(NewEmployee);
        await _myWorldDbContext.SaveChangesAsync();
        return Redirect("index");
    }
}