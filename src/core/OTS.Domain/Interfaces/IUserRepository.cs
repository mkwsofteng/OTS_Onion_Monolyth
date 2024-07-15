using OTS.Domain.Entities;

namespace OTS.Domain.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetByEmail(string email);
    }
}
