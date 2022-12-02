using Aplication.estudos.japagay.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aplication.estudos.japagay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //test
        public IActionResult Index()
        {
            return View();
        }

        //test hugo viado dois 

        //[HttpPost]
        //public IActionResult Cadastrar()
        //{
        //    return View();
        //}

        [HttpPost]
        //public IActionResult Cadastrar(Cadastro ViewModel)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    ViewModel.Nome = "japagay";
        //    return View();
            
        //}


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}