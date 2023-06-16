using Models.Dtos;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IService
{
    public interface IUserService
    {
        UserDto QueryByID(string Account, string Password);

        List<UserDto> GetListAll();

        public bool Create(User _object);

        public bool Update(User _object);

        public bool Delete(string Account, string Password );



    }
}
