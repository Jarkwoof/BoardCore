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
        public LoginDto GetById(string UserName ,string Password);
    }
}
