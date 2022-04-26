using IRepository.BaseIRespitory;
using IService;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private IBaseRepository<User> _BaseRepository;
        public UserService(IBaseRepository<User> BaseRepository)
        {
            this._BaseRepository = BaseRepository;
        }
        public User GetById(string UserName, string Password)
        {
            var query = _BaseRepository.QueryByID(x => x.Account.Equals(UserName));
            return query;
        }
    }
}
