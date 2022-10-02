using StockFood_Beta.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace StockFood_Beta.repositories
{
    public class UserRepository : RepositoryBase, IuserRepository
    {
        public void add(UserModel userModel)

        bool AuthenticateUser(NetworkCredential credential)
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetbyUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

    }
}
