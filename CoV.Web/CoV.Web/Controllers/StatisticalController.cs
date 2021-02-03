using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CoV.Common.Infrastructure;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoV.Web.Controllers
{
    public class StatisticalController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailsService _orderDetailsService;
        private readonly IProductService _productService;
        private readonly IProductDetailsService  _productDetailsService;

        public StatisticalController(IOrderService orderService, IProductService productService,IOrderStatusService orderStatusService, IProductDetailsService productDetailsService, IOrderDetailsService orderDetailsService)
        {
            _orderService = orderService;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _orderDetailsService = orderDetailsService;
        }
        /// <summary>
        ///  get bieu do doanh thu
        /// </summary>
        /// <returns></returns>
        [Authorize (Policy = Constants.RolePolice.Accountant)]
        public IActionResult Index()
        {
            var order = _orderDetailsService.GetAll().Where(x => x.StatusId == 3 );
            ViewBag.orderCount = order.Count();
            List<OrderDetailsViewModel> model = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                model.Add(item);
            }
            //so san pham 
            var numberProduct = 0;
            //so tiem
            var totalMoney = 0;
            foreach (var item in model)
            {
                numberProduct += item.NumberProduct;
                totalMoney += item.TotalMoney;
                
            }
            ViewBag.numberProduct = numberProduct;
            ViewBag.TotalMoney = totalMoney;
            //phi ship
            ViewBag.salary = order.Count() * 30000;
            
            
            //January
            List<OrderDetailsViewModel> january = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 1, 1);
                DateTime date2 = new DateTime(2020, 1, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    january.Add(item);
                } 
            }

            var numberProductM1 = 0;
            var totalMoneyM1 = 0;
            foreach (var item in january)
            {
                numberProductM1 += item.NumberProduct;
                totalMoneyM1 += item.TotalMoney;
            }
            ViewBag.january = numberProductM1; // so san pham
            ViewBag.januaryTotal = totalMoneyM1; // doanh thu thang 1
            
            //February
            List<OrderDetailsViewModel> february = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 2, 1);
                DateTime date2 = new DateTime(2020, 2, 29);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    february.Add(item);
                } 
            }

            var numberProductM2 = 0;
            var totalMoneyM2 = 0;
            foreach (var item in february)
            {
                numberProductM2 += item.NumberProduct;
                totalMoneyM2 += item.TotalMoney;
            }
            ViewBag.february = numberProductM2;
            ViewBag.februaryTotal = totalMoneyM2;
            
            //March
            List<OrderDetailsViewModel> march = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 3, 1);
                DateTime date2 = new DateTime(2020, 3, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    march.Add(item);
                } 
            }

            var numberProductM3 = 0;
            var totalMoneyM3 = 0;
            foreach (var item in march)
            {
                numberProductM3 += item.NumberProduct;
                totalMoneyM3 += item.TotalMoney;
            }
            ViewBag.march = numberProductM3;
            ViewBag.marchTotal = totalMoneyM3;
            
            
            //April
            List<OrderDetailsViewModel> april = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 4, 1);
                DateTime date2 = new DateTime(2020, 4, 30);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    april.Add(item);
                } 
            }

            var numberProductM4 = 0;
            var totalMoneyM4 = 0;
            foreach (var item in april)
            {
                numberProductM4 += item.NumberProduct;
                totalMoneyM4 += item.TotalMoney;
            }
            ViewBag.april = numberProductM4;
            ViewBag.aprilTotal = totalMoneyM4;
            
            //May
            List<OrderDetailsViewModel> may = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 5, 1);
                DateTime date2 = new DateTime(2020, 5, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    may.Add(item);
                } 
            }

            var numberProductM5 = 0;
            var totalMoneyM5 = 0;
            foreach (var item in may)
            {
                numberProductM5 += item.NumberProduct;
                totalMoneyM5 += item.TotalMoney;
            }
            ViewBag.may = numberProductM5;
            ViewBag.mayTotal = totalMoneyM5;
            
            //June
            List<OrderDetailsViewModel> june = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 6, 1);
                DateTime date2 = new DateTime(2020, 6, 30);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    june.Add(item);
                } 
            }

            var numberProductM6 = 0;
            var totalMoneyM6 = 0;
            foreach (var item in june)
            {
                numberProductM6 += item.NumberProduct;
                totalMoneyM6 += item.TotalMoney;
            }
            ViewBag.June = numberProductM6;
            ViewBag.JuneTotal = totalMoneyM6;
            
            //July
            List<OrderDetailsViewModel> july = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 7, 1);
                DateTime date2 = new DateTime(2020, 7, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    july.Add(item);
                } 
            }

            var numberProductM7 = 0;
            var totalMoneyM7 = 0;
            foreach (var item in july)
            {
                numberProductM7 += item.NumberProduct;
                totalMoneyM7 += item.TotalMoney;
            }
            ViewBag.July = numberProductM7;
            ViewBag.JulyTotal = totalMoneyM7;
            
            //August
            List<OrderDetailsViewModel> august = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 8, 1);
                DateTime date2 = new DateTime(2020, 8, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    august.Add(item);
                } 
            }

            var numberProductM8 = 0;
            var totalMoneyM8 = 0;
            foreach (var item in august)
            {
                numberProductM8 += item.NumberProduct;
                totalMoneyM8 += item.TotalMoney;
            }
            ViewBag.august = numberProductM8;
            ViewBag.augustTotal = totalMoneyM8;
            
            //September
            List<OrderDetailsViewModel> september = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 9, 1);
                DateTime date2 = new DateTime(2020, 9, 30);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    september.Add(item);
                } 
            }

            var numberProductM9 = 0;
            var totalMoneyM9 = 0;
            foreach (var item in september)
            {
                numberProductM9 += item.NumberProduct;
                totalMoneyM9 += item.TotalMoney;
            }
            ViewBag.september = numberProductM9;
            ViewBag.septemberTotal = totalMoneyM9;
            
            //October
            List<OrderDetailsViewModel> october = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 10, 1);
                DateTime date2 = new DateTime(2020, 10, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    october.Add(item);
                } 
            }

            var numberProductM10 = 0;
            var totalMoneyM10 = 0;
            foreach (var item in october)
            {
                numberProductM10 += item.NumberProduct;
                totalMoneyM10 += item.TotalMoney;
            }
            ViewBag.october = numberProductM10; 
            ViewBag.octoberTotal = totalMoneyM10; 
            
            //november
            List<OrderDetailsViewModel> november = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 11, 1);
                DateTime date2 = new DateTime(2020, 11, 30);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    november.Add(item);
                } 
            }

            var numberProductM11 = 0;
            var totalMoneyM11 = 0;
            foreach (var item in november)
            {
                numberProductM11 += item.NumberProduct;
                totalMoneyM11 += item.TotalMoney;
            }
            ViewBag.november = numberProductM11;
            ViewBag.novemberTotal = totalMoneyM11;
            
            //December
            List<OrderDetailsViewModel> december = new List<OrderDetailsViewModel>();
            foreach (var item in order)
            {
                DateTime date1 = new DateTime(2020, 12, 1);
                DateTime date2 = new DateTime(2020, 12, 31);
                var result = item.CreateDate?.Date.CompareTo(date1);
                var result2 = item.CreateDate?.Date.CompareTo(date2);
                if (result ==1 && result2 ==-1 )
                {
                    december.Add(item);
                } 
            }

            var numberProductM12 = 0;
            var totalMoneyM12 = 0;
            foreach (var item in december)
            {
                numberProductM12 += item.NumberProduct;
                totalMoneyM12 += item.TotalMoney;
            }
            ViewBag.december = numberProductM12;
            ViewBag.decemberTotal = totalMoneyM12;
            
            return
            View();
        }
    }
}