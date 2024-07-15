using OTS.Domain.Entities;
using OTS.Domain.Interfaces;

namespace OTS.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(OtsDbContext context) : base(context) { }

        public Task<ApplicationUser> GetByEmail(string email) => Task.FromResult(new ApplicationUser());
    }
}
