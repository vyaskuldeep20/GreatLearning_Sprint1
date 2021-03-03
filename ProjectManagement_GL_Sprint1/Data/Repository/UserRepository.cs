using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;
using System.Threading.Tasks;

namespace ProjectManagement.Data.Core
{
    public class UserRepository: BaseRepository<User,ApiDbContext>,IUserRepository<User>
    {
        private readonly ApiDbContext _context;
        public UserRepository(ApiDbContext context) : base(context)
        {
            _context = context;
        }

        public override Task<User> Update(User entity)
        {
            if(entity==null || entity.Id == 0)
            {
                return null;
            }
            var user = _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.Id == entity.Id);
            if (user == null)
            {
                return null;
            }
            return base.Update(entity);
        }

        public override Task<User> Add(User entity)
        {
            entity.Id = 0;
            return base.Add(entity);
        }

        public Task<User> Get(string userName)
        {
            return _context.Users.AsNoTracking().FirstOrDefaultAsync(usr => usr.Email.ToUpper().Equals(userName.ToUpper()));
        }

        
    }
}
