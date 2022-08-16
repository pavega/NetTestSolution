using DataService.Service;
using Microsoft.AspNetCore.Mvc;
using PruebaAludel.Models;
using System.Diagnostics;

namespace PruebaAludel.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            CommentService commentService = new CommentService();
            try
            {
                return Ok(commentService.getComments());
            }
            catch (Exception)
            {
                return Error();
            }

        }

        public IActionResult GetById(int id)
        {
            CommentService commentService = new CommentService();
            try
            {
                return Ok(commentService.getById(id));
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
