using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfStudents.Business.Logic;
using WcfStudents.Common.Models;

namespace WcfStudents.Business.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class StudentService : IStudentService
    {
        IStudentLogic Logic = new StudentLogic();

        public Student Add(Student student)
        {
            return Logic.Add(student);
        }

        public Student DeleteById(int id)
        {
            return Logic.DeleteById(id);
        }

        public List<Student> GetAll()
        {
            return Logic.GetAll();
        }

        public Student GetById(int id)
        {
            return Logic.GetById(id);
        }

        public Student Update(Student student)
        {
            return Logic.Update(student);
        }
    }
}
