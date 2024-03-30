using CRUD_EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_EntityFrameworkCore.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;
        public UserController(UserDbContext userDbContext) 
        {
            _context = userDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
