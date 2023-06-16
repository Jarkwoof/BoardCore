using Common.Helper;
using IRepository.BaseIRespitory;
using IService;
using Models.Dtos;
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
        private IBaseRepository _BaseRepository;
        public UserService(IBaseRepository BaseRepository)
        {
            this._BaseRepository = BaseRepository;
        }

        public bool Create(User value)
        {
            value.Guid = Guid.NewGuid().ToString();
            value.CreUid = value.Account;
            value.CreDate = DateTime.Now;
            return _BaseRepository.Create(value);
        }

        public bool Delete(string Account, string Password)
        {
            return _BaseRepository.Delete(Account ,Password);
        }

        public List<UserDto> GetListAll()
        {
            return _BaseRepository.GetListAll();
        }

        public UserDto QueryByID(string ID, string Password)
        {
            var result= _BaseRepository.QueryByID(ID, Password);
            return result;
        }

        public bool Update(User value)
        {
            value.ModDate = DateTime.Now;
            value.ModUid = value.Account;
            return _BaseRepository.Update(value);
        }

      
    }
}
