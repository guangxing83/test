﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceClient.WebService_Employee {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webService/", ConfigurationName="WebService_Employee.GetEmployeeInfo")]
    public interface GetEmployeeInfo {
        
        // CODEGEN: 命名空间  的元素名称 employee_id 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse getEmployeeInfoByID(WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse> getEmployeeInfoByIDAsync(WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest request);
        
        // CODEGEN: 命名空间  的元素名称 return 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WebServiceClient.WebService_Employee.aaaResponse aaa(WebServiceClient.WebService_Employee.aaaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.aaaResponse> aaaAsync(WebServiceClient.WebService_Employee.aaaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getEmployeeInfoByIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getEmployeeInfoByID", Namespace="http://webService/", Order=0)]
        public WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequestBody Body;
        
        public getEmployeeInfoByIDRequest() {
        }
        
        public getEmployeeInfoByIDRequest(WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getEmployeeInfoByIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string employee_id;
        
        public getEmployeeInfoByIDRequestBody() {
        }
        
        public getEmployeeInfoByIDRequestBody(string employee_id) {
            this.employee_id = employee_id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getEmployeeInfoByIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getEmployeeInfoByIDResponse", Namespace="http://webService/", Order=0)]
        public WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponseBody Body;
        
        public getEmployeeInfoByIDResponse() {
        }
        
        public getEmployeeInfoByIDResponse(WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getEmployeeInfoByIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getEmployeeInfoByIDResponseBody() {
        }
        
        public getEmployeeInfoByIDResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class aaaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="aaa", Namespace="http://webService/", Order=0)]
        public WebServiceClient.WebService_Employee.aaaRequestBody Body;
        
        public aaaRequest() {
        }
        
        public aaaRequest(WebServiceClient.WebService_Employee.aaaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class aaaRequestBody {
        
        public aaaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class aaaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="aaaResponse", Namespace="http://webService/", Order=0)]
        public WebServiceClient.WebService_Employee.aaaResponseBody Body;
        
        public aaaResponse() {
        }
        
        public aaaResponse(WebServiceClient.WebService_Employee.aaaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class aaaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public aaaResponseBody() {
        }
        
        public aaaResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GetEmployeeInfoChannel : WebServiceClient.WebService_Employee.GetEmployeeInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetEmployeeInfoClient : System.ServiceModel.ClientBase<WebServiceClient.WebService_Employee.GetEmployeeInfo>, WebServiceClient.WebService_Employee.GetEmployeeInfo {
        
        public GetEmployeeInfoClient() {
        }
        
        public GetEmployeeInfoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetEmployeeInfoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEmployeeInfoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEmployeeInfoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse WebServiceClient.WebService_Employee.GetEmployeeInfo.getEmployeeInfoByID(WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest request) {
            return base.Channel.getEmployeeInfoByID(request);
        }
        
        public string getEmployeeInfoByID(string employee_id) {
            WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest inValue = new WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest();
            inValue.Body = new WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequestBody();
            inValue.Body.employee_id = employee_id;
            WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse retVal = ((WebServiceClient.WebService_Employee.GetEmployeeInfo)(this)).getEmployeeInfoByID(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse> WebServiceClient.WebService_Employee.GetEmployeeInfo.getEmployeeInfoByIDAsync(WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest request) {
            return base.Channel.getEmployeeInfoByIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.getEmployeeInfoByIDResponse> getEmployeeInfoByIDAsync(string employee_id) {
            WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest inValue = new WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequest();
            inValue.Body = new WebServiceClient.WebService_Employee.getEmployeeInfoByIDRequestBody();
            inValue.Body.employee_id = employee_id;
            return ((WebServiceClient.WebService_Employee.GetEmployeeInfo)(this)).getEmployeeInfoByIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceClient.WebService_Employee.aaaResponse WebServiceClient.WebService_Employee.GetEmployeeInfo.aaa(WebServiceClient.WebService_Employee.aaaRequest request) {
            return base.Channel.aaa(request);
        }
        
        public string aaa() {
            WebServiceClient.WebService_Employee.aaaRequest inValue = new WebServiceClient.WebService_Employee.aaaRequest();
            inValue.Body = new WebServiceClient.WebService_Employee.aaaRequestBody();
            WebServiceClient.WebService_Employee.aaaResponse retVal = ((WebServiceClient.WebService_Employee.GetEmployeeInfo)(this)).aaa(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.aaaResponse> WebServiceClient.WebService_Employee.GetEmployeeInfo.aaaAsync(WebServiceClient.WebService_Employee.aaaRequest request) {
            return base.Channel.aaaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceClient.WebService_Employee.aaaResponse> aaaAsync() {
            WebServiceClient.WebService_Employee.aaaRequest inValue = new WebServiceClient.WebService_Employee.aaaRequest();
            inValue.Body = new WebServiceClient.WebService_Employee.aaaRequestBody();
            return ((WebServiceClient.WebService_Employee.GetEmployeeInfo)(this)).aaaAsync(inValue);
        }
    }
}