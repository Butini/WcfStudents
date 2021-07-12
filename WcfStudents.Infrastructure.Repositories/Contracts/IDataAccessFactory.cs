using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfStudents.Infrastructure.Repositories.Contracts
{
    public interface IDataAccessFactory
    {
        IDataAccessProduct NewData();
    }
}
