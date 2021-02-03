using System;
using System.Collections.Generic;
using System.Linq;
using CoV.Common.Infrastructure;
using CoV.Common.Resources;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDesciptionService _productDesciptionService;

        public ProductController(IProductService productService, IProductDesciptionService productDesciptionService)
        {
            _productService = productService;
            _productDesciptionService = productDesciptionService;
        }

        /// <summary>
        /// Get All Product 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Policy = Constants.RolePolice.Accountant)]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return
                View(products);
        }

        /// <summary>
        ///  action get request Create Or Update 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Policy = Constants.RolePolice.Employee)]
        public IActionResult CreateOrUpdate(int id)
        {
            var model = _productService.GetById(id);
            return View(model);
        }

        /// <summary>
        /// action get reponse Create Or Update 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = Constants.RolePolice.Employee)]
        public IActionResult CreateOrUpdate(ProductViewModel model)
        {
            if (model.Id <= 0)
            {
                if (ModelState.IsValid)
                {
                    var product = _productService.GetAll().FirstOrDefault(x => x.Sku.Equals(model.Sku));
                    if (product != null)
                    {
                        ModelState.AddModelError(String.Empty, MessageResource.skuProductKey);
                        var productss = _productService.GetById(model.Id);
                        return View(productss);
                    }
                    else
                    {
                        _productService.CreateOrUpdate(model);
                        var productViewModel = _productService.GetAll().FirstOrDefault(x => x.Sku.Equals(model.Sku));
                        if (productViewModel != null)
                        {
                            ProductDesciptionViewModel desciptionViewModel = new ProductDesciptionViewModel();
                            desciptionViewModel.Id = 0;
                            desciptionViewModel.ProductId = productViewModel.Id;
                            desciptionViewModel.Description = model.Name;
                            _productDesciptionService.CreateOrUpdate(desciptionViewModel);
                        }
                        return RedirectToAction("GetAll");
                    }
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var productId = _productService.GetByProductId(model.Id);
                    if (productId.Sku == model.Sku )
                    {
                        _productService.CreateOrUpdate(model);
                        return RedirectToAction("GetAll");
                    }
                    else
                    {
                        var product = _productService.GetByIdSku(model.Sku);
                        if (product != null)
                        {
                            ModelState.AddModelError(String.Empty, MessageResource.skuProductKey);
                            var productss = _productService.GetById(model.Id);
                            return View(productss);
                        }
                        else
                        {
                            _productService.CreateOrUpdate(model);
                            return RedirectToAction("GetAll");
                        }
                    }
                    
                }
            }
            var products = _productService.GetById(model.Id);
            return View(products);
        }

        /// <summary>
        /// Delete Product 
        /// </summary>
        /// <param name="id"></param>
        [Authorize(Policy = Constants.RolePolice.Employee)]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("GetAll");
        }

        /// <summary>
        /// get add product Male
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllMale()
        {
            var product = _productService.GetAll().Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Male))
                .ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// get add product Famale
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllFemale()
        {
            var product = _productService.GetAll()
                .Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Female)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// get add product Baby
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllBaby()
        {
            var product = _productService.GetAll().Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Baby))
                .ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }


        /// <summary>
        /// get add product sporst
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoeSporst()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.Giaythethao)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }


        /// <summary>
        /// get add product Cs
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesCs()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.ShoesCs)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// get add product long
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoeLong()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.ShoesLong)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// get add product cs
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesDa()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDa)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }


        /// <summary>
        /// get add product baby dang yeu
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesBabyLovely()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDangYeu)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }


        /// <summary>
        /// get add product baby phong cách
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllShoesBabyStyle()
        {
            var product = _productService.GetAll()
                .Where(x => x.CategoryProduct.CategoryName.Equals(Constants.CategoryProduct.GiayDangYeu)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// get add product baby phong cách
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Search(string input)
        {
            var product = _productService.GetAll().Where(c => c.Name.Contains(input)).ToList();
            List<ProductViewModel> productmodel = new List<ProductViewModel>();
            foreach (var item in product)
            {
                if (productmodel.Count >= 8)
                {
                    break;
                }

                productmodel.Add(item);
            }

            ViewBag.product = productmodel;
            return View(productmodel);
        }

        /// <summary>
        /// Description product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Policy = Constants.RolePolice.Employee)]
        public IActionResult Description(int id)
        {
            ProductDesciptionViewModel description = new ProductDesciptionViewModel();
            var item = _productDesciptionService.GetbyIdProduct(id);
            if (item == null)
            {
                return View(description);
            }

            return View(item);
        }

        /// <summary>
        /// create and update description
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = Constants.RolePolice.Employee)]
        public IActionResult Description(ProductDesciptionViewModel model)
        {
            ProductDesciptionViewModel description = new ProductDesciptionViewModel();
            var item = _productDesciptionService.GetbyIdProduct(model.Id);
            if (item == null)
            {
                description.Id = 0;
                description.ProductId = model.Id;
                description.Description = model.Description;
                _productDesciptionService.CreateOrUpdate(description);
            }
            else
            {
                description.Id = item.Id;
                description.ProductId = model.Id;
                description.Description = model.Description;
                _productDesciptionService.CreateOrUpdate(description);
            }

            return Redirect("/Product/GetAll");
        }
    }
}