using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InterXModelingSystem.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InterXModelingSystem.Controllers
{
    public class Dashboard : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            TestContext context = HttpContext.RequestServices.GetService(typeof(TestContext)) as TestContext;
            context.GetData();
            return View();
        }
    }
}
