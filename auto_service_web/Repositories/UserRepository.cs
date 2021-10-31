using Microsoft.CodeAnalysis.CSharp.Syntax;
using ServiceAutoFINAL.Entities;
using System.Transactions;

namespace ServiceAutoFINAL.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
       
    }
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        MongoContext context;

        public UserRepository(MongoContext dbContext)
           : base(dbContext)
        {
            context = dbContext;
        }
        
    }

}
