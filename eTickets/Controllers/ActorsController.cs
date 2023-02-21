using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        
        //CONSTRUCTOR
        public ActorsController(AppDbContext context) 
        { 
            _context = context;
        }

        //GET DATA SYNCHRONOUS
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
