﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfStudents.Common.Models;

namespace WcfStudents.Business.Logic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Student Add(string name, string surname, DateTime birthday);
        [OperationContract]
        Student DeleteById(int id);
        [OperationContract]
        Student Update(int id, string name, string surname, DateTime birthday);
        [OperationContract]
        Student GetById(int id);
        [OperationContract]
        List<Student> GetAll();
    }
}
