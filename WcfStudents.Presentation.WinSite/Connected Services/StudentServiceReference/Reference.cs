﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfStudents.Presentation.WinSite.StudentServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServiceReference.IStudentService")]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentById", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIdResponse")]
        string GetStudentById(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentById", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<string> GetStudentByIdAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : WcfStudents.Presentation.WinSite.StudentServiceReference.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<WcfStudents.Presentation.WinSite.StudentServiceReference.IStudentService>, WcfStudents.Presentation.WinSite.StudentServiceReference.IStudentService {
        
        public StudentServiceClient() {
        }
        
        public StudentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetStudentById(int value) {
            return base.Channel.GetStudentById(value);
        }
        
        public System.Threading.Tasks.Task<string> GetStudentByIdAsync(int value) {
            return base.Channel.GetStudentByIdAsync(value);
        }
    }
}
