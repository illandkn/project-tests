using Domain.Entities;
using Domain.Interfaces.GenericRepository;

namespace Domain.Interfaces.UserRepository
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        Task<IList<UserEntity>> GetAll();
        Task<UserEntity> GetUser(string login, string senha);
    }
}
