using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.BaseIRespitory
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity QueryByID(Expression<Func<TEntity, bool>> predicate);
    }
}
