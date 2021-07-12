using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfStudents.Common.Models;

namespace WcfStudents.Business.Logic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    public interface IStudentLogic
    {
        Student Add(Student student);
        Student DeleteById(int id);
        Student Update(Student student);
        Student GetById(int id);
        List<Student> GetAll();
    }
}
