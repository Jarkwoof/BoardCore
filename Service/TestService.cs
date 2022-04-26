using IService;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TestService : ITestService<User>
    {
        private readonly Context _context;

        public TestService(Context context)
        {
            this._context = context;
        }
        public User GetById(string Id, string Password)
        {
            var query = (from x in _context.Users.Where(x => x.Account == Id) select x).FirstOrDefault();
            return query;
        }
    }
}
