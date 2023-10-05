using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure.Components
{
    public class CategoriesViewModel : ViewComponent
    {
        private readonly DataContext _context;
        public CategoriesViewModel(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());
    }
}
