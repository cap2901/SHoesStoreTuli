using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CoV.Service.Service
{
    public interface IProductDesciptionService
    {
        IEnumerable<ProductDesciptionViewModel> GetAll();
        void Delete(int id);
        void CreateOrUpdate(ProductDesciptionViewModel model);

        ProductDesciptionViewModel GetbyIdProduct(int id);
    }
    public class ProductDesciptionService : IProductDesciptionService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  ColorProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ProductDesciptionService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// get all product description 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductDesciptionViewModel> GetAll()
        {
            var colorProducts = _unitOfWork.ProductDescriptionRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDesciptionViewModel>>(colorProducts);
        }
        
        public void Delete(int id)
        {
            var customer = _unitOfWork.ProductDescriptionRepository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.ProductDescriptionRepository.Delete(customer);
            _unitOfWork.Save();
        }
    
        /// <summary>
        /// Create Descripton  
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(ProductDesciptionViewModel model)
        {
            if (model.Id <= 0)
            {
                _unitOfWork.ProductDescriptionRepository.Add(_mapper.Map<ProductDescription>(model));
            }
            else
            {
                _unitOfWork.ProductDescriptionRepository.Update(_mapper.Map<ProductDescription>(model));
            }
            _unitOfWork.Save();
        }

        /// <summary>
        /// get product description by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDesciptionViewModel GetbyIdProduct(int id)
        {
            return _mapper.Map<ProductDesciptionViewModel>(_unitOfWork.ProductDescriptionRepository.
                ObjectContext.AsNoTracking().FirstOrDefault(x=>x.ProductId.Equals(id)));
        }
    }
}