using HiloEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiloEntityFramework.Controllers;

[ApiController]
[Route("employees")]
public class EmployeeController : ControllerBase
{
    private readonly EFDataContext _context;

    public EmployeeController(EFDataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task AddEmployee(Employee employee)
    {
        var entry = _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
    }
}