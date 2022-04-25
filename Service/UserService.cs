using IService;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService<User>
    {
        private readonly Context _context;
        public UserService(Context context)
        {
            this._context = context;
        }
        public User GetById(string ID, string Password)
        {
            var query = _context.Users.Where(x => x.Account == ID).FirstOrDefault();
            return query;
        }
    }
}
