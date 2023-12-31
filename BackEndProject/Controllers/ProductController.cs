﻿using BackEnd.Project.DataAccess.Repository.IRepository;
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


        public IActionResult ListProduct()
        {
            ViewData["Title"] = "All Products";

            var Products = _unitOfWork.Product.GetAll();
            return View(Products);

        }

        [HttpGet]
        public ActionResult UniqueProduct(int id)
        {
            var UniqueProduct = _unitOfWork.Product.FindById(id);
            return View(UniqueProduct);
        }

        public IActionResult RemoveProduct(Product product)
        {

            var productToBeDeleted = _unitOfWork.Product.FindById(product.Id);

            _unitOfWork.Product.Remove(productToBeDeleted);
            _unitOfWork.Save();

            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _unitOfWork.Product.Add(product);
            _unitOfWork.Save();
            return View();
        }

        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product updatedProduct)
        {
            Product existingProduct = _unitOfWork.Product.FindById(updatedProduct.Id);

            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Quantity = updatedProduct.Quantity;

            }
            _unitOfWork.Save();
            return View(existingProduct);
        }

    }
}

