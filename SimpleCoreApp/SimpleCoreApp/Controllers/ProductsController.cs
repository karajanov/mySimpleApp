using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleCoreApp.Models;
using SimpleCoreApp.Models.DataTransferObjects;
using SimpleCoreApp.Services.Interfaces;

namespace SimpleCoreApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICategoriesRepository categoriesRepository;
        private readonly IMapper mapper;

        public ProductsController(IProductsRepository productsRepository,
            ICategoriesRepository categoriesRepository,
            IMapper mapper)
        {
            this.productsRepository = productsRepository;
            this.categoriesRepository = categoriesRepository;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.ProductsOfCategory = await productsRepository
               .GetProductsByCategoryIdAsync(id);

            ViewBag.CategoryTitle = await categoriesRepository
                .GetTitleByIdAsync(id);

            return View();
        }

        public async Task<IActionResult> Insert(int id)
        {
            if (id != 0)
            {
                var title = await categoriesRepository.GetTitleByIdAsync(id);
                ViewBag.CategoryInfo = new KeyValuePair<int, string>(id, title);

                return View(new ProductViewModel());
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id != 0)
            {
                var product = await productsRepository.GetByIdAsync(id);
                var productViewModel = mapper.Map<UpdateProductViewModel>(product);

                return View(productViewModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> InsertProductPost([FromForm] ProductViewModel m)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var product = mapper.Map<Products>(m);
                    await productsRepository.InsertAsync(product);
                    ViewBag.ProductReport = product;

                    return View("Success");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }

            return RedirectToAction("Insert", "Products", new { id = m.CategoryId });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductPost([FromForm] UpdateProductViewModel m)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var product = mapper.Map<Products>(m);
                    await productsRepository.UpdateAsync(product);

                    ViewBag.UpdateReport = product;

                    return View("Success");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }

            return RedirectToAction("Update", "Products", new { id = m.Id });
        }
    }
}