using Domain.Entities;
using Domain.Interfaces.UserRepository;
using Infra.Context;
using Infra.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(MainContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<UserEntity>> GetAll()
        {
            return await _dbContext.Set<UserEntity>().Where(x => x.Ativo == true).AsNoTracking().ToListAsync();
        }

        public async Task<UserEntity> GetUser(string login, string senha)
        {
            return await _dbContext.Set<UserEntity>().Where(x => x.Login == login && x.Senha == senha).FirstOrDefaultAsync();
        }

    }
}
