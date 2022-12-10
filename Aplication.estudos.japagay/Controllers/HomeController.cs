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

        
        public  IActionResult Index()
        {
            

            
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(Usuario usuario)
        {


           
            
                var appCadastro = new AppCadastro();
                appCadastro.Inserir(usuario);
                return RedirectToAction("Index");
            


            return View(usuario);

        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        //fdfdf

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