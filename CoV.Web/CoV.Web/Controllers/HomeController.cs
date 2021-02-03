using System;
using System.Collections;
using System.Collections.Generic;
using CoV.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CoV.Service.DataModel;

namespace CoV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IProductDetailsService _productDetailsService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IContactService _contactService;
        private readonly IProductDesciptionService _productDesciptionService;
        private readonly IOrderService _orderService;

        public HomeController(IProductService productService , ICustomerService customerService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService, IContactService contactService, IProductDesciptionService desciptionService, IProductDesciptionService productDesciptionService, IOrderService orderService)
        {
            _productService = productService;
            _customerService = customerService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
            _contactService = contactService;
            _productDesciptionService = productDesciptionService;
            _orderService = orderService;
        }
        
        
        [HttpGet]
        public IActionResult Home()
        {
            ViewBag.getLishFamale = _productService.GetListShoesFemale();
            ViewBag.getLishMale = _productService.GetListShoesMale();
            ViewBag.getLishBaby = _productService.GetListShoesBaby();
            ViewBag.getLishSporst= _productService.GetListShoesSporst();
            ViewBag.Name = HttpContext.Session.GetString("SessionName");  
            ViewBag.Email = HttpContext.Session.GetString("SessionEmail");  
            return View();
        }
        
        public IActionResult Singin()
        {
            return View();
        }
        
        public IActionResult TemplateInvoid(int id)
        {
            var list2 = _orderDetailsService.GetByIdDetails(id).ToList();
            foreach (var item in list2)
            {
                item.Product = _productService.GetById(item.ProductId);
            }
            ViewBag.list = list2;
            var orderdetails = _orderDetailsService.GetAll().FirstOrDefault(x=>x.Id.Equals(id));
            ViewBag.orderdetails = orderdetails;
            var customer = _customerService.GetAll()
                .FirstOrDefault(x => x.PhoneNumber.Equals(orderdetails.PhoneNumber));
            if (customer != null) ViewBag.gmail = customer.Email;
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Blog()
        {
            return View();
        }
        
        public IActionResult BlogDetail()
        {
            return View();
        }
        
        /// <summary>
        /// Checkout Customer 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Checkout01()
        {
            var id = Int32.Parse(HttpContext.Session.GetString("SessionId"));
            var customer = _customerService.GetById(id);
            return View(customer);
        }
        
        [HttpGet]
        public IActionResult Contact()
        {
            var id = Int32.Parse(HttpContext.Session.GetString("SessionId"));
            var customer = _customerService.GetById(id);
            ViewBag.customer = customer;
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            var id = Int32.Parse(HttpContext.Session.GetString("SessionId"));
            model.CustomerId = id;
            model.CreaDateTime = DateTime.Now;
            _contactService.CreateOrUpdate(model);
            return Redirect("/home/home");
        }
        
        public IActionResult Product()
        {
            return View();
        }
        
        /// <summary>
        ///  show product details 
        /// </summary>
        /// <returns>view</returns>
        [HttpGet]
        public IActionResult ProductDetail(int id )
        {
           var product = _productService.GetById(id);
            ViewBag.product = product;
            ViewBag.productDetail = _productDetailsService.GetByIdCart(product.Id);
            var pro =_productService.GetAll().Where(x=>x.GenderProductId.Equals(product.GenderProductId));
            List<ProductViewModel> list = new List<ProductViewModel>();
            foreach (var item in pro)
            {
                if(list.Count >=9){break;}
                else
                {
                    list.Add(item);

                }
            }
            
            ViewBag.model = list;
            var description = _productDesciptionService.GetbyIdProduct(id);
            if (description == null)
            {
                ViewBag.desription = "Tuli Store";
            }
            else
            {
                ViewBag.desription = description.Description;
            }

            var order = _orderService.GetAll();
            List<ProductViewModel> listproduct = new List<ProductViewModel>();
            foreach (var model in order)
            {
                int x = 0;
                model.Product = _productService.GetById(model.ProductId);
                foreach (var item in listproduct)
                {
                    if (item.Id == model.ProductId) x = 1;
                }

                if (x == 0)
                {
                    listproduct.Add(model.Product);
                }
            }
            ViewBag.order = listproduct ;
            return View( );
        }
    }
}