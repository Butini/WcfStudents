using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfStudents.Common.Models;
using WcfStudents.Infrastructure.Repositories.Contracts;
using WcfStudents.Infrastructure.Repositories.Implementation.Factory;

namespace WcfStudents.Business.Logic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class StudentService : IStudentService
    {
        private IDataAccessFactory Factory;
        private IDataAccessProduct Service;

        public StudentService()
        {
            Factory = new SqlFactory();
            Service = Factory.NewData();
        }

        public Student Add(string name, string surname, DateTime birthday)
        {
            Student student = new Student(name, surname, birthday);
            return Service.Add(student);
        }

        public Student DeleteById(int id)
        {
            return Service.DeleteById(id);
        }

        public List<Student> GetAll()
        {
            return Service.GetAll();
        }

        public Student GetById(int id)
        {
            return Service.GetById(id);
        }

        public Student Update(int id, string name, string surname, DateTime birthday)
        {
            Student student = new Student(name, surname, birthday);
            student.StudentID = id;
            return Service.Update(student);
        }
    }
}
