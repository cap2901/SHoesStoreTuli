using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CoV.Service.Service
{
    public interface IOrderDetailsService
    {
        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns>View  Order Model</returns>
        IEnumerable<OrderDetailsViewModel> GetAll();

        void CreateOrUpdate(OrderDetailsViewModel model);
        void Delete(int id);
        
        

        /// <summary>
        /// update to shipper
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderDetailsViewModel UpdateToShiper(int id);

        /// <summary>
        /// ship nhan 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderDetailsViewModel UpdateShipNhan(int id, string name);

        /// <summary>
        /// iplement ship ferfect
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderDetailsViewModel ShipPerfect(int id);
        
        /// <summary>
        /// SendTo 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderDetailsViewModel SendTo(int id);

        /// <summary>
        /// Hoan hang
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderDetailsViewModel Comback(int id);

        List<OrderViewModel> GetByIdDetails(int id);
    }

    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IProductDetailsService _productDetailsService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OrderDetailsService(IUnitOfWork unitOfWork, IMapper mapper, IProductService productService,
            IProductDetailsService productDetailsService, IHostingEnvironment hostingEnvironment,
            IOrderService orderService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _hostingEnvironment = hostingEnvironment;
            _orderService = orderService;
            _mapper = mapper;
        }

        /// <summary>
        /// get all orderdetails 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderDetailsViewModel> GetAll()
        {
            var productDetails = _unitOfWork.OrderDetailsRespository.ObjectContext.Include(x => x.StatusOrder).ToList();
            return _mapper.Map<IEnumerable<OrderDetailsViewModel>>(productDetails);
        }

        /// <summary>
        /// add order detals 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(OrderDetailsViewModel model)
        {
            _unitOfWork.OrderDetailsRespository.Add(_mapper.Map<OrderDetals>(model));
            _unitOfWork.Save();
        }

        /// <summary>
        /// deleteOrderDetail
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var orderDetalses = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));

            if (orderDetalses != null)
            {
                var order = _orderService.GetAll();
                List<OrderViewModel> list = new List<OrderViewModel>();
                foreach (OrderViewModel item in order)
                {
                    list.Add(item);
                }

                foreach (var item in list)
                {
                    if (item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss") ==
                        orderDetalses.CreateDate.ToString("MM/dd/yyyy HH:mm:ss"))
                    {
//                        _orderService.Delete(item.Id);
                        var productdetails = _productDetailsService
                            .GetByProductColor(item.ProductId, item.Size);
                        if (productdetails != null)
                        {
                            productdetails.NumberProduct += item.Quantity;
                            _productDetailsService.CreateOrUpdate(productdetails);
                        }
                    }
                }
            }

            _unitOfWork.OrderDetailsRespository.Delete(orderDetalses);
            _unitOfWork.Save();
        }

        /// <summary>
        /// update shiper
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetailsViewModel UpdateToShiper(int id)
        {
            var order = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 5;
                _unitOfWork.OrderDetailsRespository.Update(order);
                _unitOfWork.Save();
            }

            return _mapper.Map<OrderDetailsViewModel>(order);
        }

        /// <summary>
        /// Ship nhận hàng 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public OrderDetailsViewModel UpdateShipNhan(int id, string name)
        {
            var order = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.Shipper = name;
                order.StatusId = 4;
                _unitOfWork.OrderDetailsRespository.Update(order);
            }

            _unitOfWork.Save();
            return _mapper.Map<OrderDetailsViewModel>(order);
        }

        /// <summary>
        /// Giao hoan thanh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetailsViewModel ShipPerfect(int id)
        {
            var order = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 3;
                order.EndDate = DateTime.Now;
                _unitOfWork.OrderDetailsRespository.Update(order);
            }

            _unitOfWork.Save();
            return _mapper.Map<OrderDetailsViewModel>(order);
        }

        /// <summary>
        /// hoan hang
        /// </summary>
        /// <returns></returns>
        public OrderDetailsViewModel Comback(int id)
        {
            var order = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 2;
                order.EndDate = DateTime.Now;
                _unitOfWork.OrderDetailsRespository.Update(order);
            }

            _unitOfWork.Save();
            return _mapper.Map<OrderDetailsViewModel>(order);
        }

        public List<OrderViewModel> GetByIdDetails(int id)
        {
            var orderDetalses = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            List<OrderViewModel> list2 = new List<OrderViewModel>();

            if (orderDetalses != null)
            {
                var order = _mapper.Map<List<OrderViewModel>>(_orderService.GetAll());
                List<OrderViewModel> list = new List<OrderViewModel>();
                foreach (OrderViewModel item in order)
                {
                    list.Add(item);
                }

                foreach (var item in list)
                {
                    if (item.CreateDate.ToString("MM/dd/yyyy HH:mm:ss") ==
                        orderDetalses.CreateDate.ToString("MM/dd/yyyy HH:mm:ss"))
                    {
                        var a = item.CreateDate.ToString("MM/dd/yyyy HH:mm");
                        var b = orderDetalses.CreateDate.ToString("MM/dd/yyyy HH:mm");
                        list2.Add(item);
                    }
                }
            }

            return list2;
        }

        /// <summary>
        /// Send to customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetailsViewModel SendTo(int id)
        {
            var order = _unitOfWork.OrderDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 1;
                _unitOfWork.OrderDetailsRespository.Update(order);
                _unitOfWork.Save();
            }
            return _mapper.Map<OrderDetailsViewModel>(order);
        }

    }
}