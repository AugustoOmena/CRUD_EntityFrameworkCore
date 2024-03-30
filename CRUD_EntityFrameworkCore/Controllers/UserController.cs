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

        //List (Method)
        public IActionResult Index()
        {
            var userModeltoView = _context.Users.ToList();
            return View(userModeltoView);
        }

        // Create // Get by Id (Methods)
        [HttpGet]
        public IActionResult AddOrEdit(int Id = 0)
        {
            UserModel userModel = new UserModel();

            if (Id == 0) 
                return View(userModel);
            else
                return View(_context.Users.Find(Id));
        }

        [HttpPost]
        public IActionResult AddOrEdit([Bind("UserId, FirstName, LastName, ContactNo")] UserModel userModelObj)
        {
            if (ModelState.IsValid)
            {
                if(userModelObj.UserId == 0) 
                {
                    _context.Add(userModelObj);
                }

                if (userModelObj.UserId > 0)
                {
                    _context.Update(userModelObj);
                }

                _context.SaveChanges();
                RedirectToAction(nameof(Index));

            }
            return View(userModelObj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = _context.Users.FirstOrDefault(m => m.UserId == id);
            if (pet == null)
            {
                return NotFound(pet);
            }
            return View(pet);
        }
    }
}
