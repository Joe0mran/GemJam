using GemJam.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GemJam.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _context;
        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View("index", categories);
        }
    }
}
