﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:minor-servicebus-bsklantbeheer:v1:messages", ClrNamespace="minorservicebusbsklantbeheer.v1.messages")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:minor-servicebus-bsklantbeheer:v1:schema", ClrNamespace="minorservicebusbsklantbeheer.v1.schema")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:minor:servicebus:pfslocatorservice:schema", ClrNamespace="minor.servicebus.pfslocatorservice.schema")]
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:minor:servicebus:pfslocatorservice:servicefault", ClrNamespace="minor.servicebus.pfslocatorservice.servicefault")]

namespace minorservicebusbsklantbeheer.v1.messages
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FindKlantenResponseMessage", Namespace="urn:minor-servicebus-bsklantbeheer:v1:messages")]
    public partial class FindKlantenResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private minorservicebusbsklantbeheer.v1.schema.KlantenCollection KlantenField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public minorservicebusbsklantbeheer.v1.schema.KlantenCollection Klanten
        {
            get
            {
                return this.KlantenField;
            }
            set
            {
                this.KlantenField = value;
            }
        }
    }
}
namespace minorservicebusbsklantbeheer.v1.schema
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="KlantenCollection", Namespace="urn:minor-servicebus-bsklantbeheer:v1:schema", ItemName="Klant")]
    public class KlantenCollection : System.Collections.Generic.List<minorservicebusbsklantbeheer.v1.schema.Klant>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Klant", Namespace="urn:minor-servicebus-bsklantbeheer:v1:schema")]
    public partial class Klant : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long idField;
        
        private string klantnummerField;
        
        private string voornaamField;
        
        private string achternaamField;
        
        private string geboortedatumField;
        
        private string straatField;
        
        private string postcodeField;
        
        private string woonplaatsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string klantnummer
        {
            get
            {
                return this.klantnummerField;
            }
            set
            {
                this.klantnummerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string voornaam
        {
            get
            {
                return this.voornaamField;
            }
            set
            {
                this.voornaamField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=3)]
        public string achternaam
        {
            get
            {
                return this.achternaamField;
            }
            set
            {
                this.achternaamField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=4)]
        public string geboortedatum
        {
            get
            {
                return this.geboortedatumField;
            }
            set
            {
                this.geboortedatumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=5)]
        public string straat
        {
            get
            {
                return this.straatField;
            }
            set
            {
                this.straatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=6)]
        public string postcode
        {
            get
            {
                return this.postcodeField;
            }
            set
            {
                this.postcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=7)]
        public string woonplaats
        {
            get
            {
                return this.woonplaatsField;
            }
            set
            {
                this.woonplaatsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KlantenSearchCriteria", Namespace="urn:minor-servicebus-bsklantbeheer:v1:schema")]
    public partial class KlantenSearchCriteria : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string klantnummerField;
        
        private int minLeeftijdField;
        
        private int maxLeeftijdField;
        
        private string woonplaatsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string klantnummer
        {
            get
            {
                return this.klantnummerField;
            }
            set
            {
                this.klantnummerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int minLeeftijd
        {
            get
            {
                return this.minLeeftijdField;
            }
            set
            {
                this.minLeeftijdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int maxLeeftijd
        {
            get
            {
                return this.maxLeeftijdField;
            }
            set
            {
                this.maxLeeftijdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string woonplaats
        {
            get
            {
                return this.woonplaatsField;
            }
            set
            {
                this.woonplaatsField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="urn:minor:servicebus:bsklantbeheer:v1", ConfigurationName="IBSKlantBeheerService")]
public interface IBSKlantBeheerService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlanten", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenResponse")]
    minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage FindKlanten();
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlanten", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenResponse")]
    System.Threading.Tasks.Task<minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage> FindKlantenAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenBy", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenByResponse" +
        "")]
    minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage FindKlantenBy(minorservicebusbsklantbeheer.v1.schema.KlantenSearchCriteria criteria);
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenBy", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/FindKlantenByResponse" +
        "")]
    System.Threading.Tasks.Task<minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage> FindKlantenByAsync(minorservicebusbsklantbeheer.v1.schema.KlantenSearchCriteria criteria);
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/InsertCursusInstantie" +
        "s", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/InsertCursusInstantie" +
        "sResponse")]
    void InsertCursusInstanties(minorservicebusbsklantbeheer.v1.schema.Klant klant);
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/InsertCursusInstantie" +
        "s", ReplyAction="urn:minor:servicebus:bsklantbeheer:v1/IBSKlantBeheerService/InsertCursusInstantie" +
        "sResponse")]
    System.Threading.Tasks.Task InsertCursusInstantiesAsync(minorservicebusbsklantbeheer.v1.schema.Klant klant);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBSKlantBeheerServiceChannel : IBSKlantBeheerService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BSKlantBeheerServiceClient : System.ServiceModel.ClientBase<IBSKlantBeheerService>, IBSKlantBeheerService
{
    
    public BSKlantBeheerServiceClient()
    {
    }
    
    public BSKlantBeheerServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BSKlantBeheerServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BSKlantBeheerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BSKlantBeheerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage FindKlanten()
    {
        return base.Channel.FindKlanten();
    }
    
    public System.Threading.Tasks.Task<minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage> FindKlantenAsync()
    {
        return base.Channel.FindKlantenAsync();
    }
    
    public minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage FindKlantenBy(minorservicebusbsklantbeheer.v1.schema.KlantenSearchCriteria criteria)
    {
        return base.Channel.FindKlantenBy(criteria);
    }
    
    public System.Threading.Tasks.Task<minorservicebusbsklantbeheer.v1.messages.FindKlantenResponseMessage> FindKlantenByAsync(minorservicebusbsklantbeheer.v1.schema.KlantenSearchCriteria criteria)
    {
        return base.Channel.FindKlantenByAsync(criteria);
    }
    
    public void InsertCursusInstanties(minorservicebusbsklantbeheer.v1.schema.Klant klant)
    {
        base.Channel.InsertCursusInstanties(klant);
    }
    
    public System.Threading.Tasks.Task InsertCursusInstantiesAsync(minorservicebusbsklantbeheer.v1.schema.Klant klant)
    {
        return base.Channel.InsertCursusInstantiesAsync(klant);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="urn:minor:servicebus:pfslocatorservice", ConfigurationName="IServiceLocatorService")]
