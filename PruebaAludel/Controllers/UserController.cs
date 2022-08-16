using DataService.Service;
using Microsoft.AspNetCore.Mvc;
using PruebaAludel.Models;
using System.Diagnostics;

namespace PruebaAludel.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            UserService userService = new UserService();
            try
            {
                return Ok(userService.getUsers());
            }
            catch (Exception)
            {
                return Error();
            }
        }

        public IActionResult GetById(int id)
        {
            UserService userService = new UserService();
            try
            {
                return Ok(userService.getUserById(id));
            }
            catch (Exception)
            {
                return Error();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
