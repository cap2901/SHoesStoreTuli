using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Security.Principal;
using CoV.Common.Infrastructure;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    
    
    /// <summary>
    /// Admin Controler 
    /// </summary>
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IProductDetailsService _productDetailsService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IContactService _contactService;

        public AdminController(IProductService productService , ICustomerService customerService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService, IContactService contactService)
        {
            _productService = productService;
            _customerService = customerService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
            _contactService = contactService;
        }
        /// <summary>
        /// show 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return
            View("Index");
        }

        [HttpGet]
        public IActionResult MailBox()
        {
            var contact = _contactService.GetAll();
            List<ContactViewModel> list = new  List<ContactViewModel>();
            foreach (var item in contact)
            {
                list.Add(item);
            }
            ViewBag.contact = contact.AsEnumerable().Reverse();
            return View();
        }
    }
}