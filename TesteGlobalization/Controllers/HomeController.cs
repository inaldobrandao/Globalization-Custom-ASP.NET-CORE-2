using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TesteGlobalization.Models;
using TesteGlobalization.Resources;

namespace TesteGlobalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly LocService _localizer;

        public HomeController(LocService localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["DescricaoGlobalizada"] = _localizer.GetLocalizedHtmlString("descricao");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
