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
            ViewData["Title"] = "All Products";

            var Products = _unitOfWork.Product.GetAll();
            return View(Products);
            
        }

        public IActionResult RemoveProduct(Product product)
        {

            var productToBeDeleted = _unitOfWork.Product.FindById(product.Id);


            //if (productToBeDeleted != null)
            //{
            //    if (productToBeDeleted.Products.Count > 1)
            //    {
            //        productToBeDeleted.Quantity--;                 
            //    }
            //    else
            //    {
            //        _unitOfWork.Product.Remove(productToBeDeleted);
            //    }
            //}
            _unitOfWork.Product.Remove(productToBeDeleted);
            _unitOfWork.Save();
            
            return View();
        }

        public IActionResult CreateProducts(Product product)
        {
            Product productToBeCreated = new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.Quantity,
                InStock = product.InStock,
            };
            _unitOfWork.Save();
            return View(productToBeCreated);

        }

    }
}

