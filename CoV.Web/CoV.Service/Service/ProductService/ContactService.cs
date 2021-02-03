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
    public interface IContactService
    {
        /// <summary>
        /// GetAll Color Product 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ContactViewModel> GetAll();

        /// <summary>
        /// Contact customer to shop 
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(ContactViewModel model);

        /// <summary>
        /// Delete Customer to shop 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
    public class ContactService : IContactService
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
        public ContactService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        ///  Funtion  Get add contact customer to shop 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ContactViewModel> GetAll()
        {
            var contacts = _unitOfWork.ContactRepository.ObjectContext.Include(x=> x.Customer).ToList();
            return _mapper.Map<IEnumerable<ContactViewModel>>(contacts);
        }
        
        /// <summary>
        /// delete contact 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var contact = _unitOfWork.ContactRepository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.ContactRepository.Delete(contact);
            _unitOfWork.Save();
        }

        /// <summary>
        /// create contact to shop 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(ContactViewModel model)
        {
            _unitOfWork.ContactRepository.Add(_mapper.Map<Contact>(model));
            _unitOfWork.Save();
        }
    }
}