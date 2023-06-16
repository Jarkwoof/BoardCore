using Models.Dtos;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.BaseIRespitory
{
    public interface IBaseRepository
    {
        UserDto QueryByID(string Account , string Password);

        List<UserDto> GetListAll();

        public bool Create(User _object);

        public bool Update(User _object);

        public bool Delete(string Account  ,string Password);
    }
}
