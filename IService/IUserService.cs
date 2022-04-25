using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IUserService<T>
    {
        public T GetById(string UserName ,string Password);
    }
}
