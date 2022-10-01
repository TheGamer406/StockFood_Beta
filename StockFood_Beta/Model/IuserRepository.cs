using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockFood_Beta.Model
{
    public interface IuserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetVyUsername(string username);
        IEnumerable<UserModel> GetByAll();
        //...
         
    }
}
