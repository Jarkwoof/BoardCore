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
        public LoginDto GetById(string ID, string Password)
        {
            Password = MD5Helper.ToMD5String(Password);
            var Account = _BaseRepository.QueryByID(ID,Password);
            return Account;

        }
    }
}
