using DataService.Service;
using Microsoft.AspNetCore.Mvc;
using PruebaAludel.Models;
using System.Diagnostics;

namespace PruebaAludel.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            PostService postService = new PostService();
            try
            {
                return Ok(postService.getPosts());
            }
            catch (Exception)
            {
                return Error();
            }

        }

        public IActionResult GetById(int id)
        {
            PostService postService = new PostService();
            try
            {
                return Ok(postService.getById(id));
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
