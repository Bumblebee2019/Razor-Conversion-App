using CountApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CountApp.Pages
{
    public class ConversionModel : PageModel
    {
        private readonly MyDbContext _context;
        public List<RomanNumber> NumList { get; set; } = new List<RomanNumber>();

        [BindProperty]
        public RomanNumber NewNumber { get; set; }

        public ConversionModel(MyDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            NumList = _context.Numbers.ToList();

        }
        public IActionResult OnPost()
        {
            _context.Numbers.Add(NewNumber);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
