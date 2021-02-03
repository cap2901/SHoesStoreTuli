using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;

namespace CoV.Web.Infrastructure.Mapper
{
    public class ProductDescriptionMapper : Profile
    {
        public ProductDescriptionMapper()
        {
            CreateMap<ProductDesciptionViewModel, ProductDescription>();
            CreateMap<ProductDescription, ProductDesciptionViewModel>();
        }
    }
}