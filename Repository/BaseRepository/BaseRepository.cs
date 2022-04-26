using IRepository.BaseIRespitory;
using Models.Enitites;
using System.Linq;

namespace Repository.BaseRepository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private Context _context;

        public BaseRepository(Context context)
        {
            this._context = context;
        }

        public TEntity QueryByID(string ID, string PassWord)
        {
            var query = _context.Set<TEntity>().Where(x => x.Account == ID).FirstOrDefault();

            return query;
        }
    }
}