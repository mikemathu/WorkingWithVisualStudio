using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
            => View(SimpleRepository.SharedRepository.Products);
        

       
    }
}