using CoreDICrud.Models;
using CoreDICrud.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreDICrud.Controllers
{
    public class HomeController : Controller
    {
        public readonly IUserRepository _context;

        public HomeController(IUserRepository coreDiContext)
        {
            _context = coreDiContext;
        }

        public async Task<IActionResult> Index()
        {
            var userdata= _context.getAllUsers();
            return View(userdata);
        }








        //king

        //don
    }
}
