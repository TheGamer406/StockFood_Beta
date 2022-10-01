using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Data.SqlClient;

namespace StockFood_Beta.repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _ConnectionString;
        public RepositoryBase()
        {
            _ConnectionString = "Server(local); DataBase=StockFoodDB; Intregated Security=True";
        }

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_ConnectionString);
            }
        }
    }
}
