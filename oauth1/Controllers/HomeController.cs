using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using oauth1.Models;
using System.Security.Claims;

namespace oauth1.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            //var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
