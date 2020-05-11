using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        // Criada dependencia para SellerService
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            // Retorna uma lista de Seller.
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // Notação para segurança.
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            // Insere no banco de dados.
            _sellerService.Insert(seller);

            // Redireciona para o CRUD Sellers.
            return RedirectToAction(nameof(Index));
        }
    }
}