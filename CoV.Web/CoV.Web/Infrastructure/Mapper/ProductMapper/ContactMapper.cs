using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<ContactViewModel, Contact>();
            CreateMap<Contact, ContactViewModel>();
        }
    }
}