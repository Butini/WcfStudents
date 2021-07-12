using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfStudents.Common.Models;
using WcfStudents.Infrastructure.Repositories.Contracts;
using WcfStudents.Infrastructure.Repositories.Implementation.Factory;

namespace WcfStudents.Business.Logic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class StudentLogic : IStudentLogic
    {
        private IDataAccessFactory Factory;
        private IDataAccessProduct Service;

        public StudentLogic()
        {
            Factory = new SqlFactory();
            Service = Factory.NewData();
        }

        public Student Add(Student student)
        {
            student.Age = GetAgeByBirthday(student.Birthday);
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

        public Student Update(Student student)
        {
            student.Age = GetAgeByBirthday(student.Birthday);
            return Service.Update(student);
        }

        private int GetAgeByBirthday(DateTime birthday)
        {
            int age = 0;
            age = DateTime.Today.Year - birthday.Year;

            if (DateTime.Today.DayOfYear < birthday.DayOfYear) age--;

            return age;
        }
    }
}
