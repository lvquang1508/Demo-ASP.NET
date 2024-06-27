using Microsoft.AspNetCore.Mvc;
using ReponsitoryMVC.DAL;
using ReponsitoryMVC.Models;
using System.Diagnostics;

namespace ReponsitoryMVC.Controllers
{
    public class HomeController : Controller
    {

        private IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IActionResult Product()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
