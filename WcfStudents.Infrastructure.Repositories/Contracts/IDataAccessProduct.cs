using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudents.Common.Models;

namespace WcfStudents.Infrastructure.Repositories.Contracts
{
    public interface IDataAccessProduct
    {
        Student Add(Student student);
        Student DeleteById(int id);
        Student Update(Student student);
        Student GetById(int id);
        List<Student> GetAll();
    }
}
