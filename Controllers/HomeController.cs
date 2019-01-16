using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class NameHomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}