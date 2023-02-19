using IRepository.BaseIRespitory;
using Models.Dtos;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseRepository
{
    public class BaseRepository: IBaseRepository
    {
        private Context _context;
        public BaseRepository(Context context)
        {
            this._context = context;
        }

        public LoginDto QueryByID(string account ,string password)
        {
            //var query = _context.Set<TEntity>().Where(queryCondition).FirstOrDefault();
            var query = (from x in _context.Users where (x.Account == account && x.Password == password) select new LoginDto { Account = x.Account, Password = x.Password }).FirstOrDefault();
            return query;
        }
    }
}
