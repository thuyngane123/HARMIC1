using HARMIC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HARMIC.Controllers.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        public readonly HarmicContext _context;

        public BlogViewComponent(HarmicContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Where(m => (bool)m.IsActive).ToList();

            return await Task.FromResult<IViewComponentResult>(View(items));
        }


    }
}
