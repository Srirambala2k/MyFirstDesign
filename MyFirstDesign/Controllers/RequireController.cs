using Microsoft.AspNetCore.Mvc;
using MyFirstDesign.Data;
using MyFirstDesign.Models;

namespace MyFirstDesign.Controllers
{
    public class RequireController : Controller
    {
        private readonly ApplicationDbContext _db;
        private object requireFromDb;

        public RequireController(ApplicationDbContext db)
        {
            _db = db;
        }

       

        public IActionResult Index()
        {
            IEnumerable<Require> objRequireList = _db.requires;
            return View(objRequireList);    
        }
    }
}
