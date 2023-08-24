using BackEnd.Project.DataAccess.Repository;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Project.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IActionResult List()
        {
            //ViewData["Title"] = "All Products";
            //ViewData["Date"] = DateTime.Now;


            var Products = _unitOfWork.Product.GetAll();
            return View(Products);
            //var productListViewModel = new ProductListViewModel();
            //productListViewModel.Products = _unitOfWork.GetAll();
            //return View(productListViewModel);

        }

        public IActionResult RemoveProduct(Product product)
        {
            //var productToBeDeleted = _productRepository.Product.Get(u => u.Id == id);
            //var productListViewModel =
            //     _productRepository.ProductListViewModel.SingleOrDefault(
            //        s => s.Product.Id == product.Id && s.ProductListViewModel == ProductListViewModel);
            //var quantidadeLocal = 0; 

            //if (productListViewModel != null)
            //{
            //    if(productListViewModel.Quantidade > 1)
            //    {
            //        productListViewModel.Quantidade--;
            //        quantidadeLocal = productListViewModel.Quantidade;
            //    }
            //    else
            //    {
            //        _productRepository.ProductListViewModel.Remove(productListViewModel);
            //    }
            //}
            //_productRepository.SaveChanges();
            return View();
        }


    }
}

