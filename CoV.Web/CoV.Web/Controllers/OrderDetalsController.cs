using System.Collections.Generic;
using System.Linq;
using CoV.Common.Infrastructure;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class OrderDetalsController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;
        private readonly IOrderDetailsService  _orderDetailsService;

        public OrderDetalsController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
        }
        // GET
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Index()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId ==1 || c.StatusId == 5).ToList();
            return 
            View(orderdetails);
        }
        
        /// <summary>
        /// Giao thanh công
        /// </summary>
        /// <returns></returns>
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Ferfect()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 3 ).ToList();
            return 
                View(orderdetails);
        }
        
        /// <summary>
        /// Dang giao
        /// </summary>
        /// <returns></returns>
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Loading()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 4 ).ToList();
            return 
                View(orderdetails);
        }
        
        /// <summary>
        /// hoan hang
        /// </summary>
        /// <returns></returns>
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Return()
        {
            var orderdetails = _orderDetailsService.GetAll().Where(c=>c.StatusId == 2 ).ToList();
            return 
                View(orderdetails);
        }
        
        /// <summary>
        /// Delete Product 
        /// </summary>
        /// <param name="id"></param>
        [Authorize (Policy = Constants.RolePolice.Employee)]
        public IActionResult Delete(int id)
        {
            _orderDetailsService.Delete(id);
            return Redirect("/OrderDetals/Return");
        }
        
        /// <summary>
        /// update Status nhan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UpdateStatus(int id)
        {
            var order = _orderDetailsService.UpdateToShiper(id);
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// ship nhan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShiperNhap(int id)
        {
            var name = HttpContext.User.Identity.Name;
            var order = _orderDetailsService.UpdateShipNhan(id,name); 
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// Giao hoan thanh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ShipPerfect(int id)
        {
            var order = _orderDetailsService.ShipPerfect(id); 
            return  new JsonResult(order);
        }
        
        /// <summary>
        /// hoan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Comback(int id)
        {
            _orderDetailsService.Comback(id); 
            return  Redirect("/Shiper/DangGiao");
        }

        /// <summary>
        /// Delete OrderDetails
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DeleteOrder(int id)
        {
            _orderDetailsService.Delete(id); 
            return  Redirect("/OrderDetals/index");
        }
        
        /// <summary>
        ///  hien thi danh sach don hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowDetails(int id)
        {
            var list2 = _orderDetailsService.GetByIdDetails(id).ToList();
            foreach (var item in list2)
            {
                item.Product = _productService.GetById(item.ProductId);
            }
            ViewBag.list = list2;
            return View();
        }
        
        /// <summary>
        /// Delete OrderDetails
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult SendTo(int id)
        {
            _orderDetailsService.SendTo(id); 
            return  Redirect("/OrderDetals/index");
        }
        
        /// <summary>
        /// trang thai don hang cua khach hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult CartCustomer(int id)
        {
            var sessionPhone = HttpContext.Session.GetString("SessionPhone");
            var orderDetails = _orderDetailsService.GetAll().Where(x => x.PhoneNumber.Equals(sessionPhone) && x.StatusId != 2 &&  x.StatusId !=3); // danh sach don hang cua khach hang
            foreach (var orderDetail in orderDetails)
            {
                var list2 = _orderDetailsService.GetByIdDetails(orderDetail.Id).ToList();
                orderDetail.OrderViewModels = list2;
                foreach (var item in list2)
                {
                    item.Product = _productService.GetById(item.ProductId);
                }
            }
          
            ViewBag.list = orderDetails;
            return View();
        }
    }
}