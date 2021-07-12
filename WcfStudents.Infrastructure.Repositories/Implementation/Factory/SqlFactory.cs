using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudents.Infrastructure.Repositories.Contracts;
using WcfStudents.Infrastructure.Repositories.Implementation.Product;

namespace WcfStudents.Infrastructure.Repositories.Implementation.Factory
{
    public class SqlFactory : IDataAccessFactory
    {
        public IDataAccessProduct NewData()
        {
            return new SqlProduct();
        }
    }
}
