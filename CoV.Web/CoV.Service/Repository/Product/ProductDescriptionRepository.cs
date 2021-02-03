using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    public interface IProductDescriptionRepository : IGenericRepository<ProductDescription>
    {
        
    }
    public class ProductDescriptionRepository : GenericRepository<ProductDescription>,IProductDescriptionRepository
    {
        /// <summary>
        /// Desciption produc repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ProductDescriptionRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}