using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.BaseIRespitory
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity QueryByID(string ID, string PassWord);

    }
}
