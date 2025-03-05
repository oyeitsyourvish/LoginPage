using LoginPage.Data;
using LoginPage.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LoginPage.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
