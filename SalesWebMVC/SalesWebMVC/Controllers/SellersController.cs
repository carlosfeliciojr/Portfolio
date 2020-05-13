using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Services;
using SalesWebMVC.Services.Exceptions;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        // Criada dependencia para SellerService
        private readonly SellerService _sellerService;

        // Criada dependencia para DepartmentService
        private readonly DepartmentService _departmentService;

        public ICollection<Department> departments { get; private set; }

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            // Retorna uma lista de Seller.
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id);
            if (obj == null)
            {
                return NotFound();
            }

            List<Department> departments = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
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

        [HttpPost]
        // Notação para segurança.
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        // Notação para segurança.
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if (id != seller.Id)
            {
                return BadRequest();
            }

            try
            {
                _sellerService.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}