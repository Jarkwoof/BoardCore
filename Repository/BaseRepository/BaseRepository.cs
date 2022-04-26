using IRepository.BaseIRespitory;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseRepository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private Context _context;
        public BaseRepository(Context context)
        {
            this._context = context;
        }
        public TEntity QueryByID(Expression<Func<TEntity, bool>> queryCondition)
        {
            var query = _context.Set<TEntity>().Where(queryCondition).FirstOrDefault();

            return query;
        }
    }
}
