using Expense_Tracker.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Expense_Tracker.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;
    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return _context.CategorySet != null ?
            View(await _context.CategorySet.ToListAsync()) :
            Problem("Пустой значение CategorySet");
    }
}

