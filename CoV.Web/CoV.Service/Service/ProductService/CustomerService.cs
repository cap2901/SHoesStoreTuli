﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.DataAccess.Migrations;
using CoV.Service.DataModel;
using CoV.Service.Repository;

namespace CoV.Service.Service
{
    public interface ICustomerService
    {
        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns>View  Customer Model</returns>
        IEnumerable<CustomerViewModel> GetAll();
        
        /// <summary>
        /// get a Customer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CustomerViewModel GetById(int id);
        
        /// <summary>
        /// Delete a Customer
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        
        /// <summary>
        /// Insert Customer
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(CustomerViewModel model);
        
        bool GetByEmail(string email);
        
        bool GetByPhone(string phone);
        bool CheckAccountCustomer(CustomerViewModel model);
        
        bool CheckLoginAccountCustomer(loginCustomerViewModel model);

        bool CheckPass(loginCustomerViewModel model);

        CustomerViewModel GetByName(string name);
    }
    
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Funtion GetAll Account Customer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerViewModel> GetAll()
        {
            var customer = _unitOfWork.CustomerRespository.GetAll();
            return _mapper.Map<IEnumerable<CustomerViewModel>>(customer);
        }
        
        /// <summary>
        ///  Get Customer By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CustomerViewModel GetById(int id)
        {
            var customer = _unitOfWork.CustomerRespository.GetById(id);
            return _mapper.Map<CustomerViewModel>(customer);
        }
        
        /// <summary>
        /// Delete Customer 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var customer = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.CustomerRespository.Delete(customer);
            _unitOfWork.Save();
        }
    
        /// <summary>
        /// Create Customer 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(CustomerViewModel model)
        {
            if (model.Id <= 0 && (model.PassWord==model.ConfiguePassWord))
            {
                model.CreateDate = DateTime.Now;
                _unitOfWork.CustomerRespository.Add(_mapper.Map<Customer>(model));
            }
            else
            {
                model.CreateUpdate = DateTime.Now;
                _unitOfWork.CustomerRespository.Update(_mapper.Map<Customer>(model));
            }
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// get Customer By Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool GetByEmail( string email)
        {
            var emailCustomer = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x => x.Email.Equals(email));
            if (emailCustomer != null) return true ;
            return false; //email not pound
        }
        
        public bool GetByPhone( string phone)
        {
            var phoneCustomer = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x => x.PhoneNumber.Equals(phone));
            if (phoneCustomer != null) return true; 
            return false; //phone not pound
        }
        
        public  bool CheckAccountCustomer(CustomerViewModel model)
        {
            if (GetByEmail(model.Email) == true  || GetByPhone(model.PhoneNumber) == true)
            {
                return true; //  ton tai =true
            }
                return false;
        }
        
        public  bool CheckLoginAccountCustomer(loginCustomerViewModel model)
        {
            if (model.Email != null)
            {
                var customerEmail = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x =>
                    x.Email.Equals(model.Email));
                if (customerEmail != null)
                {
                    return true;
                }
                
                var customerPhone = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x =>
                    x.PhoneNumber.Equals(model.Email));
                if (customerPhone != null)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// check pass word
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CheckPass(loginCustomerViewModel model)
        {
            if (model.Email != null)
            {
                var customerEmail = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x =>
                    x.Email.Equals(model.Email));
                if (customerEmail != null && customerEmail.PassWord.Equals(model.PassWord))
                {
                    return true;
                }
                
                var customerPhone = _unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x =>
                    x.PhoneNumber.Equals(model.Email));
                if (customerPhone != null && customerPhone.PassWord.Equals(model.PassWord))
                {
                    return true;
                }
            }
            return false;
        }

        public CustomerViewModel GetByName(string name)
        {
            var customerEmail =_unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x => x.Email.Equals(name));
            var customerPhone =_unitOfWork.CustomerRespository.ObjectContext.FirstOrDefault(x => x.PhoneNumber.Equals(name));
            if (customerPhone != null) return _mapper.Map<CustomerViewModel>(customerPhone);
            return _mapper.Map<CustomerViewModel>(customerEmail);
        }
    }
}