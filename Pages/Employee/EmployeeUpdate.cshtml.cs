using dot7.razor.crudsample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dot7.razor.crudsample.Pages.Employee;

public class EmployeeUpdate : PageModel
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeUpdate(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }
    [BindProperty]
    public dot7.razor.crudsample.Data.Entities.Employee EmployeeToUpdate { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        EmployeeToUpdate = await _myWorldDbContext.Employee.Include(_ => _.EmployeeAddresses)
        .Where(_ => _.Id == id).FirstOrDefaultAsync();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        _myWorldDbContext.Employee.Update(EmployeeToUpdate);
        await _myWorldDbContext.SaveChangesAsync();
        return Redirect("index");
    }
}