using IRepository.BaseIRespitory;
using Models.Dtos;
using Models.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BaseRepository
{
    public class BaseRepository: IBaseRepository
    {
        private Context _context;
        public BaseRepository(Context context)
        {
            this._context = context;
        }

        public bool Create(User _object)
        {
            if(_object == null)
            {
                return false;
            }
            var dbData = (_context.Users.Where(x => x.Account == _object.Account && x.Password == x.Password)).FirstOrDefault();
            if (dbData == null)
            {            
               
                _context.Users.Add(_object);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(string Account , string Password)
        {
            var dbData = (_context.Users.Where(x => x.Account == Account && x.Password == Password)).FirstOrDefault();
            if(dbData != null)
            {
                _context.Remove(dbData);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<UserDto> GetListAll()
        {
            var query = (from x in _context.Users 
                         select new UserDto
                         { 
                             Account = x.Account,
                             UserName = x.UserName 
                         }).ToList<UserDto>();
            return query;
        }

        public UserDto QueryByID(string account ,string password)
        {
           
            var query = (from x in _context.Users
                         where (x.Account == account && x.Password == password) 
                         select new UserDto 
                         { 
                             Account = x.Account, 
                             UserName = x.UserName 
                         }).FirstOrDefault();
            return query;
        }

        public bool Update(User _object)
        {
            if(_object == null)
            {
                return false;
            }
            var dbData = (_context.Users.Where(x=>x.Guid == _object.Guid)).FirstOrDefault(); ;
            if(dbData != null)
            {
                dbData.Account = _object.Account;
                dbData.Password = _object.Password;
                dbData.UserName = _object.UserName;
                dbData.Status = _object.Status;
                dbData.ModDate = _object.ModDate;
                dbData.ModUid = _object.ModUid;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
