using CoV.DataAccess.Data;

namespace CoV.Service.Repository
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
        
    }
    public class ContactRepository : GenericRepository<Contact>,IContactRepository
    {
        /// <summary>
        /// contact customer to shop repository
        /// </summary>
        /// <param name="dbContext"></param>
        public ContactRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}