public interface IServiceLocatorService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:pfslocatorservice/IServiceLocatorService/FindMetadataEndpoin" +
        "tAddress", ReplyAction="urn:minor:servicebus:pfslocatorservice/IServiceLocatorService/FindMetadataEndpoin" +
        "tAddressResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(minor.servicebus.pfslocatorservice.servicefault.ServiceLocationServiceFault), Action="urn:minor:servicebus:pfslocatorservice/IServiceLocatorService/FindMetadataEndpoin" +
        "tAddressServiceLocationServiceFaultFault", Name="ServiceLocationServiceFault", Namespace="urn:minor:servicebus:pfslocatorservice:servicefault")]
    string FindMetadataEndpointAddress(minor.servicebus.pfslocatorservice.schema.ServiceLocation serviceLocation);
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:minor:servicebus:pfslocatorservice/IServiceLocatorService/FindMetadataEndpoin" +
        "tAddress", ReplyAction="urn:minor:servicebus:pfslocatorservice/IServiceLocatorService/FindMetadataEndpoin" +
        "tAddressResponse")]
    System.Threading.Tasks.Task<string> FindMetadataEndpointAddressAsync(minor.servicebus.pfslocatorservice.schema.ServiceLocation serviceLocation);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceLocatorServiceChannel : IServiceLocatorService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceLocatorServiceClient : System.ServiceModel.ClientBase<IServiceLocatorService>, IServiceLocatorService
{
    
    public ServiceLocatorServiceClient()
    {
    }
    
    public ServiceLocatorServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceLocatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceLocatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceLocatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string FindMetadataEndpointAddress(minor.servicebus.pfslocatorservice.schema.ServiceLocation serviceLocation)
    {
        return base.Channel.FindMetadataEndpointAddress(serviceLocation);
    }
    
    public System.Threading.Tasks.Task<string> FindMetadataEndpointAddressAsync(minor.servicebus.pfslocatorservice.schema.ServiceLocation serviceLocation)
    {
        return base.Channel.FindMetadataEndpointAddressAsync(serviceLocation);
    }
}
namespace minor.servicebus.pfslocatorservice.schema
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceLocation", Namespace="urn:minor:servicebus:pfslocatorservice:schema")]
    public partial class ServiceLocation : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string NameField;
        
        private string ProfileField;
        
        private System.Nullable<decimal> VersionField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Profile
        {
            get
            {
                return this.ProfileField;
            }
            set
            {
                this.ProfileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Version
        {
            get
            {
                return this.VersionField;
            }
            set
            {
                this.VersionField = value;
            }
        }
    }
}
namespace minor.servicebus.pfslocatorservice.servicefault
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceLocationServiceFault", Namespace="urn:minor:servicebus:pfslocatorservice:servicefault")]
    public partial class ServiceLocationServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ErrorDetailsField;
        
        private string ErrorMessageField;
        
        private bool ResultField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDetails
        {
            get
            {
                return this.ErrorDetailsField;
            }
            set
            {
                this.ErrorDetailsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
    }
}