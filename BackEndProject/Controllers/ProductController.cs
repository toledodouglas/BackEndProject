using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Project.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository produtoRepository)
        {
            _productRepository = produtoRepository;

        }

        public IActionResult List()
        {
            var Products = _productRepository.GetAll();
            return View(Products);
        }

    }
}

